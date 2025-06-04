using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLaEspoeranzaEntityFrameworck.Models
{
    public class DetalleCompra
    {
        public string IdDetalleCompra { get; set; }
        public string? IdCompra { get; set; } // Clave foránea
        public string? IdProducto { get; set; } // Clave foránea
        public int? Cantidad { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? Total { get; set; }

        // Propiedades de navegación
        public Compra? Compra { get; set; }
        public Producto? Producto { get; set; }
    }

}
