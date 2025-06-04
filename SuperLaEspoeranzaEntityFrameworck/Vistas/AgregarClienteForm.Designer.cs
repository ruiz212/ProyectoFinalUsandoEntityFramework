namespace SuperLaEspoeranzaEntityFrameworck.Vistas
{
    partial class AgregarClienteForm
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
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panelCard = new Panel();
            cmbTipoMenbrecia = new ComboBox();
            mktxtTelefono = new MaskedTextBox();
            txtDireccion = new TextBox();
            txtNombreCliente = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            pctbImagenCliente = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctbImagenCliente).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 89, 152);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 104);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.SteelBlue;
            button1.BackgroundImage = Properties.Resources.card_16277815;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(828, 16);
            button1.Name = "button1";
            button1.Size = new Size(79, 74);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(238, 238, 238);
            label1.Location = new Point(367, 34);
            label1.Name = "label1";
            label1.Size = new Size(218, 31);
            label1.TabIndex = 1;
            label1.Text = "Agregar Menbresía";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.credit_card_9964182;
            pictureBox1.Location = new Point(276, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(panelCard);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(919, 305);
            panel2.TabIndex = 1;
            // 
            // panelCard
            // 
            panelCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCard.Controls.Add(cmbTipoMenbrecia);
            panelCard.Controls.Add(mktxtTelefono);
            panelCard.Controls.Add(txtDireccion);
            panelCard.Controls.Add(txtNombreCliente);
            panelCard.Controls.Add(label5);
            panelCard.Controls.Add(label4);
            panelCard.Controls.Add(label3);
            panelCard.Controls.Add(label2);
            panelCard.Controls.Add(button2);
            panelCard.Controls.Add(pctbImagenCliente);
            panelCard.Location = new Point(125, 26);
            panelCard.Name = "panelCard";
            panelCard.Size = new Size(679, 244);
            panelCard.TabIndex = 0;
            // 
            // cmbTipoMenbrecia
            // 
            cmbTipoMenbrecia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbTipoMenbrecia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoMenbrecia.FormattingEnabled = true;
            cmbTipoMenbrecia.Items.AddRange(new object[] { "Membresía Clásica", "Membresía Plata", "Membresía Oro" });
            cmbTipoMenbrecia.Location = new Point(295, 194);
            cmbTipoMenbrecia.Name = "cmbTipoMenbrecia";
            cmbTipoMenbrecia.Size = new Size(299, 28);
            cmbTipoMenbrecia.TabIndex = 5;
            cmbTipoMenbrecia.SelectedIndexChanged += cmbTipoMenbrecia_SelectedIndexChanged;
            // 
            // mktxtTelefono
            // 
            mktxtTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mktxtTelefono.Location = new Point(295, 83);
            mktxtTelefono.Mask = "(+999)-9999-9999";
            mktxtTelefono.Name = "mktxtTelefono";
            mktxtTelefono.Size = new Size(294, 27);
            mktxtTelefono.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDireccion.Location = new Point(290, 145);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(299, 27);
            txtDireccion.TabIndex = 3;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreCliente.Location = new Point(290, 23);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(299, 27);
            txtNombreCliente.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(141, 197);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 2;
            label5.Text = "Tipo de menbrecia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 145);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 2;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 86);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 30);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // button2
            // 
            button2.Location = new Point(53, 120);
            button2.Name = "button2";
            button2.Size = new Size(107, 31);
            button2.TabIndex = 1;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pctbImagenCliente
            // 
            pctbImagenCliente.Image = Properties.Resources.profile_11820363;
            pctbImagenCliente.Location = new Point(54, 30);
            pctbImagenCliente.Name = "pctbImagenCliente";
            pctbImagenCliente.Size = new Size(106, 84);
            pctbImagenCliente.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbImagenCliente.TabIndex = 0;
            pctbImagenCliente.TabStop = false;
            // 
            // AgregarClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 409);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AgregarClienteForm";
            Text = "AgregarClienteForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctbImagenCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Panel panelCard;
        private PictureBox pctbImagenCliente;
        private Button button2;
        private TextBox txtNombreCliente;
        private Label label2;
        private MaskedTextBox mktxtTelefono;
        private Label label3;
        private TextBox txtDireccion;
        private Label label4;
        private ComboBox cmbTipoMenbrecia;
        private Label label5;
    }
}