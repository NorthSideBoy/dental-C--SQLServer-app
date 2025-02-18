namespace dental_C__SQLServer_app
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel2 = new Panel();
            txtContrasena = new TextBox();
            label7 = new Label();
            btnLogin = new Button();
            pictureBox3 = new PictureBox();
            btnRegistrar = new Button();
            label1 = new Label();
            txtNusuario = new TextBox();
            label2 = new Label();
            txtConfirmar = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCedula = new TextBox();
            btnRegresar = new PictureBox();
            comboxRol = new ComboBox();
            labelRol = new Label();
            comboxTlf = new ComboBox();
            label4 = new Label();
            txtCorreo = new TextBox();
            btnSiguiente = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 93, 215);
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(comboxRol);
            panel2.Controls.Add(txtConfirmar);
            panel2.Controls.Add(txtCorreo);
            panel2.Controls.Add(txtContrasena);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtNusuario);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(comboxTlf);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtCedula);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(30, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(383, 401);
            panel2.TabIndex = 1;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = Color.FromArgb(14, 93, 215);
            txtContrasena.BorderStyle = BorderStyle.None;
            txtContrasena.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.ForeColor = Color.White;
            txtContrasena.Location = new Point(40, 236);
            txtContrasena.Multiline = true;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(306, 23);
            txtContrasena.TabIndex = 7;
            txtContrasena.Text = "Contraseña";
            txtContrasena.Enter += txtContrasena_Enter;
            txtContrasena.Leave += txtContrasena_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(14, 93, 215);
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(40, 248);
            label7.Name = "label7";
            label7.Size = new Size(306, 21);
            label7.TabIndex = 18;
            label7.Text = "_____________________________________";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(14, 93, 215);
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(662, 16);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(102, 32);
            btnLogin.TabIndex = 25;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(419, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(395, 381);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(14, 93, 215);
            btnRegistrar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(646, 429);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(154, 34);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(134, 9);
            label1.Name = "label1";
            label1.Size = new Size(168, 36);
            label1.TabIndex = 2;
            label1.Text = "Registrarse";
            // 
            // txtNusuario
            // 
            txtNusuario.BackColor = Color.FromArgb(14, 93, 215);
            txtNusuario.BorderStyle = BorderStyle.None;
            txtNusuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNusuario.ForeColor = Color.White;
            txtNusuario.Location = new Point(40, 25);
            txtNusuario.Multiline = true;
            txtNusuario.Name = "txtNusuario";
            txtNusuario.Size = new Size(306, 23);
            txtNusuario.TabIndex = 3;
            txtNusuario.Text = "Nombre de Usuario";
            txtNusuario.Enter += txtNusuario_Enter;
            txtNusuario.Leave += txtNusuario_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(14, 93, 215);
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 37);
            label2.Name = "label2";
            label2.Size = new Size(306, 21);
            label2.TabIndex = 4;
            label2.Text = "_____________________________________";
            // 
            // txtConfirmar
            // 
            txtConfirmar.BackColor = Color.FromArgb(14, 93, 215);
            txtConfirmar.BorderStyle = BorderStyle.None;
            txtConfirmar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmar.ForeColor = Color.White;
            txtConfirmar.Location = new Point(40, 288);
            txtConfirmar.Multiline = true;
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(306, 23);
            txtConfirmar.TabIndex = 9;
            txtConfirmar.Text = "Confirmar Contraseña";
            txtConfirmar.Enter += txtConfirmar_Enter;
            txtConfirmar.Leave += txtConfirmar_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(14, 93, 215);
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 145);
            label3.Name = "label3";
            label3.Size = new Size(306, 21);
            label3.TabIndex = 12;
            label3.Text = "_____________________________________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(14, 93, 215);
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(40, 301);
            label5.Name = "label5";
            label5.Size = new Size(306, 21);
            label5.TabIndex = 14;
            label5.Text = "_____________________________________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(14, 93, 215);
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(40, 93);
            label6.Name = "label6";
            label6.Size = new Size(306, 21);
            label6.TabIndex = 15;
            label6.Text = "_____________________________________";
            // 
            // txtCedula
            // 
            txtCedula.BackColor = Color.FromArgb(14, 93, 215);
            txtCedula.BorderStyle = BorderStyle.None;
            txtCedula.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCedula.ForeColor = Color.White;
            txtCedula.Location = new Point(40, 79);
            txtCedula.Multiline = true;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(306, 23);
            txtCedula.TabIndex = 16;
            txtCedula.Text = "Cedula de Identidad";
            txtCedula.Enter += txtCedula_Enter;
            txtCedula.Leave += txtCedula_Leave;
            // 
            // btnRegresar
            // 
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(4, 0);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(42, 41);
            btnRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRegresar.TabIndex = 19;
            btnRegresar.TabStop = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // comboxRol
            // 
            comboxRol.BackColor = Color.White;
            comboxRol.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboxRol.FormattingEnabled = true;
            comboxRol.Items.AddRange(new object[] { "Admin", "User" });
            comboxRol.Location = new Point(88, 355);
            comboxRol.Name = "comboxRol";
            comboxRol.Size = new Size(175, 29);
            comboxRol.TabIndex = 20;
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.BackColor = Color.FromArgb(14, 93, 215);
            labelRol.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRol.ForeColor = Color.White;
            labelRol.Location = new Point(67, 405);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(37, 21);
            labelRol.TabIndex = 21;
            labelRol.Text = "Rol:";
            // 
            // comboxTlf
            // 
            comboxTlf.BackColor = Color.White;
            comboxTlf.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboxTlf.FormattingEnabled = true;
            comboxTlf.Items.AddRange(new object[] { "0424", "0414", "0412", "0416" });
            comboxTlf.Location = new Point(122, 182);
            comboxTlf.Name = "comboxTlf";
            comboxTlf.Size = new Size(217, 29);
            comboxTlf.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(14, 93, 215);
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(40, 185);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 24;
            label4.Text = "Telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(14, 93, 215);
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.ForeColor = Color.White;
            txtCorreo.Location = new Point(40, 133);
            txtCorreo.Multiline = true;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(306, 23);
            txtCorreo.TabIndex = 26;
            txtCorreo.Text = "Correo";
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.FromArgb(14, 93, 215);
            btnSiguiente.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(436, 429);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(192, 34);
            btnSiguiente.TabIndex = 26;
            btnSiguiente.Text = "Siguientes Preguntas";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(812, 475);
            Controls.Add(btnSiguiente);
            Controls.Add(labelRol);
            Controls.Add(btnRegistrar);
            Controls.Add(btnLogin);
            Controls.Add(btnRegresar);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Name = "Register";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private TextBox txtNusuario;
        private Label label2;
        private TextBox txtContrasena;
        private PictureBox pictureBox3;
        private TextBox txtConfirmar;
        private Button btnRegistrar;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtCedula;
        private Label label7;
        private PictureBox btnRegresar;
        private ComboBox comboxRol;
        private Label labelRol;
        private TextBox txtTelefonoUser;
        private ComboBox comboxTlf;
        private Label label4;
        private Button btnLogin;
        private Label label8;
        private TextBox txtCorreo;
        private Button btnSiguiente;
    }
}