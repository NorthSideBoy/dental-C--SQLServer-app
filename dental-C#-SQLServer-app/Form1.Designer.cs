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
            textBoxSexo = new TextBox();
            label9 = new Label();
            label8 = new Label();
            textBoxTelefono = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBoxEdad = new TextBox();
            textBoxFechaDeNacimiento = new TextBox();
            textBoxApellido = new TextBox();
            textBoxCédula = new TextBox();
            textBoxDirección = new TextBox();
            textboxNombre = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            groupBox1.Controls.Add(textBoxSexo);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxTelefono);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBoxEdad);
            groupBox1.Controls.Add(textBoxFechaDeNacimiento);
            groupBox1.Controls.Add(textBoxApellido);
            groupBox1.Controls.Add(textBoxCédula);
            groupBox1.Controls.Add(textBoxDirección);
            groupBox1.Controls.Add(textboxNombre);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(10, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(598, 311);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos ";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // textBoxSexo
            // 
            textBoxSexo.Location = new Point(393, 211);
            textBoxSexo.Name = "textBoxSexo";
            textBoxSexo.Size = new Size(110, 33);
            textBoxSexo.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(341, 217);
            label9.Name = "label9";
            label9.Size = new Size(46, 21);
            label9.TabIndex = 14;
            label9.Text = "Sexo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(11, 217);
            label8.Name = "label8";
            label8.Size = new Size(76, 21);
            label8.TabIndex = 13;
            label8.Text = "Telefono";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(95, 205);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(154, 33);
            textBoxTelefono.TabIndex = 12;
            textBoxTelefono.TextChanged += textBox7_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(14, 150, 143);
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(341, 283);
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
            button2.Location = new Point(176, 283);
            button2.Name = "button2";
            button2.Size = new Size(91, 28);
            button2.TabIndex = 4;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(393, 147);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(110, 33);
            textBoxEdad.TabIndex = 11;
            // 
            // textBoxFechaDeNacimiento
            // 
            textBoxFechaDeNacimiento.Location = new Point(393, 84);
            textBoxFechaDeNacimiento.Name = "textBoxFechaDeNacimiento";
            textBoxFechaDeNacimiento.Size = new Size(110, 33);
            textBoxFechaDeNacimiento.TabIndex = 10;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(393, 32);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(110, 33);
            textBoxApellido.TabIndex = 9;
            // 
            // textBoxCédula
            // 
            textBoxCédula.Location = new Point(95, 90);
            textBoxCédula.Name = "textBoxCédula";
            textBoxCédula.Size = new Size(112, 33);
            textBoxCédula.TabIndex = 8;
            // 
            // textBoxDirección
            // 
            textBoxDirección.Location = new Point(95, 147);
            textBoxDirección.Name = "textBoxDirección";
            textBoxDirección.Size = new Size(189, 33);
            textBoxDirección.TabIndex = 7;
            textBoxDirección.TextChanged += textBox2_TextChanged;
            // 
            // textboxNombre
            // 
            textboxNombre.Location = new Point(95, 32);
            textboxNombre.Name = "textboxNombre";
            textboxNombre.Size = new Size(131, 33);
            textboxNombre.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 153);
            label7.Name = "label7";
            label7.Size = new Size(83, 21);
            label7.TabIndex = 5;
            label7.Text = "Dirección";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(341, 153);
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
            label5.Location = new Point(313, 38);
            label5.Name = "label5";
            label5.Size = new Size(74, 21);
            label5.TabIndex = 3;
            label5.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(213, 90);
            label4.Name = "label4";
            label4.Size = new Size(180, 21);
            label4.TabIndex = 2;
            label4.Text = "Fecha De Nacimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 38);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 1;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 96);
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(519, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(263, 311);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 255, 249);
            ClientSize = new Size(794, 450);
            Controls.Add(dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox textBoxEdad;
        private TextBox textBoxFechaDeNacimiento;
        private TextBox textBoxApellido;
        private TextBox textBoxCédula;
        private TextBox textBoxDirección;
        private TextBox textboxNombre;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private TextBox textBoxTelefono;
        private Label label9;
        private Label label8;
        private TextBox textBoxSexo;
        private DataGridView dataGridView1;
    }
}
