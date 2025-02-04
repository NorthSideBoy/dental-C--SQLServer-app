namespace dental_C__SQLServer_app
{
    partial class Panel_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_usuario));
            fileSystemWatcher1 = new FileSystemWatcher();
            btnAñadirUser = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAñadirUser).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnAñadirUser
            // 
            btnAñadirUser.Image = (Image)resources.GetObject("btnAñadirUser.Image");
            btnAñadirUser.Location = new Point(334, 183);
            btnAñadirUser.Name = "btnAñadirUser";
            btnAñadirUser.Size = new Size(123, 120);
            btnAñadirUser.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAñadirUser.TabIndex = 0;
            btnAñadirUser.TabStop = false;
            btnAñadirUser.Click += btnAñadirUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(334, 317);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 1;
            label1.Text = "Añadir Usuario";
            // 
            // Panel_usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 255, 249);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnAñadirUser);
            Name = "Panel_usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel_usuario";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAñadirUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private PictureBox btnAñadirUser;
        private Label label1;
    }
}