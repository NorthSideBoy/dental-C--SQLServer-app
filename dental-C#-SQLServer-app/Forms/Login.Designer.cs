namespace dental_C__SQLServer_app
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            btnAcceder = new Button();
            panel2 = new Panel();
            linkLabel3 = new LinkLabel();
            txtpass = new TextBox();
            txtuser = new TextBox();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            btnmostrar = new RadioButton();
            btnRegresar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MediumTurquoise;
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(487, 247);
            label3.Name = "label3";
            label3.Size = new Size(237, 15);
            label3.TabIndex = 2;
            label3.Text = "______________________________________________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumTurquoise;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(487, 172);
            label4.Name = "label4";
            label4.Size = new Size(237, 15);
            label4.TabIndex = 3;
            label4.Text = "______________________________________________";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(456, 445);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumTurquoise;
            label5.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(81, 18);
            label5.Name = "label5";
            label5.Size = new Size(120, 39);
            label5.TabIndex = 6;
            label5.Text = "LOGIN";
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.DarkSlateGray;
            btnAcceder.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = Color.White;
            btnAcceder.Location = new Point(20, 278);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(237, 34);
            btnAcceder.TabIndex = 7;
            btnAcceder.Text = "ACCEDER";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumTurquoise;
            panel2.Controls.Add(linkLabel3);
            panel2.Controls.Add(txtpass);
            panel2.Controls.Add(txtuser);
            panel2.Controls.Add(btnAcceder);
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnmostrar);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(467, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 381);
            panel2.TabIndex = 8;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(69, 334);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(157, 17);
            linkLabel3.TabIndex = 13;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Mostrar Usuarios Creados";
            linkLabel3.TextAlign = ContentAlignment.TopCenter;
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.MediumTurquoise;
            txtpass.BorderStyle = BorderStyle.None;
            txtpass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.ForeColor = Color.FromArgb(0, 0, 64);
            txtpass.Location = new Point(20, 177);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(237, 20);
            txtpass.TabIndex = 12;
            txtpass.Text = "CONTRASEÑA";
            txtpass.Enter += txtpass_Enter;
            txtpass.Leave += txtpass_Leave;
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.MediumTurquoise;
            txtuser.BorderStyle = BorderStyle.None;
            txtuser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.ForeColor = Color.FromArgb(0, 0, 64);
            txtuser.Location = new Point(20, 102);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(237, 20);
            txtuser.TabIndex = 11;
            txtuser.Text = "USUARIO";
            txtuser.Enter += txtuser_Enter;
            txtuser.Leave += txtuser_Leave;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(100, 315);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(87, 17);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Crear Usuario";
            linkLabel2.TextAlign = ContentAlignment.TopCenter;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Century Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(48, 350);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(181, 17);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿Ha olvidado su contraseña?";
            linkLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(112, 225);
            label6.Name = "label6";
            label6.Size = new Size(125, 17);
            label6.TabIndex = 8;
            label6.Text = "Mostrar Contraseña";
            // 
            // btnmostrar
            // 
            btnmostrar.AutoSize = true;
            btnmostrar.Location = new Point(243, 227);
            btnmostrar.Name = "btnmostrar";
            btnmostrar.Size = new Size(14, 13);
            btnmostrar.TabIndex = 7;
            btnmostrar.TabStop = true;
            btnmostrar.UseVisualStyleBackColor = true;
            btnmostrar.CheckedChanged += btnmostrar_CheckedChanged;
            btnmostrar.Click += btnmostrar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(12, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(42, 41);
            btnRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRegresar.TabIndex = 20;
            btnRegresar.TabStop = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresar);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(panel2);
            Name = "Login";
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Button btnAcceder;
        private Panel panel2;
        private RadioButton btnmostrar;
        private Label label6;
        protected LinkLabel linkLabel1;
        protected LinkLabel linkLabel2;
        private TextBox txtuser;
        private TextBox txtpass;
        private PictureBox btncerrar;
        private PictureBox btnexpandir;
        private PictureBox pictureBox4;
        private PictureBox btnminimizar;
        public Panel panel1;
        protected LinkLabel linkLabel3;
        private PictureBox btnRegresar;
    }
}