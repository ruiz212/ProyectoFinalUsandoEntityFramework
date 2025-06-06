namespace SuperLaEspoeranzaEntityFrameworck.Vistas
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            panel1 = new Panel();
            circularProgressBar1 = new Krypton.Toolkit.Suite.Extended.Circular.ProgressBar.CircularProgressBar();
            btnComprobar = new Button();
            btnMotrarContrasena = new Button();
            txtContrasena = new TextBox();
            txtNombreUsuario = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tlpInformacion = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(59, 89, 152);
            panel1.Controls.Add(circularProgressBar1);
            panel1.Controls.Add(btnComprobar);
            panel1.Controls.Add(btnMotrarContrasena);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(txtNombreUsuario);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 267);
            panel1.TabIndex = 0;
            // 
            // circularProgressBar1
            // 
            circularProgressBar1.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            circularProgressBar1.AnimationSpeed = 500;
            circularProgressBar1.BackColor = Color.Transparent;
            circularProgressBar1.FirstValueColour = Color.Red;
            circularProgressBar1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            circularProgressBar1.ForeColor = Color.FromArgb(30, 57, 91);
            circularProgressBar1.InnerColour = Color.FromArgb(132, 157, 189);
            circularProgressBar1.InnerMargin = 2;
            circularProgressBar1.InnerWidth = -1;
            circularProgressBar1.Location = new Point(485, 97);
            circularProgressBar1.MarqueeAnimationSpeed = 2000;
            circularProgressBar1.Name = "circularProgressBar1";
            circularProgressBar1.OuterColour = Color.FromArgb(220, 232, 246);
            circularProgressBar1.OuterMargin = -25;
            circularProgressBar1.OuterWidth = 26;
            circularProgressBar1.ProgressColour = Color.FromArgb(255, 216, 107);
            circularProgressBar1.ProgressWidth = 25;
            circularProgressBar1.SecondaryFont = new Font("Segoe UI", 36F);
            circularProgressBar1.SecondValueColour = Color.FromArgb(255, 191, 0);
            circularProgressBar1.Size = new Size(82, 83);
            circularProgressBar1.StartAngle = 270;
            circularProgressBar1.SubscriptColour = Color.FromArgb(30, 57, 91);
            circularProgressBar1.SubscriptMargin = new Padding(10, -35, 0, 0);
            circularProgressBar1.SubscriptText = "";
            circularProgressBar1.SuperscriptColour = Color.FromArgb(30, 57, 91);
            circularProgressBar1.SuperscriptMargin = new Padding(10, 35, 0, 0);
            circularProgressBar1.SuperscriptText = "";
            circularProgressBar1.TabIndex = 5;
            circularProgressBar1.Text = "Cargando";
            circularProgressBar1.TextMargin = new Padding(8, 8, 0, 0);
            circularProgressBar1.ThirdValueColour = Color.Green;
            circularProgressBar1.Visible = false;
            circularProgressBar1.Click += circularProgressBar1_Click;
            // 
            // btnComprobar
            // 
            btnComprobar.BackColor = Color.SteelBlue;
            btnComprobar.BackgroundImage = Properties.Resources.security_15654567;
            btnComprobar.BackgroundImageLayout = ImageLayout.Stretch;
            btnComprobar.Location = new Point(485, 191);
            btnComprobar.Name = "btnComprobar";
            btnComprobar.Size = new Size(73, 64);
            btnComprobar.TabIndex = 4;
            btnComprobar.UseVisualStyleBackColor = false;
            btnComprobar.Click += btnComprobar_Click;
            // 
            // btnMotrarContrasena
            // 
            btnMotrarContrasena.BackColor = Color.SteelBlue;
            btnMotrarContrasena.BackgroundImage = Properties.Resources.password;
            btnMotrarContrasena.BackgroundImageLayout = ImageLayout.Stretch;
            btnMotrarContrasena.Location = new Point(416, 162);
            btnMotrarContrasena.Name = "btnMotrarContrasena";
            btnMotrarContrasena.Size = new Size(37, 32);
            btnMotrarContrasena.TabIndex = 4;
            tlpInformacion.SetToolTip(btnMotrarContrasena, "Ocultar o Mostrar cotraseña");
            btnMotrarContrasena.UseVisualStyleBackColor = false;
            btnMotrarContrasena.Click += btnMotrarContrasena_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(172, 162);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(238, 27);
            txtContrasena.TabIndex = 3;
            tlpInformacion.SetToolTip(txtContrasena, "Aqui ingresa tu contraseña");
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(172, 107);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(238, 27);
            txtNombreUsuario.TabIndex = 3;
            tlpInformacion.SetToolTip(txtNombreUsuario, "Aqui ingresa tu nombre de Usuario");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(238, 238, 238);
            label3.Location = new Point(20, 157);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(238, 238, 238);
            label2.Location = new Point(11, 107);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 2;
            label2.Text = "Nombre de Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(238, 238, 238);
            label1.Location = new Point(94, 30);
            label1.Name = "label1";
            label1.Size = new Size(359, 31);
            label1.TabIndex = 1;
            label1.Text = "Bienvenidos a Super La Esperaza";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_tienda_96;
            pictureBox1.Location = new Point(24, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 267);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LogInForm";
            Text = "LogInForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnComprobar;
        private Button btnMotrarContrasena;
        private TextBox txtContrasena;
        private TextBox txtNombreUsuario;
        private Label label3;
        private Label label2;
        private ToolTip tlpInformacion;
        private Krypton.Toolkit.Suite.Extended.Circular.ProgressBar.CircularProgressBar circularProgressBar1;
    }
}