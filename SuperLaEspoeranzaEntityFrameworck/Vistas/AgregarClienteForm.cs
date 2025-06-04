using SuperFacturacion.CONTROLADOR;
using SuperLaEspoeranzaEntityFrameworck.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperLaEspoeranzaEntityFrameworck.Vistas
{
    public partial class AgregarClienteForm : Form
    {
        ClienteDb nuevoCliente = new ClienteDb();
        private Image? imagenSeleccionada = null;

        public AgregarClienteForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccionar imagen";
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagenSeleccionada = Image.FromFile(openFileDialog.FileName);
                pctbImagenCliente.Image = imagenSeleccionada;
            }
        }

        private void cmbTipoMenbrecia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoMenbrecia.SelectedIndex == 0)
            {
                panelCard.BackColor = Color.FromArgb(128, 128, 128);
            }
            else if (cmbTipoMenbrecia.SelectedIndex == 1)
            {
                panelCard.BackColor = Color.FromArgb(192, 192, 192);
            }
            else if (cmbTipoMenbrecia.SelectedIndex == 2)
            {
                panelCard.BackColor = Color.FromArgb(255, 215, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Verificar(txtNombreCliente, txtDireccion, mktxtTelefono, cmbTipoMenbrecia))
            {
                nuevoCliente.AgregarCliente(new DOTs.ClienteDOT
                {
                    IdCliente = IdGenerator.IdGenerates(),
                    Nombre = txtNombreCliente.Text,
                    Telefono = mktxtTelefono.Text,
                    Direccion = txtDireccion.Text,
                    TipoMembresia = cmbTipoMenbrecia.SelectedItem.ToString(),
                    Foto = ImageToByteArray(imagenSeleccionada),
                });
                Limpiador.LimpiadorFormMenbresia(pctbImagenCliente,txtNombreCliente,mktxtTelefono,txtDireccion,cmbTipoMenbrecia);
            }
        }

        private bool Verificar(TextBox txtNombreCliente, TextBox txtDireccion, MaskedTextBox mktxtTelefono, ComboBox cmbTipoMenbrecia)
        {
            if (string.IsNullOrEmpty(txtNombreCliente.Text) ||
                string.IsNullOrEmpty(txtDireccion.Text) ||
                string.IsNullOrEmpty(mktxtTelefono.Text) ||
                cmbTipoMenbrecia.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private byte[]? ImageToByteArray(Image? image)
        {
            if (image == null) return null;
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
