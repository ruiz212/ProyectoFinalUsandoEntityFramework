using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLaEspoeranzaEntityFrameworck.Models
{
    public class Categorias
    {
        public string IdCategoria { get; set; }
        public string Nombre { get; set; }

        // Propiedad de navegación
        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
       
    }
}

