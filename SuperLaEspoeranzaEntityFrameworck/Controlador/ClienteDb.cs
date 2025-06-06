using SuperLaEspoeranzaEntityFrameworck.Data;
using SuperLaEspoeranzaEntityFrameworck.DOTs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLaEspoeranzaEntityFrameworck.Controlador
{
    public class ClienteDb
    {
        SuperLaEsperanzaDbContex SuperLaEsperanzaDbContex = new SuperLaEsperanzaDbContex();

        public void AgregarCliente(ClienteDOT clienteDto)
        {
            var clienteAgregar = new Models.Cliente
            {
                IdCliente = clienteDto.IdCliente,
                Nombre = clienteDto.Nombre,
                Telefono = clienteDto.Telefono,
                Direccion = clienteDto.Direccion,
                TipoMenbresia = clienteDto.TipoMembresia,
                MenbresiaEstado = true,
                Foto = clienteDto.Foto,
                PuntosCompra = 0
            };
            SuperLaEsperanzaDbContex.Cliente.Add(clienteAgregar);
            SuperLaEsperanzaDbContex.SaveChanges();
            MessageBox.Show("Cliente agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<ClienteDOT> ObtenerClientes()
        {
            var clientes = SuperLaEsperanzaDbContex.Cliente
                .ToList();
            List<ClienteDOT> clienteDtos = new List<ClienteDOT>();
            foreach (var cliente in clientes)
            {
                clienteDtos.Add(new ClienteDOT
                {
                    IdCliente = cliente.IdCliente,
                    Nombre = cliente.Nombre,
                    Telefono = cliente.Telefono,
                    Direccion = cliente.Direccion,
                    TipoMembresia = cliente.TipoMenbresia,
                    MembresiaEstado = cliente.MenbresiaEstado,
                    Foto = cliente.Foto,
                    PuntosCompra = cliente.PuntosCompra
                });
            }
            return clienteDtos;
        }

        public List<ClienteDOT> ObtenerClientesPorTipoMenbrecia(string tipoMenbresia)
        {
            var clientes = SuperLaEsperanzaDbContex.Cliente
                .Where(c => c.TipoMenbresia == tipoMenbresia)
                .ToList();

            List<ClienteDOT> clienteDtos = new List<ClienteDOT>();
            foreach (var cliente in clientes)
            {
                clienteDtos.Add(new ClienteDOT
                {
                    IdCliente = cliente.IdCliente,
                    Nombre = cliente.Nombre,
                    Telefono = cliente.Telefono,
                    Direccion = cliente.Direccion,
                    TipoMembresia = cliente.TipoMenbresia,
                    MembresiaEstado = cliente.MenbresiaEstado,
                    Foto = cliente.Foto,
                    PuntosCompra = cliente.PuntosCompra
                });
            }
            return clienteDtos;
        }
    }
}
