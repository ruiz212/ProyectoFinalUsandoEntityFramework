namespace SuperLaEspoeranzaEntityFrameworck.Vistas
{
    partial class VerUsuarioForm
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            dgvMostrarUsuarios = new Krypton.Toolkit.KryptonDataGridView();
            ctmsOpsionesUsurios = new ContextMenuStrip(components);
            verUsuarioAdministradorToolStripMenuItem = new ToolStripMenuItem();
            usuToolStripMenuItem = new ToolStripMenuItem();
            verUsuarioActivoToolStripMenuItem = new ToolStripMenuItem();
            verUsuarioInactivoToolStripMenuItem = new ToolStripMenuItem();
            activarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            desactivarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            topMasOpciones = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMostrarUsuarios).BeginInit();
            ctmsOpsionesUsurios.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 89, 152);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 89);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(238, 238, 238);
            label1.Location = new Point(424, 27);
            label1.Name = "label1";
            label1.Size = new Size(136, 31);
            label1.TabIndex = 1;
            label1.Text = "Ver Usurios";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.chart_16046686;
            pictureBox1.Location = new Point(331, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvMostrarUsuarios);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(994, 361);
            panel3.TabIndex = 2;
            // 
            // dgvMostrarUsuarios
            // 
            dgvMostrarUsuarios.ColumnHeadersHeight = 36;
            dgvMostrarUsuarios.ContextMenuStrip = ctmsOpsionesUsurios;
            dgvMostrarUsuarios.Dock = DockStyle.Fill;
            dgvMostrarUsuarios.Location = new Point(0, 0);
            dgvMostrarUsuarios.Name = "dgvMostrarUsuarios";
            dgvMostrarUsuarios.RowHeadersWidth = 51;
            dgvMostrarUsuarios.Size = new Size(994, 361);
            dgvMostrarUsuarios.TabIndex = 0;
            topMasOpciones.SetToolTip(dgvMostrarUsuarios, "Has click derecho para mas opciones");
            dgvMostrarUsuarios.CellContentClick += dgvMostrarUsuarios_CellContentClick;
            // 
            // ctmsOpsionesUsurios
            // 
            ctmsOpsionesUsurios.BackColor = Color.FromArgb(59, 89, 152);
            ctmsOpsionesUsurios.Font = new Font("Segoe UI", 9F);
            ctmsOpsionesUsurios.ImageScalingSize = new Size(20, 20);
            ctmsOpsionesUsurios.Items.AddRange(new ToolStripItem[] { verUsuarioAdministradorToolStripMenuItem, usuToolStripMenuItem, verUsuarioActivoToolStripMenuItem, verUsuarioInactivoToolStripMenuItem, activarUsuarioToolStripMenuItem, desactivarUsuarioToolStripMenuItem });
            ctmsOpsionesUsurios.Name = "ctmsOpsionesUsurios";
            ctmsOpsionesUsurios.Size = new Size(255, 172);
            ctmsOpsionesUsurios.Text = "Opciones";
            // 
            // verUsuarioAdministradorToolStripMenuItem
            // 
            verUsuarioAdministradorToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            verUsuarioAdministradorToolStripMenuItem.Image = Properties.Resources.settings_1903338;
            verUsuarioAdministradorToolStripMenuItem.Name = "verUsuarioAdministradorToolStripMenuItem";
            verUsuarioAdministradorToolStripMenuItem.Size = new Size(254, 28);
            verUsuarioAdministradorToolStripMenuItem.Text = "Usuario Administrador";
            verUsuarioAdministradorToolStripMenuItem.Click += verUsuarioAdministradorToolStripMenuItem_Click;
            // 
            // usuToolStripMenuItem
            // 
            usuToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usuToolStripMenuItem.Image = Properties.Resources.chest_7481822;
            usuToolStripMenuItem.Name = "usuToolStripMenuItem";
            usuToolStripMenuItem.Size = new Size(254, 28);
            usuToolStripMenuItem.Text = "Usuario Cajero";
            usuToolStripMenuItem.Click += usuToolStripMenuItem_Click;
            // 
            // verUsuarioActivoToolStripMenuItem
            // 
            verUsuarioActivoToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            verUsuarioActivoToolStripMenuItem.Image = Properties.Resources.good_review_900455;
            verUsuarioActivoToolStripMenuItem.Name = "verUsuarioActivoToolStripMenuItem";
            verUsuarioActivoToolStripMenuItem.Size = new Size(254, 28);
            verUsuarioActivoToolStripMenuItem.Text = "Ver  Usuario Activo";
            verUsuarioActivoToolStripMenuItem.Click += verUsuarioActivoToolStripMenuItem_Click;
            // 
            // verUsuarioInactivoToolStripMenuItem
            // 
            verUsuarioInactivoToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            verUsuarioInactivoToolStripMenuItem.Image = Properties.Resources.user_16470397;
            verUsuarioInactivoToolStripMenuItem.Name = "verUsuarioInactivoToolStripMenuItem";
            verUsuarioInactivoToolStripMenuItem.Size = new Size(254, 28);
            verUsuarioInactivoToolStripMenuItem.Text = "Ver Usuario Inactivo";
            verUsuarioInactivoToolStripMenuItem.Click += verUsuarioInactivoToolStripMenuItem_Click;
            // 
            // activarUsuarioToolStripMenuItem
            // 
            activarUsuarioToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            activarUsuarioToolStripMenuItem.Image = Properties.Resources.switch_3293669;
            activarUsuarioToolStripMenuItem.Name = "activarUsuarioToolStripMenuItem";
            activarUsuarioToolStripMenuItem.Size = new Size(254, 28);
            activarUsuarioToolStripMenuItem.Text = "Activar Usuario";
            activarUsuarioToolStripMenuItem.Click += activarUsuarioToolStripMenuItem_Click;
            // 
            // desactivarUsuarioToolStripMenuItem
            // 
            desactivarUsuarioToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            desactivarUsuarioToolStripMenuItem.Image = Properties.Resources.pen_4713222;
            desactivarUsuarioToolStripMenuItem.Name = "desactivarUsuarioToolStripMenuItem";
            desactivarUsuarioToolStripMenuItem.Size = new Size(254, 28);
            desactivarUsuarioToolStripMenuItem.Text = "Desactivar Usuario";
            desactivarUsuarioToolStripMenuItem.Click += desactivarUsuarioToolStripMenuItem_Click;
            // 
            // VerUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "VerUsuarioForm";
            Text = "VerUsuarioForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMostrarUsuarios).EndInit();
            ctmsOpsionesUsurios.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Krypton.Toolkit.KryptonDataGridView dgvMostrarUsuarios;
        private Label label1;
        private PictureBox pictureBox1;
        private ContextMenuStrip ctmsOpsionesUsurios;
        private ToolStripMenuItem verUsuarioAdministradorToolStripMenuItem;
        private ToolStripMenuItem usuToolStripMenuItem;
        private ToolStripMenuItem verUsuarioActivoToolStripMenuItem;
        private ToolStripMenuItem verUsuarioInactivoToolStripMenuItem;
        private ToolStripMenuItem activarUsuarioToolStripMenuItem;
        private ToolStripMenuItem desactivarUsuarioToolStripMenuItem;
        private ToolTip topMasOpciones;
    }
}