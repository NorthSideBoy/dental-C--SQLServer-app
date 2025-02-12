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
using static System.Net.Mime.MediaTypeNames;

namespace dental_C__SQLServer_app.Forms
{
    public partial class Quote : Form
    {
        public Quote(string id, string nombre, string apellido)
        {
            InitializeComponent();
            textBoxID_Patients.Text = id;
            textBoxNombre.Text = nombre;
            textBoxApellido.Text = apellido;
        }

        private string _selectedID; // Variable para almacenar el ID seleccionado
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

        private void button4_Click(object sender, EventArgs e)
        {

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que el clic no sea en la cabecera o fuera de las filas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Crear una instancia de la clase que contiene el método Seleccionar
                CQuote cQuote = new CQuote();

                // Llamar al método Seleccionar y almacenar el ID seleccionado
                _selectedID = cQuote.Seleccionar(
                    dataGridView1,
                    textBoxID_Patients,
                    textBoxNombre,
                    textBoxApellido,
                    textBoxMotivo,
                    textBoxFecha,
                    textBoxHora
                );

                // Ahora puedes usar _selectedID para otras operaciones
                System.Diagnostics.Debug.WriteLine($"ID seleccionado: {_selectedID}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la clase que contiene el método Seleccionar
            CQuote cQuote = new CQuote();
            cQuote.Modificar( textBoxID_Patients, textBoxMotivo, textBoxFecha, textBoxHora);
            // Actualizar el DataGridView con los nuevos datos
            dataGridView1.DataSource = cQuote.Cita();
        }
    }
}

