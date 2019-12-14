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
            new ClienteModel{Id=Guid.NewGuid().ToString(),Apellido="Garcia",Nombre="Ricardo",Dni="32455664",Localidad="Capital",Telefono="23423234"},
            new ClienteModel{Id=Guid.NewGuid().ToString(),Apellido="Perez",Nombre="Exequirl",Dni="32453444",Localidad="Capital",Telefono="23423234"},
            new ClienteModel{Id=Guid.NewGuid().ToString(),Apellido="Paez",Nombre="Jorge",Dni="324334534",Localidad="Capital",Telefono="23423234"},
            new ClienteModel{Id=Guid.NewGuid().ToString(),Apellido="Garcia",Nombre="Jose",Dni="324576534",Localidad="Capital",Telefono="23423234"},
            new ClienteModel{Id=Guid.NewGuid().ToString(),Apellido="Toscano",Nombre="Gonzalo",Dni="324554534",Localidad="Capital",Telefono="23423234"},
            new ClienteModel{Id=Guid.NewGuid().ToString(),Apellido="Gonzales",Nombre="Fabricio",Dni="324534534",Localidad="Capital",Telefono="23423234"});
            // hasData puede recibir una lista o un objeto
                
             }
    }
}