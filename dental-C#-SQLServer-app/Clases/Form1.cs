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

        private void button1_Click(object sender, EventArgs e)
        {
            CConexion.Conectar();

            string Guardar = "INSERT INTO pacientes (Nombre,Apellido,Cédula,FechaDeNacimiento,Dirección,Edad,Telefono,Sexo) VALUES (@Nombre,@Apellido,@Cédula,@FechaDeNacimiento,@Dirección,@Edad,@Telefono,@Sexo)";
            SqlCommand insert = new SqlCommand(Guardar, CConexion.Conectar());
            insert.Parameters.AddWithValue("@Nombre", textNombre.Text);
            insert.Parameters.AddWithValue("@Apellido", textApellido.Text);
            insert.Parameters.AddWithValue("@Cédula", textCédula.Text);
            insert.Parameters.AddWithValue("@FechaDeNacimiento", textFechaDeNacimiento.Text);
            insert.Parameters.AddWithValue("@Dirección", textDirección.Text);
            insert.Parameters.AddWithValue("@Edad", textEdad.Text);
            insert.Parameters.AddWithValue("@Telefono", textTelefono.Text);
            insert.Parameters.AddWithValue("@Sexo", textSexo.Text);

            insert.ExecuteNonQuery();

            MessageBox.Show("Los Datos Fueron Guardados Correctamente");

            dtGridViewpacientes.DataSource = Index();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
