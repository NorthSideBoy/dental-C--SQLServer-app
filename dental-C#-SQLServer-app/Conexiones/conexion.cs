using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_C__SQLServer_app.Conexiones
{
    internal class conexion
    {
        SqlConnection conex = new SqlConnection ();

        static string servidor = "localhost";
        static string bd = "OdontoPrueba";
        static string usuario = "tina";
        static string contrasenia = "tina";
        static string puerto = "1433";

        string cadenaConexion = "Data Source=" + servidor + ";" + puerto + ";" + "user id=" + usuario + ";" + "Password=" + contrasenia + ";" + "Initial Catalog=" + bd + ";" + "Persist Securty info = true";
        
        public SqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open ();
                MessageBox.Show("Se conecto correctamente la Base de Datos");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se conecto la Base de Datos, error: " + ex.ToString());
            }
            return conex;
        }

        public void cerrarConexion()
        {
            conex.Close();
        }
    }
}
