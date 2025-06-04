using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLaEspoeranzaEntityFrameworck.Models
{
    public class Compra
    {
        public string IdCompra { get; set; }
        public DateTime? FechaCompra { get; set; }
        public decimal? Total { get; set; }
        public string? IdProveedor { get; set; } // Clave foránea

        // Propiedad de navegación
        public Proveedor? Proveedor { get; set; }
        public ICollection<DetalleCompra> DetalleCompras { get; set; } = new List<DetalleCompra>();
    }
}
