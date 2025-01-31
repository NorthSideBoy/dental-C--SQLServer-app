namespace dental_C__SQLServer_app
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            btnMinimizar = new PictureBox();
            btnCerrar = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            txtNusuario = new TextBox();
            label2 = new Label();
            txtCorreo = new TextBox();
            label3 = new Label();
            txtContrasena = new TextBox();
            label4 = new Label();
            txtConfirmar = new TextBox();
            label5 = new Label();
            btnRegistrar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 150, 143);
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(btnMinimizar);
            panel1.Controls.Add(btnCerrar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 28);
            panel1.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(750, 4);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(21, 21);
            btnMinimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimizar.TabIndex = 1;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(777, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(21, 21);
            btnCerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrar.TabIndex = 1;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(162, 255, 211);
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(417, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 438);
            panel2.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(59, 88);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(271, 254);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(33, 45);
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
            txtNusuario.Location = new Point(43, 121);
            txtNusuario.Name = "txtNusuario";
            txtNusuario.Size = new Size(330, 20);
            txtNusuario.TabIndex = 3;
            txtNusuario.Text = " Nombre de Usuario";
            txtNusuario.TextChanged += txtNusuario_TextChanged;
            txtNusuario.Leave += txtNusuario_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 135);
            label2.Name = "label2";
            label2.Size = new Size(330, 21);
            label2.TabIndex = 4;
            label2.Text = "________________________________________";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(236, 255, 249);
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorreo.Location = new Point(43, 182);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(330, 20);
            txtCorreo.TabIndex = 5;
            txtCorreo.Text = " Correo ";
            txtCorreo.Enter += txtCorreo_Enter;
            txtCorreo.Leave += txtCorreo_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 195);
            label3.Name = "label3";
            label3.Size = new Size(330, 21);
            label3.TabIndex = 6;
            label3.Text = "________________________________________";
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = Color.FromArgb(236, 255, 249);
            txtContrasena.BorderStyle = BorderStyle.None;
            txtContrasena.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContrasena.Location = new Point(43, 245);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(330, 20);
            txtContrasena.TabIndex = 7;
            txtContrasena.Text = " Contraseña";
            txtContrasena.Enter += txtContrasena_Enter;
            txtContrasena.Leave += txtContrasena_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 259);
            label4.Name = "label4";
            label4.Size = new Size(330, 21);
            label4.TabIndex = 8;
            label4.Text = "________________________________________";
            // 
            // txtConfirmar
            // 
            txtConfirmar.BackColor = Color.FromArgb(236, 255, 249);
            txtConfirmar.BorderStyle = BorderStyle.None;
            txtConfirmar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmar.Location = new Point(43, 309);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(330, 20);
            txtConfirmar.TabIndex = 9;
            txtConfirmar.Text = " Confirmar Contraseña";
            txtConfirmar.Enter += txtConfirmar_Enter;
            txtConfirmar.Leave += txtConfirmar_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 323);
            label5.Name = "label5";
            label5.Size = new Size(330, 21);
            label5.TabIndex = 10;
            label5.Text = "________________________________________";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(14, 150, 143);
            btnRegistrar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(117, 379);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(166, 34);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(236, 255, 249);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(btnRegistrar);
            Controls.Add(txtConfirmar);
            Controls.Add(label5);
            Controls.Add(txtContrasena);
            Controls.Add(txtNusuario);
            Controls.Add(txtCorreo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private Panel panel2;
        private Label label1;
        private TextBox txtNusuario;
        private Label label2;
        private TextBox txtCorreo;
        private Label label3;
        private TextBox txtContrasena;
        private Label label4;
        private PictureBox pictureBox3;
        private TextBox txtConfirmar;
        private Label label5;
        private Button btnRegistrar;
    }
}