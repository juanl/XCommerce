using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UIWeb.Models;

namespace UIWeb.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            var serv = new Servicio.SueldoServicio();

            var resultado = serv.CalcularSueldos().Select(x => new EmpleadoSueldoViewModel()
            {
                Apellido = x.Apellido,
                Nombre = x.Nombre,
                DNI = x.DNI,
                Categoria = x.Categoria,
                Basico = x.Basico,
                Comision = x.Comision,
                Premio = x.Premio,
                Sueldo = x.Sueldo
            });

            return View(resultado);
        }
    }
}