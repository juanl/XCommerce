using Dominio.Entidades;
using Infraestructura.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class EmpleadoServicio
    {
        private Contexto contexto;

        public EmpleadoServicio()
        {
            contexto = new Contexto();
        }

        public List<DTOs.EmpleadoDTO> Listar()
        {

            var listado = contexto.Empleados
                .Select(s => new DTOs.EmpleadoDTO()
                {
                    Id = s.Id,
                    Legajo = s.Legajo,
                    Nombre = s.Nombre,
                    Apellido = s.Apellido,
                    DNI = s.DNI,
                }).ToList();
            return listado;
        }

        public DTOs.EmpleadoDTO Buscar(int id)
        {
            var empleado = contexto.Empleados.Select(b =>
                new DTOs.EmpleadoDTO()
                {
                    Id = b.Id,
                    DNI = b.DNI,
                    Apellido = b.Apellido,
                    Nombre = b.Nombre,
                    Legajo = b.Legajo
                }).FirstOrDefault(b => b.Id == id);
            return empleado;
        }

    }
}
