﻿namespace dental_C__SQLServer_app
{
    partial class Patients
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            label1 = new Label();
            groupBox1 = new GroupBox();
            comboBoxSexo = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textTelefono = new TextBox();
            textFechaDeNacimiento = new TextBox();
            textDirección = new TextBox();
            textCédula = new TextBox();
            textApellido = new TextBox();
            textNombre = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            dtGridViewpatients = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridViewpatients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 137);
            label1.Name = "label1";
            label1.Size = new Size(355, 39);
            label1.TabIndex = 0;
            label1.Text = "Registro De Pacientes";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(79, 209, 204);
            groupBox1.Controls.Add(comboBoxSexo);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textTelefono);
            groupBox1.Controls.Add(textFechaDeNacimiento);
            groupBox1.Controls.Add(textDirección);
            groupBox1.Controls.Add(textCédula);
            groupBox1.Controls.Add(textApellido);
            groupBox1.Controls.Add(textNombre);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(59, 183);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(530, 345);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBoxSexo
            // 
            comboBoxSexo.FormattingEnabled = true;
            comboBoxSexo.Items.AddRange(new object[] { "Femenino ", "Maculino" });
            comboBoxSexo.Location = new Point(111, 238);
            comboBoxSexo.Name = "comboBoxSexo";
            comboBoxSexo.Size = new Size(159, 30);
            comboBoxSexo.TabIndex = 19;
            // 
            // button3
            // 
            button3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(381, 304);
            button3.Name = "button3";
            button3.Size = new Size(81, 23);
            button3.TabIndex = 18;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(245, 304);
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
            button1.Location = new Point(122, 304);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(372, 178);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(140, 31);
            textTelefono.TabIndex = 16;
            textTelefono.Validating += textTelefono_Validating;
            // 
            // textFechaDeNacimiento
            // 
            textFechaDeNacimiento.Location = new Point(372, 121);
            textFechaDeNacimiento.Name = "textFechaDeNacimiento";
            textFechaDeNacimiento.Size = new Size(140, 31);
            textFechaDeNacimiento.TabIndex = 13;
            textFechaDeNacimiento.TextChanged += textFechaDeNacimiento_TextChanged;
            textFechaDeNacimiento.Validating += textFechaDeNacimiento_Validating;
            // 
            // textDirección
            // 
            textDirección.Location = new Point(111, 178);
            textDirección.Name = "textDirección";
            textDirección.Size = new Size(159, 31);
            textDirección.TabIndex = 12;
            // 
            // textCédula
            // 
            textCédula.Location = new Point(111, 121);
            textCédula.Name = "textCédula";
            textCédula.Size = new Size(159, 31);
            textCédula.TabIndex = 9;
            textCédula.TextChanged += textBox1_TextChanged;
            textCédula.Validating += textCédula_Validating;
            // 
            // textApellido
            // 
            textApellido.Location = new Point(372, 69);
            textApellido.Name = "textApellido";
            textApellido.Size = new Size(140, 31);
            textApellido.TabIndex = 10;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(111, 69);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(159, 31);
            textNombre.TabIndex = 11;
            textNombre.TextChanged += textNombre_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(39, 246);
            label9.Name = "label9";
            label9.Size = new Size(37, 17);
            label9.TabIndex = 7;
            label9.Text = "Sexo";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(291, 186);
            label8.Name = "label8";
            label8.Size = new Size(62, 17);
            label8.TabIndex = 6;
            label8.Text = "Teléfono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(39, 192);
            label6.Name = "label6";
            label6.Size = new Size(69, 17);
            label6.TabIndex = 4;
            label6.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 129);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 3;
            label5.Text = "Cédula";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(291, 129);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 2;
            label4.Text = "F. De Nac.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(291, 79);
            label3.Name = "label3";
            label3.Size = new Size(61, 17);
            label3.TabIndex = 1;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 79);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            label2.Click += label2_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(834, 117);
            label10.Name = "label10";
            label10.Size = new Size(297, 39);
            label10.TabIndex = 8;
            label10.Text = "Lista de Pacientes";
            // 
            // dtGridViewpatients
            // 
            dtGridViewpatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dtGridViewpatients.BackgroundColor = Color.FromArgb(79, 209, 204);
            dtGridViewpatients.BorderStyle = BorderStyle.None;
            dtGridViewpatients.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtGridViewpatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtGridViewpatients.ColumnHeadersHeight = 30;
            dtGridViewpatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtGridViewpatients.EnableHeadersVisualStyles = false;
            dtGridViewpatients.GridColor = Color.FromArgb(79, 209, 204);
            dtGridViewpatients.Location = new Point(610, 183);
            dtGridViewpatients.Name = "dtGridViewpatients";
            dtGridViewpatients.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(79, 209, 204);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtGridViewpatients.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(79, 209, 204);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 205, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dtGridViewpatients.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dtGridViewpatients.Size = new Size(683, 414);
            dtGridViewpatients.TabIndex = 9;
            dtGridViewpatients.CellClick += Datagr;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(510, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(727, 84);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1305, 616);
            Controls.Add(dtGridViewpatients);
            Controls.Add(label10);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Patients";
            Text = "Patients";
            Load += Patients_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridViewpatients).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textTelefono;
        private TextBox textFechaDeNacimiento;
        private TextBox textDirección;
        private TextBox textCédula;
        private TextBox textApellido;
        private TextBox textNombre;
        private DataGridView dtGridViewpatients;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ErrorProvider errorProvider1;
        private ComboBox comboBoxSexo;
    }
}