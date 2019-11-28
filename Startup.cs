using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.netCoreClientes.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;


namespace Asp.netCoreClientes
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded=context =>true;
                options.MinimumSameSitePolicy=Microsoft.AspNetCore.Http.SameSiteMode.None;
            }
            )   ; 

            services.AddControllersWithViews();

            // Conexion  a DbInMemory
            // services.AddDbContext<ClienteContext>(
            // // utilizamos un delegado para confgurar el servicio de la datanabe in memory
            // options => options.UseInMemoryDatabase(databaseName:"testDB")
            // );

            // Conexion  a Db in Azure
            string connString=ConfigurationExtensions.GetConnectionString(this.Configuration,"DefaultConnectionsString");
            services.AddDbContext<ClienteContext>(
            // utilizamos un delegado para configurar
            // el servicio de la DB in Azure pasandole por parametro la cadena de conexion
            options => options.UseSqlServer(connString)
            );

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=cliente}/{action=Index}/{id?}");
            });
        }
    }
}
