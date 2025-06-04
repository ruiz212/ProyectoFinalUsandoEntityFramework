namespace SuperLaEspoeranzaEntityFrameworck.Vistas
{
    partial class AgregarUsuarioFromcs
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
            panel1 = new Panel();
            btnAgregar = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnAutoCompletarNombreDeUsuari = new Button();
            cmbTipoDeUsuario = new ComboBox();
            txtNombreUsurio = new TextBox();
            lblNombreUsuari = new Label();
            txtConfirmarContrasena = new TextBox();
            label4 = new Label();
            txtContrasena = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtNombreCompleto = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 89, 152);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 104);
            panel1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SteelBlue;
            btnAgregar.BackgroundImage = Properties.Resources.add_friend_9055014;
            btnAgregar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(709, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(79, 74);
            btnAgregar.TabIndex = 2;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(238, 238, 238);
            label1.Location = new Point(351, 30);
            label1.Name = "label1";
            label1.Size = new Size(189, 31);
            label1.TabIndex = 1;
            label1.Text = "Agregar Usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_10976048;
            pictureBox1.Location = new Point(266, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAutoCompletarNombreDeUsuari);
            panel2.Controls.Add(cmbTipoDeUsuario);
            panel2.Controls.Add(txtNombreUsurio);
            panel2.Controls.Add(lblNombreUsuari);
            panel2.Controls.Add(txtConfirmarContrasena);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtContrasena);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtNombreCompleto);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 230);
            panel2.TabIndex = 1;
            // 
            // btnAutoCompletarNombreDeUsuari
            // 
            btnAutoCompletarNombreDeUsuari.BackgroundImage = Properties.Resources.appearance_9917494;
            btnAutoCompletarNombreDeUsuari.BackgroundImageLayout = ImageLayout.Stretch;
            btnAutoCompletarNombreDeUsuari.Location = new Point(745, 28);
            btnAutoCompletarNombreDeUsuari.Name = "btnAutoCompletarNombreDeUsuari";
            btnAutoCompletarNombreDeUsuari.Size = new Size(43, 35);
            btnAutoCompletarNombreDeUsuari.TabIndex = 3;
            btnAutoCompletarNombreDeUsuari.UseVisualStyleBackColor = true;
            // 
            // cmbTipoDeUsuario
            // 
            cmbTipoDeUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoDeUsuario.FormattingEnabled = true;
            cmbTipoDeUsuario.Items.AddRange(new object[] { "Administrador", "Cajero" });
            cmbTipoDeUsuario.Location = new Point(165, 156);
            cmbTipoDeUsuario.Name = "cmbTipoDeUsuario";
            cmbTipoDeUsuario.Size = new Size(174, 28);
            cmbTipoDeUsuario.TabIndex = 2;
            // 
            // txtNombreUsurio
            // 
            txtNombreUsurio.Location = new Point(520, 28);
            txtNombreUsurio.Name = "txtNombreUsurio";
            txtNombreUsurio.Size = new Size(209, 27);
            txtNombreUsurio.TabIndex = 1;
            // 
            // lblNombreUsuari
            // 
            lblNombreUsuari.AutoSize = true;
            lblNombreUsuari.Location = new Point(349, 30);
            lblNombreUsuari.Name = "lblNombreUsuari";
            lblNombreUsuari.Size = new Size(139, 20);
            lblNombreUsuari.TabIndex = 0;
            lblNombreUsuari.Text = "Nombre de Usuario";
            // 
            // txtConfirmarContrasena
            // 
            txtConfirmarContrasena.Location = new Point(520, 102);
            txtConfirmarContrasena.Name = "txtConfirmarContrasena";
            txtConfirmarContrasena.Size = new Size(209, 27);
            txtConfirmarContrasena.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(349, 105);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 0;
            label4.Text = "Confirmar Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(165, 98);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(174, 27);
            txtContrasena.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 164);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 0;
            label5.Text = "Tipo de Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 102);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 0;
            label3.Text = "Contraseña";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(165, 24);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(174, 27);
            txtNombreCompleto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 28);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre completo";
            // 
            // AgregarUsuarioFromcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 334);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AgregarUsuarioFromcs";
            Text = "AgregarUsuarioFromcs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox txtNombreUsurio;
        private Label lblNombreUsuari;
        private TextBox txtNombreCompleto;
        private Label label2;
        private Button btnAgregar;
        private ComboBox cmbTipoDeUsuario;
        private TextBox txtConfirmarContrasena;
        private Label label4;
        private TextBox txtContrasena;
        private Label label5;
        private Label label3;
        private Button btnAutoCompletarNombreDeUsuari;
    }
}