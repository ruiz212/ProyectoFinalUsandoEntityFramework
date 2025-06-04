using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperFacturacion.CONTROLADOR
{
    public class Limpiador
    {
        public static void LimpiadorFormMenbresia(PictureBox imagen,TextBox nombre, MaskedTextBox telefono,TextBox direccion,ComboBox tipoMenbresia )
        {

            try
            {
                string rutaImagen = @"C:\Users\miure\source\repos\SuperLaEspoeranzaEntityFrameworck\SuperLaEspoeranzaEntityFrameworck\Resources\profile_11820363.png";
                if (System.IO.File.Exists(rutaImagen))
                {
                    imagen.Image = Image.FromFile(rutaImagen);
                }
                else
                {
                    imagen.Image = null;
                }
            }
            catch
            {
                imagen.Image = null;
            }

            
            nombre.Clear();
            telefono.Clear();
            direccion.Clear();
            tipoMenbresia.SelectedIndex = 0;

        }
            

    }
}
