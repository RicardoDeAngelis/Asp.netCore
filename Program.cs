using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.netCoreClientes.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Asp.netCoreClientes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // CreateHostBuilder(args).Build().Run();
            // controlamos primero que la base de datos este creada y despues ejecutamos el webserver
            // Para evitar que CreateHostBuilder nos quede vivo en memoria usamos using
            var host=CreateHostBuilder(args).Build();
            // configuaramos el acceso a la DB
   
            using(var scope=host.Services.CreateScope()){ 
            var services=scope.ServiceProvider;
            // como todo puede fallar encerramos en un bloque try catch
            try{
            var context=services.GetRequiredService<ClienteContext>();
            // seguramos que este creada la DB
            context.Database.EnsureCreated();
            }
            catch(Exception ex){

                var logger=services.GetRequiredService<ILogger<Program>>();
                logger.LogError(ex,"Error creando DB");                    

            }
           } 
            

            host.Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
