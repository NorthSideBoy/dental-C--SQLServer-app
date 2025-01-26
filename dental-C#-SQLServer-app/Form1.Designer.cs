namespace dental_C__SQLServer_app
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            ptbLogo = new PictureBox();
            btnConfig = new Button();
            btnPacientes = new Button();
            btnConsultas = new Button();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(236, 255, 249);
            panelMenu.Controls.Add(ptbLogo);
            panelMenu.Controls.Add(btnConfig);
            panelMenu.Controls.Add(btnPacientes);
            panelMenu.Controls.Add(btnConsultas);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 519);
            panelMenu.TabIndex = 0;
            // 
            // ptbLogo
            // 
            ptbLogo.BackColor = Color.FromArgb(14, 150, 143);
            ptbLogo.Dock = DockStyle.Top;
            ptbLogo.Image = (Image)resources.GetObject("ptbLogo.Image");
            ptbLogo.Location = new Point(0, 0);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(220, 170);
            ptbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbLogo.TabIndex = 1;
            ptbLogo.TabStop = false;
            // 
            // btnConfig
            // 
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfig.Image = (Image)resources.GetObject("btnConfig.Image");
            btnConfig.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfig.Location = new Point(0, 290);
            btnConfig.Name = "btnConfig";
            btnConfig.Padding = new Padding(12, 0, 0, 0);
            btnConfig.Size = new Size(220, 60);
            btnConfig.TabIndex = 3;
            btnConfig.Text = "   Configuración";
            btnConfig.TextAlign = ContentAlignment.MiddleLeft;
            btnConfig.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.Click += btnConfig_Click;
            btnConfig.MouseLeave += btnConfig_MouseLeave;
            btnConfig.MouseMove += btnConfig_MouseMove;
            // 
            // btnPacientes
            // 
            btnPacientes.FlatAppearance.BorderSize = 0;
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPacientes.Image = Properties.Resources._1446930__1___1_;
            btnPacientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnPacientes.Location = new Point(0, 170);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Padding = new Padding(12, 0, 0, 0);
            btnPacientes.Size = new Size(220, 60);
            btnPacientes.TabIndex = 1;
            btnPacientes.Text = "   Pacientes";
            btnPacientes.TextAlign = ContentAlignment.MiddleLeft;
            btnPacientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPacientes.UseVisualStyleBackColor = true;
            btnPacientes.Click += btnPacientes_Click;
            btnPacientes.MouseLeave += btnPacientes_MouseLeave;
            btnPacientes.MouseMove += btnPacientes_MouseMove;
            // 
            // btnConsultas
            // 
            btnConsultas.FlatAppearance.BorderSize = 0;
            btnConsultas.FlatStyle = FlatStyle.Flat;
            btnConsultas.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultas.Image = (Image)resources.GetObject("btnConsultas.Image");
            btnConsultas.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultas.Location = new Point(0, 230);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Padding = new Padding(12, 0, 0, 0);
            btnConsultas.Size = new Size(220, 60);
            btnConsultas.TabIndex = 2;
            btnConsultas.Text = "   Concultas";
            btnConsultas.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultas.UseVisualStyleBackColor = true;
            btnConsultas.Click += btnConsultas_Click;
            btnConsultas.MouseLeave += btnConsultas_MouseLeave;
            btnConsultas.MouseMove += btnConsultas_MouseMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 519);
            Controls.Add(panelMenu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnPacientes;
        private Button btnConfig;
        private Button btnConsultas;
        private PictureBox ptbLogo;
    }
}
