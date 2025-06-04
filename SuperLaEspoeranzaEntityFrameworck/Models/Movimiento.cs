using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLaEspoeranzaEntityFrameworck.Models
{
    public class Movimiento
    {
        public string IdMovimiento { get; set; }
        public string? IdProducto { get; set; } // Clave foránea
        public string? TipoMovimiento { get; set; }
        public int? Cantidad { get; set; }
        public DateTime? FechaMovimiento { get; set; }
        public string? Observacion { get; set; }

        // Propiedad de navegación
        public Producto? Producto { get; set; }
    }
}
