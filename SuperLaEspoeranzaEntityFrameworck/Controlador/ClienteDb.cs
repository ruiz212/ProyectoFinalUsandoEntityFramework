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

        public  void AgregarCliente(ClienteDOT clienteDto)
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
            SuperLaEsperanzaDbContex.Clientes.Add(clienteAgregar);
            SuperLaEsperanzaDbContex.SaveChanges();
            MessageBox.Show("Cliente agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
