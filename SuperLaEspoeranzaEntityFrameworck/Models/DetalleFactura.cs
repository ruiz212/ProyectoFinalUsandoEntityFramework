using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLaEspoeranzaEntityFrameworck.Models
{
    public class DetalleFactura
    {
        public string IdDetalle { get; set; }
        public string? IdFactura { get; set; } // Clave foránea
        public string? IdProducto { get; set; } // Clave foránea
        public int? Cantidad { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? Total { get; set; }

        // Propiedades de navegación
        public Factura? Factura { get; set; }
        public Producto? Producto { get; set; }
    }
}
