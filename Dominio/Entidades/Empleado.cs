using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades.Validacion;

namespace Dominio.Entidades
{
    [Table("Empleado",Schema = "dbo")]
    [MetadataType(typeof(IEmpleadoValidacion))]
    public class Empleado : Persona
    {
        public long CategoriaId { get; set; }

        public int Legajo { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Factura> Facturas  { get; set; }
    }
}
