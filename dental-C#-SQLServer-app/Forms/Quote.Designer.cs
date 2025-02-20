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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quote));
            label1 = new Label();
            groupBox1 = new GroupBox();
            button5 = new Button();
            label8 = new Label();
            textBoxHora = new TextBox();
            textBoxApellido = new TextBox();
            textBoxNombre = new TextBox();
            label7 = new Label();
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            textBoxFecha = new TextBox();
            textBoxMotivo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            textBoxFiltro = new TextBox();
            label3 = new Label();
            dataGridView2 = new DataGridView();
            textBoxBuscar = new TextBox();
            label9 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 44);
            label1.Name = "label1";
            label1.Size = new Size(82, 36);
            label1.TabIndex = 0;
            label1.Text = "Cita";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxHora);
            groupBox1.Controls.Add(textBoxApellido);
            groupBox1.Controls.Add(textBoxNombre);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBoxFecha);
            groupBox1.Controls.Add(textBoxMotivo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 229);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(555, 450);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(14, 93, 142);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(419, 414);
            button5.Name = "button5";
            button5.Size = new Size(110, 30);
            button5.TabIndex = 18;
            button5.Text = "Confirmar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 373);
            label8.Name = "label8";
            label8.Size = new Size(50, 19);
            label8.TabIndex = 17;
            label8.Text = "Hora";
            // 
            // textBoxHora
            // 
            textBoxHora.Location = new Point(138, 366);
            textBoxHora.Name = "textBoxHora";
            textBoxHora.Size = new Size(331, 26);
            textBoxHora.TabIndex = 16;
            textBoxHora.Validating += textBoxHora_Validating;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(138, 127);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(331, 26);
            textBoxApellido.TabIndex = 15;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(138, 52);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(331, 26);
            textBoxNombre.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 55);
            label7.Name = "label7";
            label7.Size = new Size(74, 19);
            label7.TabIndex = 13;
            label7.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 134);
            label6.Name = "label6";
            label6.Size = new Size(79, 19);
            label6.TabIndex = 12;
            label6.Text = "Apellido";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(14, 93, 142);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(6, 414);
            button4.Name = "button4";
            button4.Size = new Size(113, 30);
            button4.TabIndex = 11;
            button4.Text = "Guardar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(14, 93, 142);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(293, 414);
            button3.Name = "button3";
            button3.Size = new Size(104, 30);
            button3.TabIndex = 10;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(14, 93, 142);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(159, 414);
            button2.Name = "button2";
            button2.Size = new Size(104, 30);
            button2.TabIndex = 9;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBoxFecha
            // 
            textBoxFecha.Location = new Point(138, 286);
            textBoxFecha.Name = "textBoxFecha";
            textBoxFecha.Size = new Size(331, 26);
            textBoxFecha.TabIndex = 8;
            textBoxFecha.Validating += textBoxFecha_Validating;
            // 
            // textBoxMotivo
            // 
            textBoxMotivo.Location = new Point(138, 207);
            textBoxMotivo.Name = "textBoxMotivo";
            textBoxMotivo.Size = new Size(331, 26);
            textBoxMotivo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 289);
            label5.Name = "label5";
            label5.Size = new Size(60, 19);
            label5.TabIndex = 5;
            label5.Text = "Fecha ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 214);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 4;
            label4.Text = "Motivo";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(1, 119, 215);
            dataGridViewCellStyle2.Font = new Font("Cooper Black", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(688, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(623, 486);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            pictureBox1.Location = new Point(606, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(134, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 93, 142);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1323, 41);
            panel1.TabIndex = 8;
            // 
            // textBoxFiltro
            // 
            textBoxFiltro.Location = new Point(879, 113);
            textBoxFiltro.Name = "textBoxFiltro";
            textBoxFiltro.Size = new Size(204, 23);
            textBoxFiltro.TabIndex = 9;
            textBoxFiltro.TextChanged += textBoxFiltro_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(786, 115);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 10;
            label3.Text = "Buscar";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 131);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(555, 92);
            dataGridView2.TabIndex = 11;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(218, 102);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(263, 23);
            textBoxBuscar.TabIndex = 12;
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(29, 104);
            label9.Name = "label9";
            label9.Size = new Size(165, 21);
            label9.TabIndex = 13;
            label9.Text = "Buscar Paciente";
            // 
            // Quote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1323, 679);
            Controls.Add(label9);
            Controls.Add(textBoxBuscar);
            Controls.Add(dataGridView2);
            Controls.Add(label3);
            Controls.Add(textBoxFiltro);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Quote";
            Text = "Quote";
            Load += Quote_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private TextBox textBoxFecha;
        private TextBox textBoxMotivo;
        private DataGridView dataGridView1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Button button4;
        private TextBox textBoxApellido;
        private TextBox textBoxNombre;
        private Label label7;
        private Label label6;
        private Label label8;
        private TextBox textBoxHora;
        private Button button5;
        private ErrorProvider errorProvider1;
        private Panel panel1;
        private TextBox textBoxFiltro;
        private Label label3;
        private DataGridView dataGridView2;
        private Label label9;
        private TextBox textBoxBuscar;
    }
}