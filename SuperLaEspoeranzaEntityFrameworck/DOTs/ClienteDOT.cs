using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLaEspoeranzaEntityFrameworck.DOTs
{
    public class ClienteDOT
    {
        public string IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string TipoMembresia { get; set; }
        public bool MembresiaEstado { get; set; }
        public byte[]? Foto { get; set; }
        public int PuntosCompra { get; set; }
    }
}
