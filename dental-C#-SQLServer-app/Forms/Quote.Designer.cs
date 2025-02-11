namespace dental_C__SQLServer_app.Forms
{
    partial class Quote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quote));
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBoxApellido = new TextBox();
            textBoxNombre = new TextBox();
            label7 = new Label();
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBoxID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 61);
            label1.Name = "label1";
            label1.Size = new Size(82, 36);
            label1.TabIndex = 0;
            label1.Text = "Cita";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(213, 231, 255);
            groupBox1.Controls.Add(textBoxApellido);
            groupBox1.Controls.Add(textBoxNombre);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBoxID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(499, 504);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(138, 156);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(331, 26);
            textBoxApellido.TabIndex = 15;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(138, 93);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(331, 26);
            textBoxNombre.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 96);
            label7.Name = "label7";
            label7.Size = new Size(74, 19);
            label7.TabIndex = 13;
            label7.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 163);
            label6.Name = "label6";
            label6.Size = new Size(79, 19);
            label6.TabIndex = 12;
            label6.Text = "Apellido";
            // 
            // button4
            // 
            button4.Location = new Point(19, 450);
            button4.Name = "button4";
            button4.Size = new Size(113, 30);
            button4.TabIndex = 11;
            button4.Text = "Guardar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(291, 450);
            button3.Name = "button3";
            button3.Size = new Size(104, 30);
            button3.TabIndex = 10;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(159, 450);
            button2.Name = "button2";
            button2.Size = new Size(104, 30);
            button2.TabIndex = 9;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 318);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(331, 26);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 219);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(331, 26);
            textBox2.TabIndex = 7;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(138, 39);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(331, 26);
            textBoxID.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 325);
            label5.Name = "label5";
            label5.Size = new Size(115, 19);
            label5.TabIndex = 5;
            label5.Text = "Fecha y Hora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 226);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 4;
            label4.Text = "Motivo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 42);
            label3.Name = "label3";
            label3.Size = new Size(126, 19);
            label3.TabIndex = 3;
            label3.Text = "ID De Paciente";
            label3.Click += label3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(611, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(580, 363);
            dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(786, 61);
            label2.Name = "label2";
            label2.Size = new Size(235, 36);
            label2.TabIndex = 3;
            label2.Text = "Lista De Citas";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(404, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(688, 107);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(126, 26);
            textBox4.TabIndex = 5;
            textBox4.Text = "Nombre";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(853, 107);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(126, 26);
            textBox5.TabIndex = 6;
            textBox5.Text = "Apellido";
            // 
            // button1
            // 
            button1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1049, 105);
            button1.Name = "button1";
            button1.Size = new Size(90, 29);
            button1.TabIndex = 7;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Quote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1203, 679);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Quote";
            Text = "Quote";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBoxID;
        private DataGridView dataGridView1;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private TextBox textBoxApellido;
        private TextBox textBoxNombre;
        private Label label7;
        private Label label6;
    }
}