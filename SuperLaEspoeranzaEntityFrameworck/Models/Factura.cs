using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLaEspoeranzaEntityFrameworck.Models
{
    public class Factura
    {
        public string IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }

        public string IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        public string IdCliente { get; set; }
        public Cliente Cliente { get; set; }

        public ICollection<DetalleFactura> DetallesFactura { get; set; }
    }
}
