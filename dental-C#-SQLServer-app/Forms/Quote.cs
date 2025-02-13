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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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

        private void reset()
        {
            textBoxID_Patients.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxMotivo.Text = "";
            textBoxFecha.Text = "";
            textBoxHora.Text = "";
           
  
        }

        private bool    Validarcampos()
        {
            bool validado = true;

            if (textBoxID_Patients.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxID_Patients, "Ingresar ID De Pacientes");
            }

            if (textBoxNombre.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxNombre, "Ingresar Nombre Del paciente");
            }

            if (textBoxApellido.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxApellido, "Ingresar Apellido Del Paciente");
            }

            if (textBoxMotivo.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxMotivo, "Ingresar Motivo");
            }

            if (textBoxFecha.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxFecha, "Ingresar Fecha");
            }

            if (textBoxHora.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textBoxHora, "Ingresar Hora");
            }



            return validado;
        }

        private void MensajeBorrar()
        {
            errorProvider1.SetError(textBoxID_Patients, "");
            errorProvider1.SetError(textBoxNombre, "");
            errorProvider1.SetError(textBoxApellido, "");
            errorProvider1.SetError(textBoxMotivo, "");
            errorProvider1.SetError(textBoxFecha, "");
            errorProvider1.SetError(textBoxHora, "");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Borrar mensajes de error anteriores
            MensajeBorrar();

            // Validar los campos antes de proceder
            if (!Validarcampos())
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los valores de los TextBox
            string ID_Patient = textBoxID_Patients.Text;
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            string Motivo = textBoxMotivo.Text;
            string Fecha = textBoxFecha.Text;
            string Hora = textBoxHora.Text;
            string ID = _selectedID; // Usar el ID seleccionado si es necesario

            // Insertar la cita en la base de datos
            CQuote cQuote = new CQuote();
            try
            {
                cQuote.InsertarCita(ID_Patient, nombre, apellido, Motivo, Fecha, Hora, ID);
                MessageBox.Show("Cita guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar el DataGridView con los nuevos datos
                dataGridView1.DataSource = cQuote.Cita();

                // Limpiar los TextBox después de la inserción
                reset();
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
            cQuote.Modificar(textBoxID_Patients, textBoxMotivo, textBoxFecha, textBoxHora);
            // Actualizar el DataGridView con los nuevos datos
            dataGridView1.DataSource = cQuote.Cita();
            
            // para que los textbox queden vacios
            reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado una cita
            if (string.IsNullOrEmpty(_selectedID))
            {
                MessageBox.Show("Debe seleccionar una cita para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Pedir confirmación al usuario
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro de que desea eliminar esta cita?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Si el usuario confirma, eliminar la cita
            if (resultado == DialogResult.Yes)
            {
                // Crear una instancia de la clase que contiene el método EliminarCita
                CQuote cQuote = new CQuote();

                // Llamar al método EliminarCita
                cQuote.EliminarCita(_selectedID);

                // Actualizar el DataGridView (opcional)
                dataGridView1.DataSource = cQuote.Cita(); // Suponiendo que tienes un método Cita() que devuelve un DataTable
                // para que los texbox queden vacios
                reset();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

