using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_C__SQLServer_app.Forms
{
    public partial class Quote : Form
    {

            private string pacienteId; // Variable para almacenar el ID del paciente

            // Constructor que acepta el ID del paciente
            public Quote(string pacienteId)
            {
                InitializeComponent();
                this.pacienteId = pacienteId; // Almacena el ID del paciente
            }

            private void Quote_Load(object sender, EventArgs e)
            {
                // Asigna el ID del paciente al TextBox txtIdPaciente
                txtIdPaciente.Text = pacienteId;
            }
        

      
        
        public Quote()
        {
            InitializeComponent();
        }

        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

    internal class SeleccionarPacienteForm
    {
        internal string IdPacienteSeleccionado;

        internal DialogResult ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}
