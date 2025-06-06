using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLaEspoeranzaEntityFrameworck.DOTs
{
    public class ProveedorDOT
    {
        public string IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public bool Estado { get; set; }
    }
}
