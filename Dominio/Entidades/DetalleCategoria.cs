using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    [Table("CategoriaDetalle", Schema = "dbo")]
    public class DetalleCategoria
    {
        public long Id { get; set; }
        public long CategoriaId { get; set; }

        public decimal Basico { get; set; }

        public DateTime FechaVigencia { get; set; }
        public virtual  Categoria Categoria { get; set; }
    }
}
