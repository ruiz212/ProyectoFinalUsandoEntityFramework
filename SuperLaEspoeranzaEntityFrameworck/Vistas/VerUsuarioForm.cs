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
    public partial class VerUsuarioForm : Form
    {
        UsuarioDb UsuarioDb;
        public VerUsuarioForm()
        {
            InitializeComponent();
            UsuarioDb = new UsuarioDb();
            CargarInfor();

        }

        private void CargarInfor()
        {
            Task.Run(() =>
            {
                var usuarios = UsuarioDb.ObtenerUsuarios();
                Invoke(new Action(() =>
                {
                    dgvMostrarUsuarios.DataSource = null;
                    dgvMostrarUsuarios.DataSource = usuarios;
                }));
            });
        }

        private void dgvMostrarUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvMostrarUsuarios.DataSource = UsuarioDb.ObtenerUsuariosPorRol("Cajero");
        }

        private void verUsuarioAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvMostrarUsuarios.DataSource = UsuarioDb.ObtenerUsuariosPorRol("Administrador");
        }

        private void verUsuarioActivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvMostrarUsuarios.DataSource = UsuarioDb.ObtenerUsuarPorEstado(true);
        }

        private void desactivarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvMostrarUsuarios.CurrentRow != null && dgvMostrarUsuarios.CurrentRow.Index >= 0)
            {
                var result = MessageBox.Show("¿Estás seguro que deseas desactivar la cuenta?", "Instrucciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var cellValue = dgvMostrarUsuarios.CurrentRow.Cells[0].Value;
                    if (cellValue != null)
                    {
                        string idUsuario = cellValue.ToString();
                        UsuarioDb.DesactivarOActivar(false, idUsuario);
                        CargarInfor();
                        return;
                    }
                }
            }
            MessageBox.Show("Selecciona un usuario que quieras desactivar");
        }

        private void verUsuarioInactivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvMostrarUsuarios.DataSource = UsuarioDb.ObtenerUsuarPorEstado(false);
        }

        private void activarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvMostrarUsuarios.CurrentRow != null && dgvMostrarUsuarios.CurrentRow.Index >= 0)
            {
                var result = MessageBox.Show("¿Estás seguro que deseas Activar la cuenta?", "Instrucciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var cellValue = dgvMostrarUsuarios.CurrentRow.Cells[0].Value;
                    if (cellValue != null)
                    {
                        string idUsuario = cellValue.ToString();
                        UsuarioDb.DesactivarOActivar(true, idUsuario);
                        CargarInfor();
                        return;
                    }
                }
            }
            MessageBox.Show("Selecciona un usuario que quieras desactivar");
        }
    }
}
