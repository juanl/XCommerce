using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Infraestructura.Context;
using Servicio.DTOs;

namespace Servicio
{
    public class SueldoServicio
    {
        private Contexto contexto;

        public SueldoServicio()
        {
            contexto = new Contexto();
        }

        public List<SueldoDTO> CalcularSueldos()
        {
            var fechaDesde = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1, 0, 0, 0);
            var fechaHasta = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month), 11, 59, 59);

            var resultado = contexto.Empleados
            .Include("Categoria")
            .Include("Categoria.DetalleCategorias")
            .Include("Facturas").
            Select(x => new SueldoDTO
            {
                Apellido = x.Apellido,
                Nombre = x.Nombre,
                Categoria = x.Categoria.Descripcion,
                Basico =
            x.Categoria.DetalleCategorias.FirstOrDefault(
            dc =>
            dc.FechaVigencia ==
            x.Categoria.DetalleCategorias.Where(dc2 => dc2.FechaVigencia <= DateTime.Now)
            .Max(f => f.FechaVigencia)).Basico,
                Comision =
            (x.Facturas.Any(f => f.Fecha >= fechaDesde && f.Fecha <= fechaHasta)
            ? x.Facturas.Where(f => f.Fecha >= fechaDesde && f.Fecha <= fechaHasta).Sum(fa => fa.Total)
            : 0) * (3m / 100m),
                DNI = x.DNI,
                Premio =
            (x.Facturas.Any(f => f.Fecha >= fechaDesde && f.Fecha <= fechaHasta)
            ? x.Facturas.Where(f => f.Fecha >= fechaDesde && f.Fecha <= fechaHasta).Sum(fa => fa.Total)
            : 0) > 17000m
            ? 2000
            : 0
            });
            return resultado.ToList();
        }
    }
}
