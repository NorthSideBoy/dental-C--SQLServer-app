using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dental_C__SQLServer_app
{
    internal class UsuarioDAL
    {
        public static int CrearCuentas(string pUsuario, string pContraseña)
        {
            int resultado = 0;
            //SqlConnection Conn = BDComun.ObtnerCOnexion();

            //SqlCommand Comando = new SqlCommand(string.Format("Insert Into Usuario (Nombre, Contrasena) values ('{0}', PwdEncrypt ('{1}') )", pUsuario, pContraseña), Conn); //para encriptar la contrasña

            //resultado = Comando.ExecuteNonQuery();
            //Conn.Close();

            return resultado;

        }
    }
}
