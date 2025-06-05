using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLaEspoeranzaEntityFrameworck.Models
{
    public class Categoria
    {
        public string IdCategoria { get; set; }
        public string Nombre { get; set; }

        public ICollection<Producto> Productos { get; set; }

    }
}

