using System.Data;
using System.Data.SqlClient;
using dental_C__SQLServer_app.Clases;
using static System.Runtime.InteropServices.JavaScript.JSType;
using String = System.String;

namespace dental_C__SQLServer_app
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

        }
        public DataTable index()
        {
            DataTable dt = new DataTable();
            // Corregir la consulta SQL
            String sql = "SELECT * FROM pacientes"; // Cambié 'selec' a 'SELECT'

            using (SqlConnection connection = CConexion.Conectar()) // Usar 'using' para manejar la conexión
            {
                using (SqlCommand ct = new SqlCommand(sql, connection)) // Usar 'using' para el comando
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(ct);
                    adapter.Fill(dt); // Llenar el DataTable con los datos
                }
            }

            return dt; // Retornar el DataTable
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CConexion.Conectar();

            String Sql_insert = "insert into pacientes ( Nombre, Apellido, Cédula, FechaDeNacimiento, Dirección, Edad, Telefono, Sexo) values (@Nombre,@Apellido,@Cédula,@FechaDeNacimiento,@Dirección,@Edad,@Telefono,@Sexo)";
            SqlCommand comand1 = new SqlCommand(Sql_insert, CConexion.Conectar());

            comand1.Parameters.AddWithValue("@Nombre", textboxNombre.Text);
            comand1.Parameters.AddWithValue("@Apellido", textBoxApellido.Text);
            comand1.Parameters.AddWithValue("@Cédula", textBoxCédula.Text);
            comand1.Parameters.AddWithValue("@FechaDeNacimiento", textBoxFechaDeNacimiento.Text);
            comand1.Parameters.AddWithValue("@Dirección", textBoxDirección.Text);
            comand1.Parameters.AddWithValue("@Edad", textBoxEdad.Text);
            comand1.Parameters.AddWithValue("@Telefono", textBoxTelefono.Text);
            comand1.Parameters.AddWithValue("@Sexo", textBoxSexo.Text);

            comand1.ExecuteNonQuery();

            MessageBox.Show("Datos corresctamente insertados");
            dataGridView1.DataSource =  index;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
