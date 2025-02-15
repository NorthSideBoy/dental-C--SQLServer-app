using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
using dental_C__SQLServer_app.Classes;//Para conectar con la database lol

namespace dental_C__SQLServer_app
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }

        public bool AuthenticateUser(string txtuser, string txtpass)
        {
            bool isAuthenticated = false;
            string sql = "SELECT pass FROM newUser WHERE userName = @username"; // Obtener el hash almacenado

            using (Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, Program.connection))
            {
                // Par�metros
                cmd.Parameters.AddWithValue("@username", txtuser);

                try
                {
                    Program.connection.Open();
                    string hashedPasswordFromDB = cmd.ExecuteScalar()?.ToString(); // Obtener el hash de la base de datos

                    if (hashedPasswordFromDB != null)
                    {
                        // Verificar si la contrase�a coincide con el hash
                        isAuthenticated = BCrypt.Net.BCrypt.Verify(txtpass, hashedPasswordFromDB);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    if (Program.connection.State == ConnectionState.Open)
                    {
                        Program.connection.Close();
                    }
                }
            }

            return isAuthenticated;
        }
        private void txtuser_Enter(object sender, EventArgs e)
        {
            //Condicion para vaciar el texto de usuario, para ingresar un nombre
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            //Para que se vuelva a visualizar el texto:Usuario
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            //Condicion para vaciar el texto de contrase�a, e ingresar una contrase�a
            if (txtpass.Text == "CONTRASE�A")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true; //Ocultar contrase�a
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            //Para que se vuelva a visualizar el texto
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASE�A";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = false;
            }

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnexpandir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnmostrar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            //Mostrar y ocultar la contrase�a que se ha ingresado
            txtpass.UseSystemPasswordChar = !txtpass.UseSystemPasswordChar;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register re = new Register();
            re.Show();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpass.Text;

            try
            {
                // Verificar que los campos no est�n vac�os
                if (string.IsNullOrEmpty(txtuser.Text) || string.IsNullOrEmpty(txtpass.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Llamar al m�todo de autenticaci�n
                bool isAuthenticated = AuthenticateUser(username, password);

                if (isAuthenticated)
                {
                    MessageBox.Show("Acceso concedido. Bienvenido!");
                    // Aqu� puedes redirigir al usuario a la siguiente pantalla o formulario
                    Welcome re = new Welcome();
                    re.Show();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contrase�a incorrectos. Int�ntalo de nuevo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool ValidarCampos()
        {
            // Implementar la validaci�n de campos si es necesario
            return true; // Por ahora, siempre retorna true
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SowUser re = new SowUser();
            re.Show();
        }
    }
}