using Dominio.Entidades;
using Infraestructura.Context;
using Servicio.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class ClienteServicio
    {
        private Contexto contexto;
        public ClienteServicio()
        {
            contexto = new Contexto();
        }

        public List<ClienteDTO> ListarTodos()
        {
            var clientes = contexto.Clientes.Select(
                p => new ClienteDTO()
                {
                    Id = p.Id,
                    Apellido = p.Apellido,
                    DNI = p.DNI,
                    Domicilio = p.Domicilio,
                    Nombre = p.Nombre
                }
                ).ToList();
            return clientes;
        }
        public ClienteDTO GetClienteById(long Id)
        {
            var cliente = contexto.Clientes.Select(
                    p => new ClienteDTO()
                    {
                        Id = p.Id,
                        Apellido = p.Apellido,
                        DNI = p.DNI,
                        Domicilio = p.Domicilio,
                        Nombre = p.Nombre
                    }
                ).FirstOrDefault(p => p.Id == Id);
            return cliente;
        }

        public void Borrar(int id)
        {
            var cliente = (Cliente)contexto.Clientes
                   .Where(p => p.Id == id)
                   .FirstOrDefault();

            if (cliente != null)
                contexto.Clientes.Remove(cliente);

            contexto.SaveChanges();
        }

        private Cliente ConvertirDesdeClienteDTO(ClienteDTO clienteDTO)
        {
            var cliente = new Cliente()
            {
                Apellido = clienteDTO.Apellido,
                Nombre = clienteDTO.Nombre,
                DNI = clienteDTO.DNI,
                Domicilio = clienteDTO.Domicilio,
                Id = clienteDTO.Id
            };
            return cliente;
        }

        public void Guardar(ClienteDTO clienteDTO)
        {
            var cliente = ConvertirDesdeClienteDTO(clienteDTO);
            contexto.Clientes.Add(cliente);
            contexto.SaveChanges();
        }
    }
}
