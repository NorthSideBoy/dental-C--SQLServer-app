namespace dental_C__SQLServer_app
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            btnPacientes = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btnMenu = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnConsultas = new Button();
            panel4 = new Panel();
            btnConfig = new Button();
            btnLogout = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            sidebar = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // btnPacientes
            // 
            btnPacientes.Anchor = AnchorStyles.Left;
            btnPacientes.FlatAppearance.BorderSize = 0;
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPacientes.Image = (Image)resources.GetObject("btnPacientes.Image");
            btnPacientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnPacientes.Location = new Point(-16, -12);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Padding = new Padding(20, 0, 0, 0);
            btnPacientes.Size = new Size(235, 74);
            btnPacientes.TabIndex = 1;
            btnPacientes.Text = "   Pacientes";
            btnPacientes.TextAlign = ContentAlignment.MiddleLeft;
            btnPacientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPacientes.UseVisualStyleBackColor = true;
            btnPacientes.Click += btnPacientes_Click;
            btnPacientes.MouseLeave += btnPacientes_MouseLeave;
            btnPacientes.MouseMove += btnPacientes_MouseMove;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(185, 255, 233);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMenu);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 42);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 6;
            label1.Text = "Menú";
            // 
            // btnMenu
            // 
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(12, 29);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(47, 39);
            btnMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMenu.TabIndex = 5;
            btnMenu.TabStop = false;
            btnMenu.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPacientes);
            panel2.Location = new Point(0, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 55);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnConsultas);
            panel3.Location = new Point(0, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 55);
            panel3.TabIndex = 2;
            // 
            // btnConsultas
            // 
            btnConsultas.Anchor = AnchorStyles.Left;
            btnConsultas.FlatAppearance.BorderSize = 0;
            btnConsultas.FlatStyle = FlatStyle.Flat;
            btnConsultas.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultas.ForeColor = SystemColors.ControlText;
            btnConsultas.Image = (Image)resources.GetObject("btnConsultas.Image");
            btnConsultas.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultas.Location = new Point(-16, -12);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Padding = new Padding(20, 0, 0, 0);
            btnConsultas.Size = new Size(235, 74);
            btnConsultas.TabIndex = 1;
            btnConsultas.Text = "   Consultas";
            btnConsultas.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultas.UseVisualStyleBackColor = true;
            btnConsultas.MouseLeave += btnConsultas_MouseLeave;
            btnConsultas.MouseMove += btnConsultas_MouseMove;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnConfig);
            panel4.Location = new Point(0, 211);
            panel4.Name = "panel4";
            panel4.Size = new Size(221, 55);
            panel4.TabIndex = 3;
            // 
            // btnConfig
            // 
            btnConfig.Anchor = AnchorStyles.Left;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfig.Image = (Image)resources.GetObject("btnConfig.Image");
            btnConfig.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfig.Location = new Point(-16, -12);
            btnConfig.Name = "btnConfig";
            btnConfig.Padding = new Padding(20, 0, 0, 0);
            btnConfig.Size = new Size(235, 74);
            btnConfig.TabIndex = 1;
            btnConfig.Text = "   Configuración";
            btnConfig.TextAlign = ContentAlignment.MiddleLeft;
            btnConfig.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfig.UseVisualStyleBackColor = true;
            btnConfig.MouseLeave += btnConfig_MouseLeave;
            btnConfig.MouseMove += btnConfig_MouseMove;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 467);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(7, 0, 0, 0);
            btnLogout.Size = new Size(220, 53);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "  Cerrar Sesión";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += Logout_Click;
            btnLogout.MouseLeave += btnLogout_MouseLeave;
            btnLogout.MouseMove += btnLogout_MouseMove;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(236, 255, 249);
            sidebar.Controls.Add(btnLogout);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel3);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(220, 520);
            sidebar.TabIndex = 5;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1014, 520);
            Controls.Add(sidebar);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnPacientes;
        private Button btnConsultas;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnConfig;
        private PictureBox btnMenu;
        private Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
        private Button btnLogout;
        private Panel sidebar;
    }
}
