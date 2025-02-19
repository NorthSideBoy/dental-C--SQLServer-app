namespace dental_C__SQLServer_app.Forms
{
    partial class Habits
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            textBoxHabito = new TextBox();
            textBoxHemorragicos = new TextBox();
            textBoxCepillado = new TextBox();
            textBoxPersonales = new TextBox();
            textBoxFamiliares = new TextBox();
            Hábito = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(337, 83);
            label1.Name = "label1";
            label1.Size = new Size(105, 27);
            label1.TabIndex = 0;
            label1.Text = "Hábitos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(141, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(505, 139);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(337, 323);
            label2.Name = "label2";
            label2.Size = new Size(178, 27);
            label2.TabIndex = 2;
            label2.Text = "Antecedentes";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(141, 455);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(505, 147);
            dataGridView2.TabIndex = 3;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // textBoxHabito
            // 
            textBoxHabito.Location = new Point(294, 113);
            textBoxHabito.Name = "textBoxHabito";
            textBoxHabito.Size = new Size(342, 23);
            textBoxHabito.TabIndex = 4;
            // 
            // textBoxHemorragicos
            // 
            textBoxHemorragicos.Location = new Point(294, 368);
            textBoxHemorragicos.Name = "textBoxHemorragicos";
            textBoxHemorragicos.Size = new Size(342, 23);
            textBoxHemorragicos.TabIndex = 5;
            textBoxHemorragicos.TextChanged += textBoxHemorragicos_TextChanged;
            // 
            // textBoxCepillado
            // 
            textBoxCepillado.Location = new Point(294, 142);
            textBoxCepillado.Name = "textBoxCepillado";
            textBoxCepillado.Size = new Size(342, 23);
            textBoxCepillado.TabIndex = 6;
            // 
            // textBoxPersonales
            // 
            textBoxPersonales.Location = new Point(294, 397);
            textBoxPersonales.Name = "textBoxPersonales";
            textBoxPersonales.Size = new Size(342, 23);
            textBoxPersonales.TabIndex = 7;
            // 
            // textBoxFamiliares
            // 
            textBoxFamiliares.Location = new Point(294, 426);
            textBoxFamiliares.Name = "textBoxFamiliares";
            textBoxFamiliares.Size = new Size(342, 23);
            textBoxFamiliares.TabIndex = 8;
            // 
            // Hábito
            // 
            Hábito.AutoSize = true;
            Hábito.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Hábito.Location = new Point(189, 113);
            Hábito.Name = "Hábito";
            Hábito.Size = new Size(64, 19);
            Hábito.TabIndex = 9;
            Hábito.Text = "Hábito";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(189, 146);
            label3.Name = "label3";
            label3.Size = new Size(87, 19);
            label3.TabIndex = 10;
            label3.Text = "Cepillado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(165, 368);
            label4.Name = "label4";
            label4.Size = new Size(123, 19);
            label4.TabIndex = 11;
            label4.Text = "Hemorrágicos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(189, 397);
            label5.Name = "label5";
            label5.Size = new Size(97, 19);
            label5.TabIndex = 12;
            label5.Text = "Personales";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(189, 426);
            label6.Name = "label6";
            label6.Size = new Size(96, 19);
            label6.TabIndex = 13;
            label6.Text = "Familiares";
            // 
            // button2
            // 
            button2.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(209, 623);
            button2.Name = "button2";
            button2.Size = new Size(116, 23);
            button2.TabIndex = 15;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(242, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(333, 23);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(353, 623);
            button1.Name = "button1";
            button1.Size = new Size(116, 23);
            button1.TabIndex = 17;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(494, 623);
            button3.Name = "button3";
            button3.Size = new Size(116, 23);
            button3.TabIndex = 18;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Habits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 658);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Hábito);
            Controls.Add(textBoxFamiliares);
            Controls.Add(textBoxPersonales);
            Controls.Add(textBoxCepillado);
            Controls.Add(textBoxHemorragicos);
            Controls.Add(textBoxHabito);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Habits";
            Text = "Habits";
            Load += Habits_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridView dataGridView2;
        private TextBox textBoxHabito;
        private TextBox textBoxHemorragicos;
        private TextBox textBoxCepillado;
        private TextBox textBoxPersonales;
        private TextBox textBoxFamiliares;
        private Label Hábito;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private ComboBox comboBox1;
        private Button button1;
        private Button button3;
    }
}