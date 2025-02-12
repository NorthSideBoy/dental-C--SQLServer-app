using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using TextBox = System.Windows.Forms.TextBox;

namespace dental_C__SQLServer_app.Validations.Dating_methods
{
    internal class CQuote
    {
        public DataTable Cita()
        {
            DataTable dataTable = new DataTable();
            string Sql = "SELECT * FROM Quote_Patients";
            Microsoft.Data.SqlClient.SqlCommand CMD = new Microsoft.Data.SqlClient.SqlCommand(Sql, Program.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);

            adapter.Fill(dataTable);
            return dataTable;
        }

        public void InsertarCita(string ID_Patient, string nombre, string apellido,string Motivo,String Fecha,string Hora, string ID)
        {
            Guid guid = Guid.NewGuid();
            string hexValue = guid.ToString("N");

            string Sql = "INSERT INTO Quote_Patients (ID_Patients, Nombre, Apellido,Motivo,Fecha,Hora,ID) VALUES (@ID_Patient, @Nombre, @Apellido,@Motivo,@Fecha,@Hora,@ID)";
            using (SqlCommand CMD = new SqlCommand(Sql, Program.connection))
            {
                CMD.Parameters.AddWithValue("@ID_Patient", ID_Patient);
                CMD.Parameters.AddWithValue("@Nombre", nombre);
                CMD.Parameters.AddWithValue("@Apellido", apellido);
                CMD.Parameters.AddWithValue("@Motivo", Motivo);
                CMD.Parameters.AddWithValue("@Fecha", Fecha);
                CMD.Parameters.AddWithValue("@Hora", Hora);
                CMD.Parameters.AddWithValue("@ID", hexValue);


                // Abrir la conexión si no está abierta
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                // Ejecutar la consulta
                CMD.ExecuteNonQuery();

                // Cerrar la conexión
                Program.connection.Close();
            }
        }
        public void Seleccionar(DataGridView dataGridView1, TextBox textBoxID_Pacients, TextBox textBoxNombre, TextBox textBoxApellido, TextBox textBoxMotivo, TextBox textBoxFecha, TextBox textBoxHora)

        {
            try
            {
                // Validar que el DataGridView no esté vacío y que se haya seleccionado una fila válida
                if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
                {
                    // Asignar los valores de las celdas a los TextBox
                    textBoxID_Pacients.Text = dataGridView1.CurrentRow.Cells["ID_Pacients"].Value?.ToString() ?? string.Empty;
                    textBoxNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                    textBoxApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value?.ToString() ?? string.Empty;
                    textBoxMotivo.Text = dataGridView1.CurrentRow.Cells["Motivo"].Value?.ToString() ?? string.Empty;
                    textBoxFecha.Text = dataGridView1.CurrentRow.Cells["Fecha"].Value?.ToString() ?? string.Empty;
                    textBoxHora.Text = dataGridView1.CurrentRow.Cells["Hora"].Value?.ToString() ?? string.Empty;
                 
                    string ID = dataGridView1.CurrentRow.Cells["ID"].Value?.ToString() ?? string.Empty;

                }     
                else
                {
                    // Mostrar un mensaje de depuración si no se selecciona una fila válida
                    System.Diagnostics.Debug.WriteLine("No se ha seleccionado una fila válida.");
                }
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error más descriptivo
                System.Diagnostics.Debug.WriteLine($"Error al seleccionar la fila: {ex.Message}");
                MessageBox.Show($"Error al seleccionar la fila: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void Seleccionar(DataGridView dataGridView1, TextBox textBoxID_Pacients, TextBox textBoxNombre, TextBox textBoxApellido, TextBox textBoxMotivo, TextBox textBoxFecha, TextBox textBoxHora, object textBoxID)
        {
            throw new NotImplementedException();
        }
    }
}
