using CRUDCSharpSQLServer.Classes;
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
    public partial class Panel_usuario : Form
    {
        Database database = new Database();
        public Panel_usuario()
        {
            InitializeComponent();
            database.Connection();
        }

        private void btnAñadirUser_Click(object sender, EventArgs e)
        {
            Form2 re = new Form2();
            re.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
