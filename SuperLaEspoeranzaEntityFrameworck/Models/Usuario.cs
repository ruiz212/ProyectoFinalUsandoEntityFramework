using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLaEspoeranzaEntityFrameworck.Models
{
    public class Usuario
    {
        public string IdUsuario { get; set; }
        public string? NombreCompleto { get; set; }
        public string? UsuarioNombre { get; set; }
        public string? Clave { get; set; }
        public string? Rol { get; set; }
        public bool? Estado { get; set; }

        // Propiedad de navegación
        public ICollection<Factura> Facturas { get; set; } = new List<Factura>();
    }
}
