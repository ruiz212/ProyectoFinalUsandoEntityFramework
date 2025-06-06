namespace SuperLaEspoeranzaEntityFrameworck.Vistas
{
    partial class VerClienteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            cmbFiltro = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panelCardCliente = new Panel();
            lblPuntosPorCompra = new Label();
            lblTipoMenbrsia = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblNombre = new Label();
            lblIdCliente = new Label();
            ptbImagenCliente = new PictureBox();
            dtgvCliente = new Krypton.Toolkit.KryptonDataGridView();
            ctmsOpciones = new ContextMenuStrip(components);
            membresíaClásicaToolStripMenuItem = new ToolStripMenuItem();
            membresíaPlataToolStripMenuItem = new ToolStripMenuItem();
            membresíaOroToolStripMenuItem = new ToolStripMenuItem();
            buscarPorIdToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panelCardCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbImagenCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCliente).BeginInit();
            ctmsOpciones.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 89, 152);
            panel1.Controls.Add(cmbFiltro);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(949, 92);
            panel1.TabIndex = 0;
            // 
            // cmbFiltro
            // 
            cmbFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltro.FormattingEnabled = true;
            cmbFiltro.Items.AddRange(new object[] { "Todo", "Membresía Clásica", "Membresía Plata", "Membresía Oro" });
            cmbFiltro.Location = new Point(750, 46);
            cmbFiltro.Name = "cmbFiltro";
            cmbFiltro.Size = new Size(187, 28);
            cmbFiltro.TabIndex = 2;
            cmbFiltro.SelectedIndexChanged += cmbFiltro_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(238, 238, 238);
            label1.Location = new Point(410, 28);
            label1.Name = "label1";
            label1.Size = new Size(166, 31);
            label1.TabIndex = 1;
            label1.Text = "Ver menbresia";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.credit_card_9964182;
            pictureBox1.Location = new Point(335, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dtgvCliente);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(949, 358);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(59, 89, 152);
            panel3.Controls.Add(panelCardCliente);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(557, 358);
            panel3.TabIndex = 3;
            // 
            // panelCardCliente
            // 
            panelCardCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCardCliente.BackColor = Color.SteelBlue;
            panelCardCliente.Controls.Add(lblPuntosPorCompra);
            panelCardCliente.Controls.Add(lblTipoMenbrsia);
            panelCardCliente.Controls.Add(lblDireccion);
            panelCardCliente.Controls.Add(lblTelefono);
            panelCardCliente.Controls.Add(lblNombre);
            panelCardCliente.Controls.Add(lblIdCliente);
            panelCardCliente.Controls.Add(ptbImagenCliente);
            panelCardCliente.Location = new Point(37, 65);
            panelCardCliente.Name = "panelCardCliente";
            panelCardCliente.Size = new Size(487, 230);
            panelCardCliente.TabIndex = 0;
            panelCardCliente.Paint += panel4_Paint;
            // 
            // lblPuntosPorCompra
            // 
            lblPuntosPorCompra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPuntosPorCompra.AutoSize = true;
            lblPuntosPorCompra.BackColor = Color.Transparent;
            lblPuntosPorCompra.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblPuntosPorCompra.ForeColor = Color.FromArgb(238, 238, 238);
            lblPuntosPorCompra.Location = new Point(174, 191);
            lblPuntosPorCompra.Name = "lblPuntosPorCompra";
            lblPuntosPorCompra.Size = new Size(164, 23);
            lblPuntosPorCompra.TabIndex = 1;
            lblPuntosPorCompra.Text = "Puntos Por Compra";
            // 
            // lblTipoMenbrsia
            // 
            lblTipoMenbrsia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTipoMenbrsia.AutoSize = true;
            lblTipoMenbrsia.BackColor = Color.Transparent;
            lblTipoMenbrsia.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTipoMenbrsia.ForeColor = Color.FromArgb(238, 238, 238);
            lblTipoMenbrsia.Location = new Point(174, 155);
            lblTipoMenbrsia.Name = "lblTipoMenbrsia";
            lblTipoMenbrsia.Size = new Size(159, 23);
            lblTipoMenbrsia.TabIndex = 1;
            lblTipoMenbrsia.Text = "Tipo de Menbresia";
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblDireccion.ForeColor = Color.FromArgb(238, 238, 238);
            lblDireccion.Location = new Point(174, 115);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(85, 23);
            lblDireccion.TabIndex = 1;
            lblDireccion.Text = "Direccion";
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.FromArgb(238, 238, 238);
            lblTelefono.Location = new Point(174, 73);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(78, 23);
            lblTelefono.TabIndex = 1;
            lblTelefono.Text = "Telefono";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(238, 238, 238);
            lblNombre.Location = new Point(174, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 23);
            lblNombre.TabIndex = 1;
            lblNombre.Text = " Nombre";
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.BackColor = Color.Transparent;
            lblIdCliente.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblIdCliente.ForeColor = Color.FromArgb(238, 238, 238);
            lblIdCliente.Location = new Point(17, 115);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(117, 23);
            lblIdCliente.TabIndex = 1;
            lblIdCliente.Text = "ID Menbrecia";
            // 
            // ptbImagenCliente
            // 
            ptbImagenCliente.Location = new Point(12, 12);
            ptbImagenCliente.Name = "ptbImagenCliente";
            ptbImagenCliente.Size = new Size(110, 90);
            ptbImagenCliente.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbImagenCliente.TabIndex = 0;
            ptbImagenCliente.TabStop = false;
            // 
            // dtgvCliente
            // 
            dtgvCliente.ColumnHeadersHeight = 36;
            dtgvCliente.Dock = DockStyle.Right;
            dtgvCliente.Location = new Point(557, 0);
            dtgvCliente.Name = "dtgvCliente";
            dtgvCliente.RowHeadersWidth = 51;
            dtgvCliente.Size = new Size(392, 358);
            dtgvCliente.TabIndex = 2;
            dtgvCliente.CellClick += CargarInfoForm;
            // 
            // ctmsOpciones
            // 
            ctmsOpciones.Font = new Font("Segoe UI", 9F);
            ctmsOpciones.ImageScalingSize = new Size(20, 20);
            ctmsOpciones.Items.AddRange(new ToolStripItem[] { membresíaClásicaToolStripMenuItem, membresíaPlataToolStripMenuItem, membresíaOroToolStripMenuItem, buscarPorIdToolStripMenuItem });
            ctmsOpciones.Name = "ctmsOpciones";
            ctmsOpciones.Size = new Size(221, 116);
            // 
            // membresíaClásicaToolStripMenuItem
            // 
            membresíaClásicaToolStripMenuItem.Font = new Font("Segoe UI", 10.2F);
            membresíaClásicaToolStripMenuItem.Name = "membresíaClásicaToolStripMenuItem";
            membresíaClásicaToolStripMenuItem.Size = new Size(220, 28);
            membresíaClásicaToolStripMenuItem.Text = "Membresía Clásica";
            // 
            // membresíaPlataToolStripMenuItem
            // 
            membresíaPlataToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            membresíaPlataToolStripMenuItem.Name = "membresíaPlataToolStripMenuItem";
            membresíaPlataToolStripMenuItem.Size = new Size(220, 28);
            membresíaPlataToolStripMenuItem.Text = "Membresía Plata";
            // 
            // membresíaOroToolStripMenuItem
            // 
            membresíaOroToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            membresíaOroToolStripMenuItem.Name = "membresíaOroToolStripMenuItem";
            membresíaOroToolStripMenuItem.Size = new Size(220, 28);
            membresíaOroToolStripMenuItem.Text = "Membresía Oro";
            // 
            // buscarPorIdToolStripMenuItem
            // 
            buscarPorIdToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buscarPorIdToolStripMenuItem.Name = "buscarPorIdToolStripMenuItem";
            buscarPorIdToolStripMenuItem.Size = new Size(220, 28);
            buscarPorIdToolStripMenuItem.Text = "Buscar Por Id";
            // 
            // VerClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "VerClienteForm";
            Text = "VerClienteForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panelCardCliente.ResumeLayout(false);
            panelCardCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbImagenCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvCliente).EndInit();
            ctmsOpciones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panelCard;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label lblNombre;
        private PictureBox pctbImganCliente;
        private Label lblTipoMenbrecia;
        private Krypton.Toolkit.KryptonDataGridView dtgvCliente;
        private Label lblIdMenbrecia;
        private Label lblPuntos;
        private Panel panel3;
        private Panel panelCardCliente;
        private Label lblPuntosPorCompra;
        private Label lblTipoMenbrsia;
        private Label lblIdCliente;
        private PictureBox ptbImagenCliente;
        private ContextMenuStrip ctmsOpciones;
        private ToolStripMenuItem membresíaClásicaToolStripMenuItem;
        private ToolStripMenuItem membresíaPlataToolStripMenuItem;
        private ToolStripMenuItem membresíaOroToolStripMenuItem;
        private ToolStripMenuItem buscarPorIdToolStripMenuItem;
        private ComboBox cmbFiltro;
    }
}