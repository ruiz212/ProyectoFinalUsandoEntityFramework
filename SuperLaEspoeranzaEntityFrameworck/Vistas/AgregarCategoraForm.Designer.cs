namespace SuperLaEspoeranzaEntityFrameworck.Vistas
{
    partial class AgregarCategoraForm
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
            label1 = new Label();
            txtNombreCategora = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 89, 152);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 79);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 99);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre de Categoria";
            // 
            // txtNombreCategora
            // 
            txtNombreCategora.Location = new Point(225, 96);
            txtNombreCategora.Name = "txtNombreCategora";
            txtNombreCategora.Size = new Size(261, 27);
            txtNombreCategora.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(199, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 49);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(238, 238, 238);
            label2.Location = new Point(281, 21);
            label2.Name = "label2";
            label2.Size = new Size(209, 31);
            label2.TabIndex = 1;
            label2.Text = "Agregar Categoria";
            // 
            // button1
            // 
            button1.Location = new Point(598, 12);
            button1.Name = "button1";
            button1.Size = new Size(79, 49);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AgregarCategoraForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(689, 146);
            Controls.Add(txtNombreCategora);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "AgregarCategoraForm";
            Text = "AgregarCategoraForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtNombreCategora;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button1;
    }
}