using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using dental_C__SQLServer_app.Validations.Dating_methods;

namespace dental_C__SQLServer_app.Forms
{
    public partial class Quote : Form
    {
        public Quote(string id, string nombre, string apellido)
        {
            InitializeComponent();
            textBoxID.Text = id;
            textBoxNombre.Text = nombre;
            textBoxApellido.Text = apellido;
        }

        public Quote()
        {
            InitializeComponent();
        }

        private void Quote_Load(object sender, EventArgs e)
        {
            // Crear una instancia de la clase CQuote
            CQuote cQuote = new CQuote();

            // Llamar al método Cita() y asignar el resultado al DataGridView
            dataGridView1.DataSource = cQuote.Cita();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento para el clic en label1 (puedes agregar lógica si es necesario)
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Evento para el clic en label2 (puedes agregar lógica si es necesario)
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Evento para el clic en label3 (puedes agregar lógica si es necesario)
        }
    }
}