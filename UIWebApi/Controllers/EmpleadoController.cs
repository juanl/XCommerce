using Dominio.Entidades;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace UIWebApi.Controllers
{
    public class EmpleadoController : ApiController
    {
        private EmpleadoServicio servicioEmpleado;
        public EmpleadoController()
        {
            servicioEmpleado = new Servicio.EmpleadoServicio();
        }
        // GET: api/Empleado
        [ResponseType(typeof(List<Servicio.DTOs.EmpleadoDTO>))]
        public IEnumerable<Servicio.DTOs.EmpleadoDTO> Get()
        {
            return servicioEmpleado.Listar();
        }

        // GET: api/Empleado/5
        [ResponseType(typeof(Servicio.DTOs.EmpleadoDTO))]
        public IHttpActionResult Get(int id)
        {
            var empleado = servicioEmpleado.Buscar(id);
            if (empleado == null)
                return NotFound();
            else
                return Ok(empleado);
        }

        // POST: api/Empleado
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Empleado/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Empleado/5
        public void Delete(int id)
        {
        }
    }
}
