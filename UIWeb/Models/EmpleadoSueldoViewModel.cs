using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UIWeb.Models
{
    public class EmpleadoSueldoViewModel
    {
        public string Categoria { get; set; }

        public string Apellido { get; set; }
        public string Nombre { get; set; }

        [Display(Name = "Apellido y Nombre")]
        public string ApyNom {
            get
            {
                return string.Format("{0} {1}", Apellido, Nombre);
            }
        }
        public string DNI { get; set; }
        public decimal Basico { get; set; }
        public decimal Premio { get; set; }
        public decimal Comision { get; set; }
        public decimal Sueldo{ get; set; }
    }
}