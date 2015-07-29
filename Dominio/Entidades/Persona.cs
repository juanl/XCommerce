using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public abstract class Persona
    {
        public long Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string DNI { get; set; }

        [NotMapped]
        public string ApyNom {
            get
            {
                return string.Format("{0} {1}", Apellido, Nombre);
            }
        }

    }
}
