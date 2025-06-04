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
        public DateTime? Fecha { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? Impuesto { get; set; }
        public decimal? Total { get; set; }
        public string? IdUsuario { get; set; } // Clave foránea
        public string? IdCliente { get; set; } // Clave foránea

        // Propiedades de navegación
        public Usuario? Usuario { get; set; }
        public Cliente? Cliente { get; set; }
        public ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();
    }
}
