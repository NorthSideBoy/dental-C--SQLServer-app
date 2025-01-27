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
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuText;
            label1.Location = new Point(227, 97);
            label1.Name = "label1";
            label1.Size = new Size(343, 39);
            label1.TabIndex = 0;
            label1.Text = "Registro De Paciente";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(162, 255, 211);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(99, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(598, 299);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos ";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(14, 150, 143);
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(340, 265);
            button1.Name = "button1";
            button1.Size = new Size(75, 28);
            button1.TabIndex = 3;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(14, 150, 143);
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(174, 265);
            button2.Name = "button2";
            button2.Size = new Size(91, 28);
            button2.TabIndex = 4;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(458, 166);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(110, 33);
            textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(458, 105);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(110, 33);
            textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(458, 45);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 33);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(95, 111);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(112, 33);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(97, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 33);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 33);
            textBox1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 178);
            label7.Name = "label7";
            label7.Size = new Size(83, 21);
            label7.TabIndex = 5;
            label7.Text = "Dirección";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(394, 117);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 4;
            label6.Text = "Edad";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(378, 51);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 3;
            label5.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(400, 178);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 2;
            label4.Text = "Sexo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 51);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 1;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 117);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 0;
            label2.Text = "Cédula";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(152, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(486, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 255, 249);
            ClientSize = new Size(794, 450);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}
