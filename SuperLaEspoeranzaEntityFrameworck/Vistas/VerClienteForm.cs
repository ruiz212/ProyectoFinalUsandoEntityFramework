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

    public partial class VerClienteForm : Form
    {
        ClienteDb clienteDb;

        public List<ClienteDOT> clientes;
        public VerClienteForm()
        {
            InitializeComponent();
            clienteDb = new ClienteDb();
            clientes = clienteDb.ObtenerClientes();
            cmbFiltro.SelectedIndex = 0;
          
        }


       

        private void dtgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void CargarInfoForm(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dtgvCliente.Rows[e.RowIndex].DataBoundItem is ClienteDOT cliente)
            {
                lblIdCliente.Text = cliente.IdCliente;
                lblNombre.Text = cliente.Nombre;
                lblTelefono.Text = cliente.Telefono;
                lblDireccion.Text = cliente.Direccion;
                lblTipoMenbrsia.Text = cliente.TipoMembresia;
                CargarColorCard(cliente.TipoMembresia);
                lblPuntosPorCompra.Text = cliente.PuntosCompra.ToString();

                // Cargar la imagen de forma asíncrona
                if (cliente.Foto != null)
                {
                    ptbImagenCliente.Image = null;
                    await Task.Run(() =>
                    {
                        using (var ms = new System.IO.MemoryStream(cliente.Foto))
                        {
                            var img = Image.FromStream(ms);
                            ptbImagenCliente.Invoke(new Action(() =>
                            {
                                ptbImagenCliente.Image = img;
                            }));
                        }
                    });
                }
                else
                {
                    ptbImagenCliente.Image = null;
                }
            }
        }

        private void CargarColorCard(string tipoMembresia)
        {
            if (tipoMembresia == "Membresía Clásica")
            {
                panelCardCliente.BackColor = Color.FromArgb(128, 128, 128);
            }
            else if (tipoMembresia == "Membresía Plata")
            {
                panelCardCliente.BackColor = Color.FromArgb(192, 192, 192);
            }
            else if (tipoMembresia == "Membresía Oro")
            {
                panelCardCliente.BackColor = Color.FromArgb(255, 215, 0);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.SelectedItem.ToString() != "Todo")
            {
                dtgvCliente.DataSource = clienteDb.ObtenerClientesPorTipoMenbrecia(cmbFiltro.SelectedItem.ToString());
            }
            else
            {
                dtgvCliente.DataSource = clientes;
            }
        }
    }
}
