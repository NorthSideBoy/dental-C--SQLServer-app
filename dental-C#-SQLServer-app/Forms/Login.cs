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
            string sql = "SELECT COUNT(*) FROM newUser WHERE txtuser = @username AND txtpass = @password";

            using (Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, Program.connection))
            {

                // parámetros
                cmd.Parameters.AddWithValue("@username", txtuser);
                cmd.Parameters.AddWithValue("@password", txtpass);

                try
                {
                    Program.connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(text: "Verifique el Usuario y la Contraseña");
                }
                finally
                {
                    if (Program.connection.State == ConnectionState.Open)
                    {
                        Program.connection.Close();
                    }
                }
                Program.connection.Open();
                int count = (int)cmd.ExecuteScalar();
                Program.connection.Close();

                // Si el conteo es mayor que 0, el usuario existe
                isAuthenticated = count > 0;

                MessageBox.Show(text: "si existe este usuario");
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
            //Condicion para vaciar el texto de contraseña, e ingresar una contraseña
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true; //Ocultar contraseña
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            //Para que se vuelva a visualizar el texto
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
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
            //Mostrar y ocultar la contraseña que se ha ingresado
            txtpass.UseSystemPasswordChar = !txtpass.UseSystemPasswordChar;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register re = new Register();
            re.Show();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text; 
            string password = txtpass.Text; 

            // Llamar al método de autenticación
            bool isAuthenticated = AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Acceso concedido. Bienvenido!");
                // Aquí puedes redirigir al usuario a la siguiente pantalla o formulario
                Welcome re = new Welcome();
                re.Show();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Inténtalo de nuevo.");
            }
        }
    }
}
