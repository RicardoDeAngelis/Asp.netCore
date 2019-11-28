using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Asp.netCoreClientes.Models
{
        // clase para siembra o genrear de datos
    public class ClienteContext :DbContext
    {

        public DbSet <ClienteModel> Clientes { get; set; }

        // constructor recibe un contexto
        public ClienteContext(DbContextOptions<ClienteContext> options):base (options) 
         { 

         }
        // sobreEscribimos el metodo OnModelCreating 
         protected override void OnModelCreating(ModelBuilder modelBuilder){
             
            //  llamamos al metodo modelBuilder base para que primero haga lo que tenga que hacer
            base.OnModelCreating(modelBuilder);
            // luego creamos la lista de clientes
        modelBuilder.Entity<ClienteModel>().HasData(
            new ClienteModel{Id=Guid.NewGuid().ToString(),Apellido="Garcia",Nombre="Ricardo",Dni="324534534",Localidad="Capital",Telefono="23423234"},
            new ClienteModel{Id=Guid.NewGuid().ToString(),Apellido="Perez",Nombre="Ricardo",Dni="324534534",Localidad="Capital",Telefono="23423234"},
            new ClienteModel{Id=Guid.NewGuid().ToString(),Apellido="Paez",Nombre="Ricardo",Dni="324534534",Localidad="Capital",Telefono="23423234"},
            new ClienteModel{Id=Guid.NewGuid().ToString(),Apellido="Garcia",Nombre="Ricardo",Dni="324534534",Localidad="Capital",Telefono="23423234"},
            new ClienteModel{Id=Guid.NewGuid().ToString(),Apellido="Perez",Nombre="Ricardo",Dni="324534534",Localidad="Capital",Telefono="23423234"},
            new ClienteModel{Id=Guid.NewGuid().ToString(),Apellido="Paez",Nombre="Ricardo",Dni="324534534",Localidad="Capital",Telefono="23423234"});
            // hasData puede recibir una lista o un objeto
                
             }
    }
}