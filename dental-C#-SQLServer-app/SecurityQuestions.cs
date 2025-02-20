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



        private void btnGuardarQ_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (comboxPregunta1.SelectedItem == null || comboxPregunta2.SelectedItem == null || comboxPregunta3.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtRespuesta1.Text) || string.IsNullOrWhiteSpace(txtRespuesta2.Text) || string.IsNullOrWhiteSpace(txtRespuesta3.Text))
                {
                    MessageBox.Show("Por favor, complete todas las preguntas y respuestas.");
                    return;
                }

                // Obtener las preguntas y respuestas
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

                // Obtener el userID dinámicamente
                int userID = GetCurrentUserId(); // Implementa este método para obtener el ID del usuario actual

                // Guardar las preguntas y respuestas en la base de datos
                SecurityQ.SaveSecurityQuestions(userID, preguntas, respuestas);

                MessageBox.Show("Preguntas de seguridad guardadas correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar las preguntas de seguridad: " + ex.Message);
            }
        }

        private int GetCurrentUserId()
        {
            throw new NotImplementedException();
        }
    }
}