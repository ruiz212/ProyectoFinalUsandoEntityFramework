using SuperFacturacion.CONTROLADOR;
using SuperLaEspoeranzaEntityFrameworck.Controlador;
using SuperLaEspoeranzaEntityFrameworck.DOTs;
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
    public partial class AgregarProveedorForm : Form
    {
        public ProveedorDb ProveedorDb;
        AgregarProductoForm agregarProductoForm;

        public AgregarProveedorForm(AgregarProductoForm agregarProductoForm)
        {
            InitializeComponent();
            this.agregarProductoForm = agregarProductoForm;
            ProveedorDb = new ProveedorDb();
        }

        private bool ValidarCorreo(string correo)
        {
            var emailAttribute = new System.ComponentModel.DataAnnotations.EmailAddressAttribute();
            return string.IsNullOrWhiteSpace(correo) || emailAttribute.IsValid(correo);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            var email = txtCorreo.Text;
            if (!ValidarCorreo(email))
            {
                errorProvider1.SetError(txtCorreo, "Correo electrónico no válido.");
            }
            else
            {
                errorProvider1.SetError(txtCorreo, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var email = txtCorreo.Text;
            if (!ValidarCorreo(email))
            {
                errorProvider1.SetError(txtCorreo, "Correo electrónico no válido.");
                MessageBox.Show("Por favor, ingrese un correo electrónico válido antes de agregar el proveedor.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                errorProvider1.SetError(txtCorreo, "");
            }

            ProveedorDb.AgregarPreveedor(new ProveedorDOT
            {
                IdProveedor = IdGenerator.IdGenerates(),
                Nombre = txtNombreProveedor.Text,
                Telefono = mktxtTelefono.Text,
                Correo = txtCorreo.Text,
                Direccion = txtDireccion.Text,
                Estado = true
            });
            agregarProductoForm.ConfigurarDeInicio();
        }
    }
}
