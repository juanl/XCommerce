using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;

namespace Dominio.Entidades
{
    [Table("Categoria", Schema = "dbo")]
    public class Categoria
    {
        public long Id { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public virtual  ICollection<DetalleCategoria> DetalleCategorias { get; set; }
        public virtual ICollection<Empleado> Empleados  { get; set; }
    }
}
