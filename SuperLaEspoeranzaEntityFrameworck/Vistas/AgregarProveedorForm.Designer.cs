namespace SuperLaEspoeranzaEntityFrameworck.Vistas
{
    partial class AgregarProveedorForm
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
            button1 = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtNombreProveedor = new TextBox();
            label2 = new Label();
            txtCorreo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtDireccion = new TextBox();
            mktxtTelefono = new MaskedTextBox();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 89, 152);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1059, 116);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(939, 14);
            button1.Name = "button1";
            button1.Size = new Size(106, 91);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(238, 238, 238);
            label5.Location = new Point(518, 41);
            label5.Name = "label5";
            label5.Size = new Size(79, 31);
            label5.TabIndex = 1;
            label5.Text = "label5";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(397, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 91);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.ForeColor = Color.FromArgb(238, 238, 238);
            label1.Location = new Point(100, 212);
            label1.Name = "label1";
            label1.Size = new Size(155, 23);
            label1.TabIndex = 1;
            label1.Text = "Nombre Preveedor";
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(258, 208);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(252, 30);
            txtNombreProveedor.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.ForeColor = Color.FromArgb(238, 238, 238);
            label2.Location = new Point(545, 212);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 1;
            label2.Text = "Telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(258, 292);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(252, 30);
            txtCorreo.TabIndex = 2;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.ForeColor = Color.FromArgb(238, 238, 238);
            label3.Location = new Point(100, 300);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 1;
            label3.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.ForeColor = Color.FromArgb(238, 238, 238);
            label4.Location = new Point(545, 300);
            label4.Name = "label4";
            label4.Size = new Size(81, 23);
            label4.TabIndex = 1;
            label4.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(658, 292);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(237, 30);
            txtDireccion.TabIndex = 2;
            // 
            // mktxtTelefono
            // 
            mktxtTelefono.Location = new Point(658, 212);
            mktxtTelefono.Mask = "(+999)-(9999-9999)";
            mktxtTelefono.Name = "mktxtTelefono";
            mktxtTelefono.Size = new Size(237, 30);
            mktxtTelefono.TabIndex = 3;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AgregarProveedorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1059, 424);
            Controls.Add(mktxtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombreProveedor);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10.2F);
            ForeColor = Color.FromArgb(238, 238, 238);
            Name = "AgregarProveedorForm";
            Text = "AgregarProveedorForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtNombreProveedor;
        private Label label2;
        private TextBox txtCorreo;
        private Label label3;
        private Label label4;
        private TextBox txtDireccion;
        private MaskedTextBox mktxtTelefono;
        private PictureBox pictureBox1;
        private Label label5;
        private Button button1;
        private ErrorProvider errorProvider1;
    }
}