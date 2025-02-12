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
            textBoxID_Pacients.Text = id;
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

        private void button4_Click(object sender, EventArgs e)
        {

            // Obtener los valores de los TextBox
            string ID_Patient = textBoxID_Pacients.Text;
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            string Motivo = textBoxMotivo.Text;
            string Fecha = textBoxFecha.Text;
            string Hora = textBoxHora.Text;
            String ID = Text;

            // Insertar la cita en la base de datos
            CQuote cQuote = new CQuote();
            try
            {
                cQuote.InsertarCita(ID_Patient, nombre, apellido, Motivo, Fecha, Hora, ID);
                MessageBox.Show("Cita guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar el DataGridView con los nuevos datos
                dataGridView1.DataSource = cQuote.Cita();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que se ha hecho clic en una celda válida
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                CQuote cQuote = new CQuote();
                cQuote.Seleccionar(dataGridView1, textBoxID_Pacients, textBoxNombre, textBoxApellido, textBoxMotivo, textBoxFecha, textBoxHora);
            }
            else
            {
                // Manejar el caso donde se hace clic en el encabezado de la columna o en una fila no válida
                System.Diagnostics.Debug.WriteLine("Se hizo clic en una celda no válida.");
            }
        }
    }
   }

