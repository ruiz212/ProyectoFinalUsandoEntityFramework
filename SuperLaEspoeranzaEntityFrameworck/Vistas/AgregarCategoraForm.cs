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
    public partial class AgregarCategoraForm : Form
    {
        CategoriaDb categoriaDb = new CategoriaDb();
        AgregarProductoForm AgregarProductoForm;

        public AgregarCategoraForm(AgregarProductoForm agregarProductoForm)
        {
            InitializeComponent();
            AgregarProductoForm = agregarProductoForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNombreCategora.Text))
            {
               
                var categoriaDOT = new DOTs.CategoraDOT
                {
                    IdCategoria = IdGenerator.IdGenerates(),
                    Nombre = txtNombreCategora.Text
                };
                categoriaDb.AgregarCategoria(categoriaDOT);
                MessageBox.Show("Categoría agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AgregarProductoForm.ConfigurarDeInicio();
                txtNombreCategora.Clear();
            }
        }
    }
}
