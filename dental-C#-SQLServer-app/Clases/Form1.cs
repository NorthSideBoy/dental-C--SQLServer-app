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

namespace dental_C__SQLServer_app.Clases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CConexion.Conectar();
            dtGridViewpacientes.DataSource = Index();
        }

        public DataTable Index()
        {
            DataTable dataTable = new DataTable();
            string Sql = "SELECT * FROM pacientes";
            SqlCommand CMD = new SqlCommand(Sql, CConexion.Conectar());
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
            textEdad.Text = "";
            textTelefono.Text = "";
            comboBoxSexo.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CConexion.Conectar();
            MensajeBorrar();
            if (validarcampos())
            {



                string Guardar = "INSERT INTO pacientes (Nombre,Apellido,Cédula,FechaDeNacimiento,Dirección,Edad,Telefono,Sexo) VALUES (@Nombre,@Apellido,@Cédula,@FechaDeNacimiento,@Dirección,@Edad,@Telefono,@Sexo)";
                SqlCommand insert = new SqlCommand(Guardar, CConexion.Conectar());

                insert.Parameters.AddWithValue("@Nombre", textNombre.Text);
                insert.Parameters.AddWithValue("@Apellido", textApellido.Text);
                insert.Parameters.AddWithValue("@Cédula", textCédula.Text);
                insert.Parameters.AddWithValue("@FechaDeNacimiento", textFechaDeNacimiento.Text);
                insert.Parameters.AddWithValue("@Dirección", textDirección.Text);
                insert.Parameters.AddWithValue("@Edad", textEdad.Text);
                insert.Parameters.AddWithValue("@Telefono", textTelefono.Text);
                insert.Parameters.AddWithValue("@Sexo", value: comboBoxSexo.Text);


                insert.ExecuteNonQuery();
                MessageBox.Show("Los Datos Fueron Guardados Correctamente");

                dtGridViewpacientes.DataSource = Index();
                reset();
            }





        }

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

            if (textDirección.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textDirección, "Ingresar Dirección");

            }

            if (textEdad.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textEdad, "Ingresar Edad");

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
            errorProvider1.SetError(textEdad, "");
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
                System.Diagnostics.Debug.WriteLine("CURRENT ROW:", dtGridViewpacientes.CurrentRow);
                Text = dtGridViewpacientes.CurrentRow.Cells[0].Value.ToString();
                textNombre.Text = dtGridViewpacientes.CurrentRow.Cells[1].Value.ToString();
                textApellido.Text = dtGridViewpacientes.CurrentRow.Cells[2].Value.ToString();
                textCédula.Text = dtGridViewpacientes.CurrentRow.Cells[3].Value.ToString();
                textFechaDeNacimiento.Text = dtGridViewpacientes.CurrentRow.Cells[4].Value.ToString();
                textDirección.Text = dtGridViewpacientes.CurrentRow.Cells[5].Value.ToString();
                textEdad.Text = dtGridViewpacientes.CurrentRow.Cells[6].Value.ToString();
                textTelefono.Text = dtGridViewpacientes.CurrentRow.Cells[7].Value.ToString();
                comboBoxSexo.Text = dtGridViewpacientes.CurrentRow.Cells[8].Value.ToString();
            }
            catch (Exception Error)
            {
                System.Diagnostics.Debug.WriteLine(Error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CConexion.Conectar();
            string modificar = "UPDATE pacientes SET Nombre=@Nombre,Apellido=@Apellido,Cédula=@Cédula,FechaDeNacimiento=@FechaDeNacimiento,Dirección=@Dirección,Edad=@Edad,Telefono=@Telefono,Sexo=@Sexo WHERE Id=@Id";
            SqlCommand cambios = new SqlCommand(modificar, CConexion.Conectar());

            cambios.Parameters.AddWithValue("@Id", Text);
            cambios.Parameters.AddWithValue("@Nombre", textNombre.Text);
            cambios.Parameters.AddWithValue("@Apellido", textApellido.Text);
            cambios.Parameters.AddWithValue("@Cédula", textCédula.Text);
            cambios.Parameters.AddWithValue("@FechaDeNacimiento", textFechaDeNacimiento.Text);
            cambios.Parameters.AddWithValue("@Dirección", textDirección.Text);
            cambios.Parameters.AddWithValue("@Edad", textEdad.Text);
            cambios.Parameters.AddWithValue("@Telefono", textTelefono.Text);
            cambios.Parameters.AddWithValue("@Sexo", value: comboBoxSexo.Text);

            cambios.ExecuteNonQuery();

            MessageBox.Show("Los Datos Se Modificaron Correctamente");

            dtGridViewpacientes.DataSource = Index();
            reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CConexion.Conectar();
            string Eliminar = "DELETE FROM pacientes WHERE Id=@Id";
            SqlCommand Borrar = new SqlCommand(Eliminar, CConexion.Conectar());

            Borrar.Parameters.AddWithValue("@Id", Text);

            Borrar.ExecuteNonQuery();
            MessageBox.Show("Paciente Eliminado Correctamente");

            dtGridViewpacientes.DataSource = Index();
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

        private void textEdad_Validating(object sender, CancelEventArgs e)
        {
            // Verifica si el campo está vacío 
            if (string.IsNullOrWhiteSpace(textEdad.Text))
            {
                errorProvider1.SetError(textEdad, ""); // Limpia el mensaje de error si está vacío
                return; // Sale de la validación sin hacer más comprobaciones
            }

            // Verifica si el texto es un número entero válido (solo si el campo no está vacío)
            if (!int.TryParse(textEdad.Text, out int num))
            {
                errorProvider1.SetError(textEdad, "Ingrese un valor numérico entero."); // Muestra el error

            }
            else
            {
                errorProvider1.SetError(textEdad, ""); // Limpia el mensaje de error si es válido
            }

        }

        private void textFechaDeNacimiento_Validating(object sender, CancelEventArgs e)
        {
            DateTime fecha;

            if (!DateTime.TryParse(textFechaDeNacimiento.Text, out fecha))
            {
                errorProvider1.SetError(textFechaDeNacimiento, "El Formato Debe Ser DD/MM/YYYY");
            }
            else
            {
                errorProvider1.SetError(textFechaDeNacimiento, "");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
