using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLaEspoeranzaEntityFrameworck.Models
{
    public class Producto
    {
        public string IdProducto { get; set; }
        public string? Nombre { get; set; }
        public decimal? PrecioCompra { get; set; }
        public decimal? PrecioVenta { get; set; }
        public int? Stock { get; set; }
        public int? StockMinimo { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public bool? Estado { get; set; }
        public string? IdProveedor { get; set; } // Clave foránea
        public string? IdCategoria { get; set; } // Clave foránea
   
        // Propiedades de navegación
        public Proveedor? Proveedor { get; set; }
        public Categorias? Categoria { get; set; }
        public ICollection<DetalleCompra> DetalleCompras { get; set; } = new List<DetalleCompra>();
        public ICollection<DetalleFactura> DetalleFacturas { get; set; } = new List<DetalleFactura>();
        public ICollection<Movimiento> Movimientos { get; set; } = new List<Movimiento>();
    }
}
