using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dental_C__SQLServer_app.Validations
{
    public class CamposValidacion
    {
        // Método para validar el nombre de usuario
        public bool ValidarNombreUsuario(string txtNusuario)
        {
            if (string.IsNullOrWhiteSpace(txtNusuario))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío.");
                return false;
            }

            if (txtNusuario.Length > 60)
            {
                MessageBox.Show("El nombre de usuario no puede tener más de 60 caracteres.");
                return false;
            }

            if (!Regex.IsMatch(txtNusuario, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El nombre de usuario solo puede contener letras.");
                return false;
            }

            return true;
        }

        // Método para validar la cédula
        public bool ValidarCedula(string txtCedula)
        {
            if (string.IsNullOrWhiteSpace(txtCedula))
            {
                MessageBox.Show("La cédula no puede estar vacía.");
                return false;
            }

            if (!Regex.IsMatch(txtCedula, @"^\d{8}$"))
            {
                MessageBox.Show("La cédula debe contener exactamente 8 dígitos.");
                return false;
            }

            int cedula = int.Parse(txtCedula);
            if (cedula < 5338458)
            {
                MessageBox.Show("La cédula debe ser mayor o igual a 5338458.");
                return false;
            }

            return true;
        }

        // Método para validar el teléfono
        public bool ValidarTelefono(string comboxTlf)
        {
            if (string.IsNullOrWhiteSpace(comboxTlf))
            {
                MessageBox.Show("El teléfono no puede estar vacío.");
                return false;
            }

            if (!Regex.IsMatch(comboxTlf, @"^\d{11}$"))
            {
                MessageBox.Show("El teléfono debe contener exactamente 11 dígitos.");
                return false;
            }

            return true;
        }
        public bool ValidarContrasena(string txtContrasena)
        {
            if (string.IsNullOrWhiteSpace(txtContrasena))
            {
                MessageBox.Show("La contraseña no puede estar vacía.");
                return false;
            }

            if (txtContrasena.Length < 4 || txtContrasena.Length > 8)
            {
                MessageBox.Show("La contraseña debe tener entre 4 y 8 caracteres.");
                return false;
            }

            return true;
        }
        // Método para validar el rol
        public bool ValidarRol(string comboxRol)
        {
            if (string.IsNullOrWhiteSpace(comboxRol))
            {
                MessageBox.Show("El rol no puede estar vacío.");
                return false;
            }

            if (comboxRol.Length > 8)
            {
                MessageBox.Show("El rol no puede tener más de 8 caracteres.");
                return false;
            }

            if (!Regex.IsMatch(comboxRol, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El rol solo puede contener letras.");
                return false;
            }
            return true;
        }
        public bool ValidarUsuario(string txtuser)
        {
            if (string.IsNullOrWhiteSpace(txtuser))
            {
                MessageBox.Show("El campo usuario no puede estar vacío.");
                return false;
            }

            if (txtuser.Length > 60)
            {
                MessageBox.Show("El campo usuario no puede tener más de 60 caracteres.");
                return false;
            }

            if (!Regex.IsMatch(txtuser, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El campo usuario solo puede contener letras.");
                return false;
            }

            return true;
        }
        public bool ValidarPass(string txtpass)
        {
            if (string.IsNullOrWhiteSpace(txtpass))
            {
                MessageBox.Show("La contraseña no puede estar vacía.");
                return false;
            }

            if (txtpass.Length < 4 || txtpass.Length > 8)
            {
                MessageBox.Show("La contraseña debe tener entre 4 y 8 caracteres.");
                return false;
            }

            return true;
        }

    }
}