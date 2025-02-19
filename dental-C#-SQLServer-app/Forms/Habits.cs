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
            string NombreH = textBoxHabito.Text; // Reemplaza con el valor real
            string Cepillado = textBoxCepillado.Text; // Reemplaza con el valor real

            // Llamar al método GuardarHabits de la clase CHabits
            CHabits cHabits = new CHabits();
            cHabits.GuardarHabits(Guid.NewGuid().ToString("N"), NombreH, Cepillado, PatientID);
        }

        private void GuardarAntecedents(string PatientID)
        {
            // Aquí debes obtener los valores de los campos del formulario de antecedentes
            string Hemorrágicos = textBoxHemorragicos.Text; // Reemplaza con el valor real
            string Personales = textBoxPersonales.Text; // Reemplaza con el valor real
            string Familiares = textBoxFamiliares.Text; // Reemplaza con el valor real

            // Llamar al método GuardarAntecedents de la clase CHabits
            CHabits cHabits = new CHabits();
            cHabits.GuardarAntecedents(Guid.NewGuid().ToString("N"), Hemorrágicos, Personales, Familiares, PatientID);
        }
    }
}
