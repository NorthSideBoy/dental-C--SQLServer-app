using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace dental_C__SQLServer_app.Forms.habits_methods
{
    class CHabits
    {
        public DataTable Habits()
        {
            DataTable dataTable = new DataTable();
            string Sql = "SELECT * FROM habits";
            Microsoft.Data.SqlClient.SqlCommand CMD = new Microsoft.Data.SqlClient.SqlCommand(Sql, Program.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);

            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable Antecedents()
        {
            DataTable dataTable = new DataTable();
            string Sql = "SELECT * FROM antecedents";
            Microsoft.Data.SqlClient.SqlCommand CMD = new Microsoft.Data.SqlClient.SqlCommand(Sql, Program.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);

            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable CargarCombo()
        {
            DataTable da = new DataTable();
            string Sql = "SELECT PatientID, Nombre + ' ' + Apellido AS NombreCompleto FROM patients"; // Asegúrate de que la tabla y columnas existan
            using (SqlCommand CMD = new SqlCommand(Sql, Program.connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(CMD);
                adapter.Fill(da);
            }
            return da;


        }

        public void GuardarHabits(string HabitsID, string NombreH, string Cepillado, string PatientID)
        {
            Guid guid = Guid.NewGuid();
            string hexValue = guid.ToString("N");

            string Sql = "INSERT INTO habits (HabitsID,NombreH,Cepillado,PatientID) VALUES (@HabitsID, @NombreH, @Cepillado,@PatientID)";
            using (SqlCommand CMD = new SqlCommand(Sql, Program.connection))
            {
                CMD.Parameters.AddWithValue("@HabitsID", hexValue);
                CMD.Parameters.AddWithValue("@NombreH", NombreH);
                CMD.Parameters.AddWithValue("@Cepillado", Cepillado);
                

                CMD.Parameters.AddWithValue("@PatientID", PatientID);


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

        public void GuardarAntecedents(string AntecedentsID, string Hemorrágicos , string Personales,string Familiares, string PatientID)
        {
            Guid guid = Guid.NewGuid();
            string hexValue = guid.ToString("N");

            string Sql = "INSERT INTO antecedents (AntecedentsID, Hemorrágicos ,  Personales, Familiares,PatientID) VALUES (@AntecedentsID, @Hemorrágicos , @Personales, @Familiares,@PatientID)";
            using (SqlCommand CMD = new SqlCommand(Sql, Program.connection))
            {
                CMD.Parameters.AddWithValue("@AntecedentsID", hexValue);
                CMD.Parameters.AddWithValue("@Hemorrágicos", Hemorrágicos);
                CMD.Parameters.AddWithValue("@Personales", Personales);
                CMD.Parameters.AddWithValue("@Familiares", Familiares);


                CMD.Parameters.AddWithValue("@PatientID", PatientID);


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

    }
}
