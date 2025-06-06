using SuperFacturacion.CONTROLADOR;
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
    public partial class MenuPrinsipalForm : Form
    {
        public string UsuarioRol;
        public MenuPrinsipalForm(string UsuarioRol)
        {
            InitializeComponent();
            this.UsuarioRol = UsuarioRol;
            Saludar();
            ConfiguracionesPorRol(UsuarioRol);
        }

        private void ConfiguracionesPorRol(string usuarioRol)
        {
            if (usuarioRol == "Administrador")
            {
                // Configuraciones específicas para el administrador

            }
            else if (usuarioRol == "Vendedor")
            {
                // Configuraciones específicas para el vendedor

            }

        }

        private void Saludar()
        {
            lblSaludo.Text = SaludoForm.saludo(UsuarioRol, pctbImagenSaludo);
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            AgregarUsuarioFromcs agregarUsuarioFromcs = new AgregarUsuarioFromcs();
            agregarUsuarioFromcs.TopLevel = false;
            agregarUsuarioFromcs.FormBorderStyle = FormBorderStyle.None;
            agregarUsuarioFromcs.Dock = DockStyle.Fill;
            panelDisplay.Controls.Add(agregarUsuarioFromcs);
            agregarUsuarioFromcs.Show();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            AgregarClienteForm agregarClienteForm = new AgregarClienteForm();
            agregarClienteForm.TopLevel = false;
            agregarClienteForm.FormBorderStyle = FormBorderStyle.None;
            agregarClienteForm.FormBorderStyle = FormBorderStyle.None;
            agregarClienteForm.Dock = DockStyle.Fill;
            panelDisplay.Controls.Add(agregarClienteForm);
            agregarClienteForm.Show();
        }

        private void mostrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            VerUsuarioForm mostrarUsuarioForm = new VerUsuarioForm();
            mostrarUsuarioForm.TopLevel = false;
            mostrarUsuarioForm.FormBorderStyle = FormBorderStyle.None;
            mostrarUsuarioForm.Dock = DockStyle.Fill;
            panelDisplay.Controls.Add(mostrarUsuarioForm);
            mostrarUsuarioForm.Show();

        }

        private void mostrarMenbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            VerClienteForm mostrarClienteForm = new VerClienteForm();
            mostrarClienteForm.TopLevel = false;
            mostrarClienteForm.FormBorderStyle = FormBorderStyle.None;
            mostrarClienteForm.Dock = DockStyle.Fill;
            panelDisplay.Controls.Add(mostrarClienteForm);
            mostrarClienteForm.Show();
        }

      

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDisplay.Controls.Clear();
            AgregarProductoForm agregarProductoForm = new AgregarProductoForm();
            agregarProductoForm.TopLevel = false;
            agregarProductoForm.FormBorderStyle = FormBorderStyle.None;
            agregarProductoForm.Dock = DockStyle.Fill;
            panelDisplay.Controls.Add(agregarProductoForm);
            agregarProductoForm.Show();
        }
    }
}
