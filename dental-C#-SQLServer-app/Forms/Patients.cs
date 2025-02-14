using dental_C__SQLServer_app.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;       
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.Data.SqlClient;
using SqlDataAdapter = Microsoft.Data.SqlClient.SqlDataAdapter;

namespace dental_C__SQLServer_app
{
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            dtGridViewpatients.DataSource = Index();
        }

        public DataTable Index()
        {
            DataTable dataTable = new DataTable();
            string Sql = "SELECT ID, Nombre, Apellido, Cédula, FechaDeNacimiento, Edad, Dirección, Telefono, Sexo FROM patients";
            Microsoft.Data.SqlClient.SqlCommand CMD = new Microsoft.Data.SqlClient.SqlCommand(Sql, Program.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);

            adapter.Fill(dataTable);
            return dataTable;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void reset()
        {
            textNombre.Text = "";
            textApellido.Text = "";
            textCédula.Text = "";
            textFechaDeNacimiento.Text = "";
            textDirección.Text = "";
            textTelefono.Text = "";
            comboBoxSexo.Text = "";
        }

        public string Query;
        public Microsoft.Data.SqlClient.SqlCommand Operation;



        public void button1_Click(object sender, EventArgs e)
        {
            MensajeBorrar();
            if (validarcampos())
            {
                Guid guid = Guid.NewGuid();
                string hexValue = guid.ToString("N");

               


                Operation.Parameters.AddWithValue("@ID", hexValue);
                Operation.Parameters.AddWithValue("@Nombre", textNombre.Text);
                Operation.Parameters.AddWithValue("@Apellido", textApellido.Text);
                Operation.Parameters.AddWithValue("@Cédula", textCédula.Text);
                Operation.Parameters.AddWithValue("@FechaDeNacimiento", textFechaDeNacimiento.Text);
                Operation.Parameters.AddWithValue("@Dirección", textDirección.Text);
                Operation.Parameters.AddWithValue("@Telefono", textTelefono.Text);
                Operation.Parameters.AddWithValue("@Sexo", value: comboBoxSexo.Text);

                Operation.ExecuteNonQuery();
                MessageBox.Show("Los Datos Fueron Guardados Correctamente");

                dtGridViewpatients.DataSource = Index();
                reset();
            }
        }
        public int Age;
        private bool validarcampos()
        {
            bool validado = true;

            if (textNombre.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textNombre, "Ingresar Nombre");
            }

            if (textApellido.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textApellido, "Ingresar Apellido");
            }

            if (textCédula.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textCédula, "Ingresar Cédula");
            }

            if (textFechaDeNacimiento.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textFechaDeNacimiento, "Ingresar Fecha De Nacimiento");
            }

            string[] date = textFechaDeNacimiento.Text.Split("/");
         

            DateTime Today = DateTime.Today;
            DateOnly UserDate = new DateOnly(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
            DateOnly LimitDate = DateOnly.FromDateTime(Today).AddYears(-110);
            if (UserDate < LimitDate)
            {
                validado = false;
                errorProvider1.SetError(textFechaDeNacimiento, "La fecha de nacimiento no puede ser anterior a " + LimitDate.ToShortDateString());
                reset();
            } else
            {
                Query = "INSERT INTO patients (ID,Nombre,Apellido,Cédula,FechaDeNacimiento,Edad,Dirección,Telefono,Sexo) VALUES (@ID,@Nombre,@Apellido,@Cédula,@FechaDeNacimiento,@Edad,@Dirección,@Telefono,@Sexo)";
                Operation = new Microsoft.Data.SqlClient.SqlCommand(Query, Program.connection);

                Age = Today.Year - UserDate.Year;

                if (Today.Month < UserDate.Month || (Today.Month == UserDate.Month && Today.Day < UserDate.Day)) Age--;

                Operation.Parameters.AddWithValue("@Edad", value: Age);
            }

            if (textDirección.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textDirección, "Ingresar Dirección");
            }

            if (textTelefono.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textTelefono, "Ingresar Teléfono");
            }

            if (comboBoxSexo.Text == "")
            {
                validado = false;
                errorProvider1.SetError(comboBoxSexo, "Ingresar Sexo");
            }

            return validado;
        }

        private void MensajeBorrar()
        {
            errorProvider1.SetError(textNombre, "");
            errorProvider1.SetError(textApellido, "");
            errorProvider1.SetError(textCédula, "");
            errorProvider1.SetError(textFechaDeNacimiento, "");
            errorProvider1.SetError(textDirección, "");
            errorProvider1.SetError(textTelefono, "");
            errorProvider1.SetError(comboBoxSexo, "");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Datagr(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("CURRENT ROW:", dtGridViewpatients.CurrentRow);
                Text = dtGridViewpatients.CurrentRow.Cells[0].Value.ToString();
                textNombre.Text = dtGridViewpatients.CurrentRow.Cells[1].Value.ToString();
                textApellido.Text = dtGridViewpatients.CurrentRow.Cells[2].Value.ToString();
                textCédula.Text = dtGridViewpatients.CurrentRow.Cells[3].Value.ToString();
                textFechaDeNacimiento.Text = dtGridViewpatients.CurrentRow.Cells[4].Value.ToString().Split(" ")[0].Trim();
                textDirección.Text = dtGridViewpatients.CurrentRow.Cells[6].Value.ToString();
                textTelefono.Text = dtGridViewpatients.CurrentRow.Cells[7].Value.ToString();
                comboBoxSexo.Text = dtGridViewpatients.CurrentRow.Cells[8].Value.ToString();
            }
            catch (Exception Error)
            {
                System.Diagnostics.Debug.WriteLine(Error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Query = "UPDATE patients SET Nombre=@Nombre,Apellido=@Apellido,Cédula=@Cédula,FechaDeNacimiento=@FechaDeNacimiento,Edad=@Edad,Dirección=@Dirección,Telefono=@Telefono,Sexo=@Sexo WHERE Id=@Id";
            Operation = new Microsoft.Data.SqlClient.SqlCommand(Query, Program.connection);

            Operation.Parameters.AddWithValue("@Id", Text);
            Operation.Parameters.AddWithValue("@Nombre", textNombre.Text);
            Operation.Parameters.AddWithValue("@Apellido", textApellido.Text);
            Operation.Parameters.AddWithValue("@Cédula", textCédula.Text);
            Operation.Parameters.AddWithValue("@FechaDeNacimiento", textFechaDeNacimiento.Text);
            Operation.Parameters.AddWithValue("@Dirección", textDirección.Text);
            Operation.Parameters.AddWithValue("@Telefono", textTelefono.Text);
            Operation.Parameters.AddWithValue("@Edad", Age);
            Operation.Parameters.AddWithValue("@Sexo", value: comboBoxSexo.Text);

            Operation.ExecuteNonQuery();

            MessageBox.Show("Los Datos Se Modificaron Correctamente");

            dtGridViewpatients.DataSource = Index();
            reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Eliminar = "DELETE FROM patients WHERE Id=@Id";
            Microsoft.Data.SqlClient.SqlCommand Borrar = new Microsoft.Data.SqlClient.SqlCommand(Eliminar, Program.connection);

            Borrar.Parameters.AddWithValue("@Id", Text);

            Borrar.ExecuteNonQuery();
            MessageBox.Show("Paciente Eliminado Correctamente");

            dtGridViewpatients.DataSource = Index();
            reset();
        }

        private void textFechaDeNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textCédula_Validating(object sender, CancelEventArgs e)
        {
            // Verifica si el campo está vacío 
            if (string.IsNullOrWhiteSpace(textCédula.Text))
            {
                errorProvider1.SetError(textCédula, ""); // Limpia el mensaje de error si está vacío
                return; // Sale de la validación sin hacer más comprobaciones
            }

            // Verifica si el texto es un número entero válido (solo si el campo no está vacío)
            if (!int.TryParse(textCédula.Text, out int num))
            {
                errorProvider1.SetError(textCédula, "Ingrese un valor numérico entero."); // Muestra el error

            }
            else
            {
                errorProvider1.SetError(textCédula, ""); // Limpia el mensaje de error si es válido
            }
        }

        private void textTelefono_Validating(object sender, CancelEventArgs e)
        {
            // Verifica si el campo está vacío
            if (string.IsNullOrWhiteSpace(textTelefono.Text))
            {
                errorProvider1.SetError(textTelefono, ""); // Limpia el mensaje de error si está vacío
                return; // Sale de la validación sin hacer más comprobaciones
            }

            // Verifica si el texto es un número entero válido (BIGINT)
            if (!long.TryParse(textTelefono.Text, out long num))
            {
                errorProvider1.SetError(textTelefono, "Ingrese un valor numérico"); // Muestra el error
            }
            else
            {
                errorProvider1.SetError(textTelefono, ""); // Limpia el mensaje de error si es válido
            }
        }

        private void textFechaDeNacimiento_Validating(object sender, CancelEventArgs e)
        {
            DateOnly fecha;

            if (!DateOnly.TryParse(textFechaDeNacimiento.Text, out fecha))
            {
                errorProvider1.SetError(textFechaDeNacimiento, "El formato debe Ser tipo fecha");
            }
            else
            {
                errorProvider1.SetError(textFechaDeNacimiento, "");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEdad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
