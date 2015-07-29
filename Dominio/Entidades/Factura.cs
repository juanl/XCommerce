using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    [Table("Factura", Schema = "dbo")]
    public class Factura
    {
        public long Id { get; set; }
        public long EmpleadoId { get; set; }
        public long ClienteId { get; set; }

        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        public virtual Empleado  Empleado { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
