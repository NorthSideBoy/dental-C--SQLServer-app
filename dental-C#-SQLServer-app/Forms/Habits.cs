using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dental_C__SQLServer_app.Forms.habits_methods;
using dental_C__SQLServer_app.Validations.Dating_methods;

namespace dental_C__SQLServer_app.Forms
{
    public partial class Habits : Form
    {
        public Habits()
        {
            InitializeComponent();
        }

        private void Habits_Load(object sender, EventArgs e)
        {
            // Crear una instancia de la clase CHabits
            CHabits cHabits = new CHabits();

            // Llamar al método Habits() y asignar el resultado al DataGridView
            dataGridView1.DataSource = cHabits.Habits();
            dataGridView2.DataSource = cHabits.Antecedents();
        }
    }
}
