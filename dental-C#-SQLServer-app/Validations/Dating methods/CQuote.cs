using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
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

        public void InsertarCita(string ID_Patients, string nombre, string apellido,string Motivo, string Fecha,string Hora, string ID)
        {
            Guid guid = Guid.NewGuid();
            string hexValue = guid.ToString("N");

            string Sql = "INSERT INTO Quote_Patients (ID_Patients, Nombre, Apellido,Motivo,Fecha,Hora,ID) VALUES (@ID_Patients, @Nombre, @Apellido,@Motivo,@Fecha,@Hora,@ID)";
            using (SqlCommand CMD = new SqlCommand(Sql, Program.connection))
            {
                CMD.Parameters.AddWithValue("@ID_Patients", ID_Patients);
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
        public string Seleccionar(DataGridView dataGridView1, TextBox textBoxID_Patients, TextBox textBoxNombre, TextBox textBoxApellido, TextBox textBoxMotivo, TextBox textBoxFecha, TextBox textBoxHora)
        {
            try
            {
                // Validar que se haya seleccionado una fila válida
                if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
                {
                    // Asignar los valores de las celdas a los TextBox
                    textBoxID_Patients.Text = dataGridView1.CurrentRow.Cells["ID_Patients"].Value?.ToString() ?? string.Empty;
                    textBoxNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value?.ToString() ?? string.Empty;
                    textBoxApellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value?.ToString() ?? string.Empty;
                    textBoxMotivo.Text = dataGridView1.CurrentRow.Cells["Motivo"].Value?.ToString() ?? string.Empty;
                    textBoxFecha.Text = dataGridView1.CurrentRow.Cells["Fecha"].Value?.ToString() ?? string.Empty;
                    textBoxHora.Text = dataGridView1.CurrentRow.Cells["Hora"].Value?.ToString() ?? string.Empty;

                    // Devolver el ID seleccionado
                    return dataGridView1.CurrentRow.Cells["ID"].Value?.ToString() ?? string.Empty;
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("No se ha seleccionado una fila válida.");
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error al seleccionar la fila: {ex.Message}");
                MessageBox.Show($"Error al seleccionar la fila: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        public void Modificar(TextBox textBoxID_Patients, TextBox textBoxMotivo, TextBox textBoxFecha, TextBox textBoxHora)
        {
            try
            {
                // Definir la consulta SQL para actualizar solo Motivo, Fecha y Hora
                string modificar = @"
            UPDATE Quote_Patients 
            SET 
                Motivo = @Motivo, 
                Fecha = @Fecha, 
                Hora = @Hora 
            WHERE 
                ID_Patients = @ID_Patients"; // Asegúrate de usar la cláusula WHERE para actualizar solo el registro correcto

                // Crear el comando SQL
                using (Microsoft.Data.SqlClient.SqlCommand cambios = new Microsoft.Data.SqlClient.SqlCommand(modificar, Program.connection))
                {
                    // Abrir la conexión si no está abierta
                    if (Program.connection.State != ConnectionState.Open)
                    {
                        Program.connection.Open();
                    }

                    // Asignar los valores de los TextBox a los parámetros del comando
                    cambios.Parameters.AddWithValue("@ID_Patients", textBoxID_Patients.Text); // Usar .Text para obtener el valor del TextBox
                    cambios.Parameters.AddWithValue("@Motivo", textBoxMotivo.Text);
                    cambios.Parameters.AddWithValue("@Fecha", textBoxFecha.Text);
                    cambios.Parameters.AddWithValue("@Hora", textBoxHora.Text);

                    // Ejecutar la consulta
                    int filasAfectadas = cambios.ExecuteNonQuery();

                    // Verificar si se realizó la actualización correctamente
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Los datos se modificaron correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Error al modificar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (Program.connection.State == ConnectionState.Open)
                {
                    Program.connection.Close();
                }
            }
        }

        public void EliminarCita(string idCita)
        {
            try
            {
                // Definir la consulta SQL para eliminar la cita
                string sql = "DELETE FROM Quote_Patients WHERE ID = @ID";

                // Crear el comando SQL
                using (SqlCommand cmd = new SqlCommand(sql, Program.connection))
                {
                    // Asignar el valor del parámetro @ID
                    cmd.Parameters.AddWithValue("@ID", idCita);

                    // Abrir la conexión si no está abierta
                    if (Program.connection.State != ConnectionState.Open)
                    {
                        Program.connection.Open();
                    }

                    // Ejecutar la consulta
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    // Verificar si se eliminó la cita correctamente
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("La cita se eliminó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la cita para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Error al eliminar la cita: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (Program.connection.State == ConnectionState.Open)
                {
                    Program.connection.Close();
                }
            }
        }
    }
}
