using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLaEspoeranzaEntityFrameworck.Models
{
    public class Proveedor
    {
        public string IdProveedor { get; set; }
        public string? Nombre { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
        public bool? Estado { get; set; }

        // Propiedades de navegación
        public ICollection<Compra> Compras { get; set; } = new List<Compra>();
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}
