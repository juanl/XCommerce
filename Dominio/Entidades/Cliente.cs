using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    [Table("Cliente", Schema = "dbo")]
    public class Cliente : Persona
    {
        public string Domicilio { get; set; }

        public virtual ICollection<Factura> Facturas { get; set; }
    }
}
