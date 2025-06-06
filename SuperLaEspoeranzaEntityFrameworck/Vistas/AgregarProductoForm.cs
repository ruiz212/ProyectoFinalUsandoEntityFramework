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
    public partial class AgregarProductoForm : Form
    {
        CategoriaDb categoriaDb;
        ProveedorDb proveedorDb;
        public AgregarProductoForm()
        {
            InitializeComponent();
            categoriaDb = new CategoriaDb();
            proveedorDb = new ProveedorDb();

        }

        private void ConfigurarInicio(object sender, EventArgs e)
        {
            ConfigurarDeInicio();
        }

        public void ConfigurarDeInicio()
        {
            var categorias = categoriaDb.ObtenerCategorias();

            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "IdCategoria";
            var proveedores = proveedorDb.ObtenerProveedores();
            cmbAgregarProveedor.DataSource = proveedores;
            cmbAgregarProveedor.DisplayMember = "Nombre";
            cmbAgregarProveedor.ValueMember = "IdProveedor";
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            AgregarCategoraForm agregarCategoraForm = new AgregarCategoraForm(this);
            agregarCategoraForm.Show();
        }

        private void Click_AregarProveedor(object sender, EventArgs e)
        {
            Form agregarProveedorForm = new AgregarProveedorForm(this);
            agregarProveedorForm.Show();
        }
    }
}
