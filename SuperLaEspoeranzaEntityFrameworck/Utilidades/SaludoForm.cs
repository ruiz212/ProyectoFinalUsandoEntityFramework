using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using SuperLaEspoeranzaEntityFrameworck.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFacturacion.CONTROLADOR
{
    public class SaludoForm
    {
        public static string saludo(string UsuarioRol, PictureBox foto)
        {
            string saludoTexto;
            string rutaImagen;

            if (DateTime.Now.Hour < 12)
            {
                saludoTexto = "Buenos días " + UsuarioRol;
                rutaImagen = @"C:\Users\miure\source\repos\SuperLaEspoeranzaEntityFrameworck\SuperLaEspoeranzaEntityFrameworck\Resources\sun_7634185.png";
            }
            else if (DateTime.Now.Hour < 18)
            {
                saludoTexto = "Buenas tardes " + UsuarioRol;
                rutaImagen = @"C:\Users\miure\source\repos\SuperLaEspoeranzaEntityFrameworck\SuperLaEspoeranzaEntityFrameworck\Resources\sun_7634185.png";
            }
            else
            {
                saludoTexto = "Buenas noches " + UsuarioRol;
                rutaImagen = @"C:\Users\miure\source\repos\SuperLaEspoeranzaEntityFrameworck\SuperLaEspoeranzaEntityFrameworck\Resources\moon_8051161.png";
            }

            try
            {
                if (System.IO.File.Exists(rutaImagen))
                {
                    foto.Image = Image.FromFile(rutaImagen);
                }
                else
                {
                    foto.Image = null;
                }
            }
            catch
            {
                foto.Image = null;
            }

            return saludoTexto;
        }
    }
}
