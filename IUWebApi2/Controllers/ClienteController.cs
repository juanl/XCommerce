using Servicio;
using Servicio.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace IUWebApi2.Controllers
{
    public class ClienteController : ApiController
    {
        private ClienteServicio servicio;
        public ClienteController()
        {
            servicio = new Servicio.ClienteServicio();
        }
        // GET: api/Cliente
        [ResponseType(typeof(List<ClienteDTO>))]
        public IEnumerable<ClienteDTO> Get()
        {
            return servicio.ListarTodos();
        }

        // GET: api/Cliente/5
        [ResponseType(typeof(ClienteDTO))]
        public IHttpActionResult Get(int id)
        {
            var cliente = servicio.GetClienteById(id);
            if (cliente == null)
                return NotFound();
            else
                return Ok(cliente);
        }

        // POST: api/Cliente
        public void Post(ClienteDTO cliente)
        {
            servicio.Guardar(cliente);
        }

        // PUT: api/Cliente/5
        public void Put(ClienteDTO cliente)
        {
            servicio.Guardar(cliente);
        }

        // DELETE: api/Cliente/5
        public void Delete(int id)
        {
            servicio.Borrar(id);
        }
    }
}
