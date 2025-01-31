namespace dental_C__SQLServer_app.Clases
{
    partial class Form1
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            textId = new TextBox();
            label11 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textTelefono = new TextBox();
            textSexo = new TextBox();
            textEdad = new TextBox();
            textFechaDeNacimiento = new TextBox();
            textDirección = new TextBox();
            textCédula = new TextBox();
            textApellido = new TextBox();
            textNombre = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            dtGridViewpacientes = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridViewpacientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 117);
            label1.Name = "label1";
            label1.Size = new Size(355, 39);
            label1.TabIndex = 0;
            label1.Text = "Registro De Pacientes";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textId);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textTelefono);
            groupBox1.Controls.Add(textSexo);
            groupBox1.Controls.Add(textEdad);
            groupBox1.Controls.Add(textFechaDeNacimiento);
            groupBox1.Controls.Add(textDirección);
            groupBox1.Controls.Add(textCédula);
            groupBox1.Controls.Add(textApellido);
            groupBox1.Controls.Add(textNombre);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 179);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(530, 345);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // textId
            // 
            textId.Location = new Point(81, 20);
            textId.Name = "textId";
            textId.Size = new Size(73, 31);
            textId.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(39, 29);
            label11.Name = "label11";
            label11.Size = new Size(29, 22);
            label11.TabIndex = 19;
            label11.Text = "ID";
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(317, 304);
            button3.Name = "button3";
            button3.Size = new Size(81, 23);
            button3.TabIndex = 18;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(181, 304);
            button2.Name = "button2";
            button2.Size = new Size(81, 23);
            button2.TabIndex = 17;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(58, 304);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(76, 247);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(159, 31);
            textTelefono.TabIndex = 16;
            // 
            // textSexo
            // 
            textSexo.Location = new Point(365, 247);
            textSexo.Name = "textSexo";
            textSexo.Size = new Size(140, 31);
            textSexo.TabIndex = 15;
            // 
            // textEdad
            // 
            textEdad.Location = new Point(365, 172);
            textEdad.Name = "textEdad";
            textEdad.Size = new Size(140, 31);
            textEdad.TabIndex = 14;
            // 
            // textFechaDeNacimiento
            // 
            textFechaDeNacimiento.Location = new Point(365, 109);
            textFechaDeNacimiento.Name = "textFechaDeNacimiento";
            textFechaDeNacimiento.Size = new Size(140, 31);
            textFechaDeNacimiento.TabIndex = 13;
            // 
            // textDirección
            // 
            textDirección.Location = new Point(81, 178);
            textDirección.Name = "textDirección";
            textDirección.Size = new Size(159, 31);
            textDirección.TabIndex = 12;
            // 
            // textCédula
            // 
            textCédula.Location = new Point(81, 119);
            textCédula.Name = "textCédula";
            textCédula.Size = new Size(154, 31);
            textCédula.TabIndex = 9;
            textCédula.TextChanged += textBox1_TextChanged;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(365, 50);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(140, 31);
            textApellido.TabIndex = 10;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(81, 69);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(159, 31);
            textNombre.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(284, 257);
            label9.Name = "label9";
            label9.Size = new Size(37, 17);
            label9.TabIndex = 7;
            label9.Text = "Sexo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(8, 257);
            label8.Name = "label8";
            label8.Size = new Size(62, 17);
            label8.TabIndex = 6;
            label8.Text = "Teléfono";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(284, 188);
            label7.Name = "label7";
            label7.Size = new Size(42, 17);
            label7.TabIndex = 5;
            label7.Text = "Edad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 188);
            label6.Name = "label6";
            label6.Size = new Size(69, 17);
            label6.TabIndex = 4;
            label6.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 129);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 3;
            label5.Text = "Cédula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(284, 119);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 2;
            label4.Text = "F. De Nac.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(284, 60);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 1;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 79);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(850, 117);
            label10.Name = "label10";
            label10.Size = new Size(297, 39);
            label10.TabIndex = 8;
            label10.Text = "Lista de Pacientes";
            // 
            // dtGridViewpacientes
            // 
            dtGridViewpacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridViewpacientes.Location = new Point(678, 190);
            dtGridViewpacientes.Name = "dtGridViewpacientes";
            dtGridViewpacientes.Size = new Size(615, 414);
            dtGridViewpacientes.TabIndex = 9;
            dtGridViewpacientes.CellContentClick += Datagr;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 616);
            Controls.Add(dtGridViewpacientes);
            Controls.Add(label10);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridViewpacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textTelefono;
        private TextBox textSexo;
        private TextBox textEdad;
        private TextBox textFechaDeNacimiento;
        private TextBox textDirección;
        private TextBox textCédula;
        private TextBox textApellido;
        private TextBox textNombre;
        private DataGridView dtGridViewpacientes;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label11;
        private TextBox textId;
    }
}