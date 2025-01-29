using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_C__SQLServer_app.Clases
{
    class CConexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-3AHEOID\\SQLEXPRESS; database=Consultorio; Trusted_Connection=true;");
            conexion.Open();    
            return conexion;
        }
    }
}
