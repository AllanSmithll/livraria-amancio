using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using APILivraria.Models;
using Microsoft.EntityFrameworkCore;

namespace APILivraria
{
    public class Startup
    {
        public Startup(IConfiguration configuration) {
            configRoot = configuration;
        }
        public IConfiguration configRoot { get; }

        public void ConfigureServices(IServiceCollection services) {
            services.AddDbContext<Contexto>(opcoes => opcoes.UseSqlServer(configRoot.GetConnectionString("ConexaoDB")));
            services.AddRazorPages();
        }
        public void Configure(WebApplication app, IWebHostEnvironment env) {
            if (!app.Environment.IsDevelopment()) {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapRazorPages();
            app.Run();
        }
    }
}