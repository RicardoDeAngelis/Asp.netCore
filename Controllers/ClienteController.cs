using System;
using System.Linq;
using System.Collections.Generic;
using Asp.netCoreClientes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.netCoreClientes.Controllers
{
    public class ClienteController : Controller
    {
            //metodo para buscar por Id usaremos linq 
        
        [Route("Cliente/Index")]
        [Route("Cliente/Index/{clienteId}")]
        public IActionResult Index(string clienteId)
        {
             if (!string.IsNullOrWhiteSpace(clienteId))
             {
            var cliente=from client in _context.Clientes
                        where client.Id==clienteId
                        select client;    

            return View (cliente.SingleOrDefault());

             }   
             else
             {
                //  podriamos cambiar por la vista de error
             return View("MultiCliente",_context.Clientes);

             }

            
        }


     


        public IActionResult MultiCliente(){

            // asignamos a listaClientes el contexto de nuetra DB y que me traiga el primer dato 
            return View("MultiCliente",_context.Clientes);
        }

        //  Alta cliente 
         public IActionResult Create(){

                return View();
            }
            // Configurando boton submit
            [HttpPost]
             public IActionResult Create(ClienteModel clienteModel){
                // Compreobamos que el modelo sea valido
                if(ModelState.IsValid)
                {
                    clienteModel.Id=Guid.NewGuid().ToString();
                   _context.Clientes.Add(clienteModel);
                   _context.SaveChanges();
                   ViewBag.MensajeExtra="Cliente Creado";

                    return View("Index",clienteModel);


                }
                else
                {
                    return View(clienteModel);                       

                }
                
            }
            // Modificacion
          
            public IActionResult Edit(string id)   
        {
            if(!string.IsNullOrWhiteSpace(id)){

                var cliente = _context.Clientes.Find(id);

                return View(cliente);
            }else{
                return View("MultiClientes", _context.Clientes);
            }
        }

        [HttpPost]
        public IActionResult Edit(ClienteModel clienteModel)   
        {       
            if(ModelState.IsValid){
                   // clienteModel.Id=Guid.NewGuid().ToString();
                _context.Clientes.Update(clienteModel);
                _context.SaveChanges();
                 ViewBag.MensajeExtra="Cliente actualizado";
            return View("Index",clienteModel);

            }else
            {
                return View("MultiCliente", _context.Clientes);
            }
            
        }


                    // Eliminacion
         
            public IActionResult Delete (string id) {

            if(string.IsNullOrWhiteSpace(id)){
                return View("MultiCliente");
            }else
            {
                 var cliente = from client in _context.Clientes
                                where client.Id==id
                                select client;
             
                _context.Clientes.Remove(cliente.FirstOrDefault());
                _context.SaveChanges();
                 ViewBag.MensajeExtra="Cliente borrado";    
                return RedirectToAction("MultiCliente");
                

               
                

                 
            

        
            }
        }

         
    
        

            // creamos una variable para manejar context
            private ClienteContext _context;

            // creamos un contructor que reciba context
            public ClienteController(ClienteContext context){
                // asignamos  ccontext a la variable local
            _context=context;

        }
    }
}