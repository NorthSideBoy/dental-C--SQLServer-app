using dental_C__SQLServer_app.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_C__SQLServer_app
{
    public partial class SecurityQuestions : Form
    {
        public SecurityQuestions()
        {
            InitializeComponent();
        }

        
        private void SecurityQuestions_Load(object sender, EventArgs e)
        {
            // Obtener las preguntas predefinidas
            List<string> preguntas = SecurityQ.GetPredefinedSecurityQuestions();

            // Asignar las preguntas a un ComboBox o mostrarlas en Labels
            comboxPregunta1.DataSource = new List<string>(preguntas);
            comboxPregunta2.DataSource = new List<string>(preguntas);
            comboxPregunta3.DataSource = new List<string>(preguntas);
        }

        private void btnGuardarQ_Click(object sender, EventArgs e)
        {
            int userID = 123; // ID del usuario actual
            string[] preguntas = new string[]
            {
        comboxPregunta1.SelectedItem.ToString(),
        comboxPregunta2.SelectedItem.ToString(),
        comboxPregunta3.SelectedItem.ToString()
            };

            string[] respuestas = new string[]
            {
        txtRespuesta1.Text,
        txtRespuesta2.Text,
        txtRespuesta3.Text
            };

            try
            {
                // Guardar las preguntas y respuestas en la base de datos
                SecurityQ.SaveSecurityQuestions(userID, preguntas, respuestas);
                MessageBox.Show("Preguntas de seguridad guardadas correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int userID = 123; // ID del usuario actual
            string[] respuestasProporcionadas = new string[]
            {
        txtRespuesta1.Text,
        txtRespuesta2.Text,
        txtRespuesta3.Text
            };

            // Verificar las respuestas
            bool esValido = SecurityQ.VerifySecurityAnswers(userID, respuestasProporcionadas);

            if (esValido)
            {
                MessageBox.Show("Respuestas correctas. Puedes continuar.");
            }
            else
            {
                MessageBox.Show("Respuestas incorrectas. Intenta nuevamente.");
            }
        }
    }
}
