using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio.DTOs
{
    public class ClienteDTO
    {
        public long Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public string Domicilio { get; set; }
    }
}
