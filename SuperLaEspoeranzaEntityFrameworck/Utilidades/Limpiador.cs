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
            imagen.Image = null;
            nombre.Clear();
            telefono.Clear();
            direccion.Clear();
            tipoMenbresia.SelectedIndex = -1;

        }
            

    }
}
