using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDCSharpSQLServer.Clases
{
    internal class CConexion
    {
        SqlConnection conex = new SqlConnection();

        static string servidor = "localhost";
        static string bd = "colegioDB";
        static string usuario = "root3";
        static string clave = "root3";
        static string puerto = "1433";

        String cadenaConexion = "Data Source=" + servidor + "," + puerto + ";" + "user id=" + usuario + ";" + "password=" + clave + ";" + "Initial Catalog=" + bd + ";" + "Persist Security info = true";

        public SqlConnection establecerConexion()
        {

            try
            {

                conex.ConnectionString = cadenaConexion;
                conex.Open();
                //MessageBox.Show("Se conecto correctamente a la Base de Datos");

            }

            catch (Exception ex)
            {

                MessageBox.Show("No se conecto correctamente a la Base de Datos, error: " + ex.ToString());
            }

            return conex;

        }

        public void CerrarConexion()
        {
            conex.Close();
        }

    }
}