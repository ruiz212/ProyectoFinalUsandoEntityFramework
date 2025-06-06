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
    public partial class AgregarUsuarioFromcs : Form
    {
        UsuarioDb usuarioDbq;
        public AgregarUsuarioFromcs()
        {
            InitializeComponent();
            usuarioDbq = new UsuarioDb();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Verificar(txtNombreCompleto, txtNombreUsurio, txtContrasena, txtConfirmarContrasena, cmbTipoDeUsuario))
            {
                string idUsuario = IdGenerator.IdGenerates();
                string nombreCompleto = txtNombreCompleto.Text;
                string nombreDeUsuario = txtNombreUsurio.Text;
                string contrasena = txtContrasena.Text;
                string? tipoDeUsuario = cmbTipoDeUsuario.SelectedItem as string;
                bool estado = true;

                if (string.IsNullOrEmpty(tipoDeUsuario))
                {
                    MessageBox.Show("Seleccione un tipo de usuario válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                await Task.Run(() =>
                {
                    usuarioDbq.AgregarUsuario(new DOTs.UsuarioDOT
                    {
                        IdUsuario = idUsuario,
                        NombreCompleto = nombreCompleto,
                        UsuarioNombre = nombreDeUsuario,
                        Clave = contrasena,
                        Rol = tipoDeUsuario,
                        Estado = estado
                    });
                });
                this.Close();
            }
        }

        private bool Verificar(TextBox txtNombreCompleto, TextBox txtNombreDeUsuario, TextBox txtContrasena, TextBox txtConfirmarContrasena, ComboBox cmbTipoDeUsuario)
        {
            if (string.IsNullOrEmpty(txtNombreCompleto.Text) || string.IsNullOrEmpty(txtNombreUsurio.Text) || string.IsNullOrEmpty(txtContrasena.Text) || string.IsNullOrEmpty(txtConfirmarContrasena.Text) || cmbTipoDeUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtContrasena.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAutoCompletarNombreDeUsuari_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNombreCompleto.Text))
            {
             txtNombreUsurio.Text = Autocompletado.UserGenerator(txtNombreCompleto.Text);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el nombre completo antes de autocompletar el nombre de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
