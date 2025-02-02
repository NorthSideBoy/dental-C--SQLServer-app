using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dental_C__SQLServer_app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text == txtConfirmar.Text)
            {
                if (UsuarioDAL.CrearCuentas(txtNusuario.Text, txtContrasena.Text) > 0)
                {
                    MessageBox.Show("Cuenta Creada con Exito");
                }
                else
                {
                    MessageBox.Show("No se pudo crear la cuenta");
                }
            }

        }

        private void txtNusuario_Enter(object sender, EventArgs e)
        {
            if (txtNusuario.Text == "Nombre de Usuario")
            {
                txtNusuario.Clear();
                txtNusuario.ForeColor = Color.Black;
            }
        }

        private void txtNusuario_Leave(object sender, EventArgs e)
        {
            if (txtNusuario.Text == "")
            {
                txtNusuario.Text = "Nombre de Usuario";
                txtNusuario.ForeColor = Color.Black;
            }
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "Contraseña")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.UseSystemPasswordChar = true; //Ocultar contraseña
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "Contraseña";
                txtContrasena.ForeColor = Color.Black;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmar_Enter(object sender, EventArgs e)
        {
            if (txtConfirmar.Text == "Confirmar Contraseña")
            {
                txtConfirmar.Text = "";
                txtConfirmar.ForeColor = Color.Black;
                txtConfirmar.UseSystemPasswordChar = true; //Ocultar contraseña
            }
        }

        private void txtConfirmar_Leave(object sender, EventArgs e)
        {
            if (txtConfirmar.Text == "")
            {
                txtConfirmar.Text = "Confirmar Contraseña";
                txtConfirmar.ForeColor = Color.Black;
                txtConfirmar.UseSystemPasswordChar = false;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "Correo")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black;
                txtCorreo.UseSystemPasswordChar = true; //Ocultar contraseña
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "Correo";
                txtCorreo.ForeColor = Color.Black;
                txtCorreo.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtNusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
