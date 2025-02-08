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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace dental_C__SQLServer_app
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            //Clases.conexion ObjetConexion = new Clases.conexion();
            //ObjetConexion.establecerConexion();
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
            }
            txtContrasena.UseSystemPasswordChar = true; //Ocultar contraseña
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

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            if (txtCedula.Text == "Cedula de Identidad")
            {
                txtCedula.Text = "";
                txtCedula.ForeColor = Color.Black;
            }
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                txtCedula.Text = "Cedula de Identidad";
                txtCedula.ForeColor = Color.Black;
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            UserPanel re = new UserPanel();
            re.Show();
        }

        private void txtTelefonoUser_Enter(object sender, EventArgs e)
        {
            if (txtTelefonoUser.Text == "Telefono")
            {
                txtTelefonoUser.Text = "";
                txtTelefonoUser.ForeColor = Color.Black;
            }
        }

        private void txtTelefonoUser_Leave(object sender, EventArgs e)
        {
            if (txtTelefonoUser.Text == "")
            {
                txtTelefonoUser.Text = "Telefono";
                txtTelefonoUser.ForeColor = Color.Black;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void txtNusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
