using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.DTOs
{
    public class SueldoDTO
    {
        public string Categoria { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public decimal Basico { get; set; }
        public decimal Premio { get; set; }
        public decimal Comision { get; set; }

        public decimal Sueldo
        {
            get { return Basico + Premio + Comision; }
        }
    }
}
