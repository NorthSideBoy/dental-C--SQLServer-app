using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dental_C__SQLServer_app.Forms.habits_methods;
using dental_C__SQLServer_app.Validations.Dating_methods;

namespace dental_C__SQLServer_app.Forms
{
    public partial class Habits : Form
    {

        private string selectedPatientID; // Variable para almacenar el ID del paciente seleccionado
        private string _selectedID; // Variable para almacenar el ID seleccionado


        public Habits()
        {
            InitializeComponent();
        }

        private void Habits_Load(object sender, EventArgs e)
        {
            // Crear una instancia de la clase CHabits
            CHabits cHabits = new CHabits();

            // Llamar al método Habits() y asignar el resultado al DataGridView
            dataGridView1.DataSource = cHabits.Habits();
            dataGridView2.DataSource = cHabits.Antecedents();

            // Cargar el ComboBox con los nombres completos de los pacientes
            comboBox1.DataSource = cHabits.CargarCombo();
            comboBox1.DisplayMember = "NombreCompleto"; // Columna que muestra el nombre completo
            comboBox1.ValueMember = "PatientID"; // Columna que almacena el PatientID
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una instancia de la clase CHabits
            CHabits cHabits = new CHabits();

            string selectedPatientID = comboBox1.SelectedValue.ToString();


            // Guardar los hábitos y antecedentes del paciente
            GuardarHabits(selectedPatientID);
            GuardarAntecedents(selectedPatientID);

            MessageBox.Show("Datos guardados correctamente.");
            dataGridView1.DataSource = cHabits.Habits();
            dataGridView2.DataSource = cHabits.Antecedents();
        }

        private void GuardarHabits(string PatientID)
        {
            // Aquí debes obtener los valores de los campos del formulario de hábitos
            string NombreH = textBoxHabito.Text;
            string Cepillado = textBoxCepillado.Text;

            // Llamar al método GuardarHabits de la clase CHabits
            CHabits cHabits = new CHabits();
            cHabits.GuardarHabits(Guid.NewGuid().ToString("N"), NombreH, Cepillado, PatientID);
        }

        private void GuardarAntecedents(string PatientID)
        {
            // Aquí debes obtener los valores de los campos del formulario de antecedentes
            string Hemorrágicos = textBoxHemorragicos.Text;
            string Personales = textBoxPersonales.Text;
            string Familiares = textBoxFamiliares.Text;

            // Llamar al método GuardarAntecedents de la clase CHabits
            CHabits cHabits = new CHabits();
            cHabits.GuardarAntecedents(Guid.NewGuid().ToString("N"), Hemorrágicos, Personales, Familiares, PatientID);
        }

        private void textBoxHemorragicos_TextChanged(object sender, EventArgs e)
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
                // Obtener los valores de la fila seleccionada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Almacenar el ID de la cita y el ID del paciente
                _selectedID = row.Cells["HabitsID"].Value.ToString();
                selectedPatientID = row.Cells["PatientID"].Value.ToString();

                // Llenar los TextBox con los datos de la fila seleccionada
                textBoxHabito.Text = row.Cells["NombreH"].Value.ToString();
                textBoxCepillado.Text = row.Cells["Cepillado"].Value.ToString();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar que el clic no sea en la cabecera o fuera de las filas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener los valores de la fila seleccionada
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                // Llenar los TextBox con los datos de la fila seleccionada
                textBoxHemorragicos.Text = row.Cells["Hemorrágicos"].Value.ToString();
                textBoxPersonales.Text = row.Cells["Personales"].Value.ToString();
                textBoxFamiliares.Text = row.Cells["Familiares"].Value.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                string selectedPatientID = comboBox1.SelectedValue.ToString();
                BuscarRegistrosPaciente(selectedPatientID);
            }
        }

        private void BuscarRegistrosPaciente(string patientID)
        {
            CHabits cHabits = new CHabits();

            // Buscar hábitos del paciente
            DataTable habitsTable = cHabits.BuscarHabitsPorPaciente(patientID);
            dataGridView1.DataSource = habitsTable;

            // Buscar antecedentes del paciente
            DataTable antecedentsTable = cHabits.BuscarAntecedentsPorPaciente(patientID);
            dataGridView2.DataSource = antecedentsTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedID) || string.IsNullOrEmpty(selectedPatientID))
            {
                MessageBox.Show("Seleccione un registro para modificar.");
                return;
            }

            // Modificar hábitos
            string NombreH = textBoxHabito.Text;
            string Cepillado = textBoxCepillado.Text;
            CHabits cHabits = new CHabits();
            cHabits.ModificarHabits(_selectedID, NombreH, Cepillado);

            // Modificar antecedentes
            string Hemorrágicos = textBoxHemorragicos.Text;
            string Personales = textBoxPersonales.Text;
            string Familiares = textBoxFamiliares.Text;
            cHabits.ModificarAntecedents(_selectedID, Hemorrágicos, Personales, Familiares);

            MessageBox.Show("Registros modificados correctamente.");
            dataGridView1.DataSource = cHabits.Habits();
            dataGridView2.DataSource = cHabits.Antecedents();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedID) || string.IsNullOrEmpty(selectedPatientID))
            {
                MessageBox.Show("Seleccione un registro para eliminar.");
                return;
            }

            // Eliminar hábitos
            CHabits cHabits = new CHabits();
            cHabits.EliminarHabits(_selectedID);

            // Eliminar antecedentes
            cHabits.EliminarAntecedents(_selectedID);

            MessageBox.Show("Registros eliminados correctamente.");
            dataGridView1.DataSource = cHabits.Habits();
            dataGridView2.DataSource = cHabits.Antecedents();
        }
    }
}
