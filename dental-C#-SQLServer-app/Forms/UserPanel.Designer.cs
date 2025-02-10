namespace dental_C__SQLServer_app
{
    partial class UserPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            fileSystemWatcher1 = new FileSystemWatcher();
            btnAñadirUser = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAñadirUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnAñadirUser
            // 
            btnAñadirUser.BackColor = Color.Blue;
            btnAñadirUser.Image = (Image)resources.GetObject("btnAñadirUser.Image");
            btnAñadirUser.Location = new Point(334, 208);
            btnAñadirUser.Name = "btnAñadirUser";
            btnAñadirUser.Size = new Size(123, 120);
            btnAñadirUser.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAñadirUser.TabIndex = 0;
            btnAñadirUser.TabStop = false;
            btnAñadirUser.UseWaitCursor = true;
            btnAñadirUser.Click += btnAñadirUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(187, 210, 247);
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(334, 331);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 1;
            label1.Text = "Añadir Usuario";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, -32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(201, 227, 252);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-6, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 104);
            panel1.TabIndex = 3;
            panel1.UseWaitCursor = true;
            // 
            // UserPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnAñadirUser);
            Controls.Add(panel1);
            Name = "UserPanel";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel_usuario";
            TransparencyKey = Color.White;
            UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAñadirUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private PictureBox btnAñadirUser;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}