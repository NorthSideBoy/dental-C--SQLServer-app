using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using Microsoft.Data.SqlClient;
using dental_C__SQLServer_app.Validations;
using dental_C__SQLServer_app.Classes;
using static dental_C__SQLServer_app.Classes.Encriptacion; //Para usar la BD sin crear conflicto.

namespace dental_C__SQLServer_app
{
    public partial class Register : Form
    {
        private string query;

        public Register()
        {
            InitializeComponent();
        }

        public DataTable Index()
        {
            DataTable dataTable = new DataTable();
            string Sql = "SELECT * FROM Register";
            Microsoft.Data.SqlClient.SqlCommand CMD = new Microsoft.Data.SqlClient.SqlCommand(Sql, Program.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);

            adapter.Fill(dataTable);
            return dataTable;
        }

        private void reset()
        {
            txtNusuario.Text = "";
            txtCedula.Text = "";
            txtCorreo.Text = "";
            comboxTlf.Text = "";
            txtContrasena.Text = "";
            txtConfirmar.Text = "";
            comboxRol.Text = "";
        }
        private void txtNusuario_Enter(object sender, EventArgs e)
        {
            if (txtNusuario.Text == "Nombre de Usuario")
            {
                txtNusuario.Clear();
                txtNusuario.ForeColor = Color.White;
            }
        }

        private void txtNusuario_Leave(object sender, EventArgs e)
        {
            if (txtNusuario.Text == "")
            {
                txtNusuario.Text = "Nombre de Usuario";
                txtNusuario.ForeColor = Color.White;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.White;
            }
            txtContrasena.UseSystemPasswordChar = true; //Ocultar contraseña
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.ForeColor = Color.White;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmar_Enter(object sender, EventArgs e)
        {
            if (txtConfirmar.Text == "Confirmar Contraseña")
            {
                txtConfirmar.Text = "";
                txtConfirmar.ForeColor = Color.White;
                txtConfirmar.UseSystemPasswordChar = true; //Ocultar contraseña
            }
        }

        private void txtConfirmar_Leave(object sender, EventArgs e)
        {
            if (txtConfirmar.Text == "")
            {
                txtConfirmar.Text = "Confirmar Contraseña";
                txtConfirmar.ForeColor = Color.White;
                txtConfirmar.UseSystemPasswordChar = false;
            }
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            if (txtCedula.Text == "Cedula de Identidad")
            {
                txtCedula.Text = "";
                txtCedula.ForeColor = Color.White;
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "Cedula de Identidad";
                txtCedula.ForeColor = Color.White;
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            UserPanel re = new UserPanel();
            re.Show();
        }

        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar al método de validación de campos
                if (!ValidarCampos())
                {
                    return; // Si las validaciones fallan, detener el proceso de registro
                }

                // Verificar que los campos no estén vacíos
                if (string.IsNullOrEmpty(txtNusuario.Text) || string.IsNullOrEmpty(txtCedula.Text) ||
                    string.IsNullOrEmpty(comboxTlf.Text) || string.IsNullOrEmpty(txtContrasena.Text) ||
                    string.IsNullOrEmpty(comboxRol.Text) || string.IsNullOrEmpty(txtCorreo.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Verificar que las contraseñas coincidan
                if (txtContrasena.Text != txtConfirmar.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                    return;
                }

                // Hashear la contraseña
                string hashedPassword = HashPassword(txtContrasena.Text);

                // Definir la consulta SQL
                string query = "INSERT INTO users (userName, Cedula, email, phone, pass, rol) VALUES (@userName, @cedula, @email, @phone, @pass, @rol)";

                // Abrir la conexión
                if (Program.connection.State != System.Data.ConnectionState.Open)
                {
                    Program.connection.Open();
                }

                // Ejecutar la consulta
                using (var cmd = new SqlCommand(query, Program.connection))
                {
                    cmd.Parameters.AddWithValue("@userName", txtNusuario.Text);
                    cmd.Parameters.AddWithValue("@cedula", txtCedula.Text);
                    cmd.Parameters.AddWithValue("@email", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@phone", comboxTlf.Text);
                    cmd.Parameters.AddWithValue("@pass", hashedPassword); // Usar el hash
                    cmd.Parameters.AddWithValue("@rol", comboxRol.Text);

                    // Ejecutar el comando
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Usuario registrado correctamente.");

                // Redirigir al formulario de preguntas de seguridad
                SecurityQuestions preguntasSeguridad = new SecurityQuestions();
                preguntasSeguridad.Show();

                // Opcional: Cerrar el formulario actual si no es necesario mantenerlo abierto
                this.Close();

                reset(); // Limpiar los campos del formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión en el bloque finally
                if (Program.connection.State == System.Data.ConnectionState.Open)
                {
                    Program.connection.Close();
                }
            }
        }

        // Método para validar los campos
        public bool ValidarCampos()
        {
            CamposValidacion validaciones = new CamposValidacion();

            if (!validaciones.ValidarNombreUsuario(txtNusuario.Text))
            {
                MessageBox.Show("Error en el nombre de usuario.");
                return false;
            }

            if (!validaciones.ValidarCedula(txtCedula.Text))
            {
                MessageBox.Show("Error en la cédula.");
                return false;
            }

            if (!validaciones.ValidarTelefono(comboxTlf.Text))
            {
                MessageBox.Show("Error en el teléfono.");
                return false;
            }

            if (!validaciones.ValidarRol(comboxRol.Text))
            {
                MessageBox.Show("Error en el rol.");
                return false;
            }

            if (!validaciones.ValidarContrasena(txtContrasena.Text))
            {
                MessageBox.Show("Error en la Contraseña.");
                return false;
            }
            return true; // Todas las validaciones pasaron

            if (!validaciones.ValidarCorreo(txtCorreo.Text))
            {
                MessageBox.Show("Error en la Correo.");
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login re = new Login();
            re.Show();
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.White;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
                txtCorreo.ForeColor = Color.White;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            SecurityQuestions re = new SecurityQuestions();
            re.Show();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}