using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Validacion
{
    public interface IEmpleadoValidacion
    {
        [Required]
        [MaxLength(250)]
        string Apellido { get; set; }
        string Nombre { get; set; }
        string DNI { get; set; }
        long CategoriaId { get; set; }
        int Legajo { get; set; }
    }
}
