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
            pictureBox3 = new PictureBox();
            btnRegistrar = new Button();
            label1 = new Label();
            txtNusuario = new TextBox();
            label2 = new Label();
            txtContrasena = new TextBox();
            txtConfirmar = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCedula = new TextBox();
            label7 = new Label();
            btnRegresar = new PictureBox();
            ROL = new ComboBox();
            labelRol = new Label();
            txtTelefonoUser = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(162, 255, 211);
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(btnRegistrar);
            panel2.Location = new Point(431, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 477);
            panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(42, 86);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(293, 285);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(14, 150, 143);
            btnRegistrar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(113, 413);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(166, 34);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
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
            txtNusuario.BackColor = Color.FromArgb(236, 255, 249);
            txtNusuario.BorderStyle = BorderStyle.None;
            txtNusuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNusuario.Location = new Point(62, 98);
            txtNusuario.Multiline = true;
            txtNusuario.Name = "txtNusuario";
            txtNusuario.Size = new Size(306, 23);
            txtNusuario.TabIndex = 3;
            txtNusuario.Text = "Nombre de Usuario";
            txtNusuario.TextChanged += txtNusuario_TextChanged;
            txtNusuario.Enter += txtNusuario_Enter;
            txtNusuario.Leave += txtNusuario_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 111);
            label2.Name = "label2";
            label2.Size = new Size(306, 21);
            label2.TabIndex = 4;
            label2.Text = "_____________________________________";
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = Color.FromArgb(236, 255, 249);
            txtContrasena.BorderStyle = BorderStyle.None;
            txtContrasena.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.Location = new Point(62, 257);
            txtContrasena.Multiline = true;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(306, 23);
            txtContrasena.TabIndex = 7;
            txtContrasena.Text = "Contraseña";
            txtContrasena.Enter += txtContrasena_Enter;
            txtContrasena.Leave += txtContrasena_Leave;
            // 
            // txtConfirmar
            // 
            txtConfirmar.BackColor = Color.FromArgb(236, 255, 249);
            txtConfirmar.BorderStyle = BorderStyle.None;
            txtConfirmar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmar.Location = new Point(62, 314);
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
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(62, 215);
            label3.Name = "label3";
            label3.Size = new Size(306, 21);
            label3.TabIndex = 12;
            label3.Text = "_____________________________________";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(62, 323);
            label5.Name = "label5";
            label5.Size = new Size(306, 21);
            label5.TabIndex = 14;
            label5.Text = "_____________________________________";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(62, 165);
            label6.Name = "label6";
            label6.Size = new Size(306, 21);
            label6.TabIndex = 15;
            label6.Text = "_____________________________________";
            // 
            // txtCedula
            // 
            txtCedula.BackColor = Color.FromArgb(236, 255, 249);
            txtCedula.BorderStyle = BorderStyle.None;
            txtCedula.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCedula.Location = new Point(62, 155);
            txtCedula.Multiline = true;
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(306, 23);
            txtCedula.TabIndex = 16;
            txtCedula.Text = "Cedula de Identidad";
            txtCedula.Enter += txtCedula_Enter;
            txtCedula.Leave += txtCedula_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(62, 266);
            label7.Name = "label7";
            label7.Size = new Size(306, 21);
            label7.TabIndex = 18;
            label7.Text = "_____________________________________";
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
            // ROL
            // 
            ROL.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ROL.FormattingEnabled = true;
            ROL.Items.AddRange(new object[] { "Admin", "User" });
            ROL.Location = new Point(105, 373);
            ROL.Name = "ROL";
            ROL.Size = new Size(175, 29);
            ROL.TabIndex = 20;
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRol.Location = new Point(62, 371);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(37, 21);
            labelRol.TabIndex = 21;
            labelRol.Text = "Rol:";
            // 
            // txtTelefonoUser
            // 
            txtTelefonoUser.BackColor = Color.FromArgb(236, 255, 249);
            txtTelefonoUser.BorderStyle = BorderStyle.None;
            txtTelefonoUser.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefonoUser.Location = new Point(62, 204);
            txtTelefonoUser.Multiline = true;
            txtTelefonoUser.Name = "txtTelefonoUser";
            txtTelefonoUser.Size = new Size(306, 23);
            txtTelefonoUser.TabIndex = 22;
            txtTelefonoUser.Text = "Telefono";
            txtTelefonoUser.Enter += txtTelefonoUser_Enter;
            txtTelefonoUser.Leave += txtTelefonoUser_Leave;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(236, 255, 249);
            ClientSize = new Size(809, 472);
            Controls.Add(txtTelefonoUser);
            Controls.Add(labelRol);
            Controls.Add(ROL);
            Controls.Add(btnRegresar);
            Controls.Add(txtConfirmar);
            Controls.Add(txtContrasena);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(txtCedula);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtNusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "Register";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form2_Load;
            panel2.ResumeLayout(false);
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
        private ComboBox ROL;
        private Label labelRol;
        private TextBox txtTelefonoUser;
    }
}