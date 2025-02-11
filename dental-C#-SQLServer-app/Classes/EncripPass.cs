using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace dental_C__SQLServer_app.Classes
{
    internal class EncripPass
    {
        public static string HashPassword(string password)
        {
            // Crear un objeto SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convertir la contraseña a un arreglo de bytes y calcular el hash
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convertir el arreglo de bytes a una cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
