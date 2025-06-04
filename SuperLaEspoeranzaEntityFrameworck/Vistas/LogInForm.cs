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
    public partial class LogInForm : Form
    {
        UsuarioDb usuarioDb;
        public LogInForm()
        {
            InitializeComponent();
            usuarioDb = new UsuarioDb();
            txtContrasena.PasswordChar = '●';
        }

        private void btnMotrarContrasena_Click(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = txtContrasena.PasswordChar == '\0' ? '●' : '\0';
        }

        private async void btnComprobar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos(txtNombreUsuario, txtContrasena))
            {
                string nombreUsuario = txtNombreUsuario.Text;
                string contrasena = txtContrasena.Text;

                // Mostrar la barra de progreso
                circularProgressBar1.Visible = true;
                circularProgressBar1.Value = 0;
                circularProgressBar1.Update();

                // Simular carga y autenticación en una tarea asíncrona
                string resultado = await Task.Run(() =>
                {
                    for (int i = 0; i <= 100; i += 20)
                    {
                        Invoke(new Action(() =>
                        {
                            circularProgressBar1.Value = i;
                            circularProgressBar1.Update();
                        }));
                        Thread.Sleep(100); // Simula tiempo de espera

                    }
                    return usuarioDb.VerificarUsuario(nombreUsuario, contrasena);
                });

                // Ocultar la barra de progreso
                circularProgressBar1.Visible = false;

                if (!string.IsNullOrEmpty(resultado))
                {
                   
                    MenuPrinsipalForm menuPrinsipalForm = new MenuPrinsipalForm(resultado);
                    menuPrinsipalForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool VerificarCampos(TextBox txtNombreUsuario, TextBox txtContrasena)
        {
            if (string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrEmpty(txtContrasena.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
               
               
                return true;
            }
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
