using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dental_C__SQLServer_app.Validations
{
    internal class CamposValidacion
    {
        public bool ValidarNombreUsuario(string txtNusuario)
        {
            if (string.IsNullOrWhiteSpace(txtNusuario))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.");
                return false;
            }

             return !string.IsNullOrWhiteSpace(txtNusuario) && txtNusuario.Length >= 3;
            {
                MessageBox.Show("El nombre de usuario debe tener entre 3 y 20 caracteres.");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNusuario, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("El nombre de usuario solo puede contener letras y números.");
                return false;
            }

            return true;
        }
    }
}
