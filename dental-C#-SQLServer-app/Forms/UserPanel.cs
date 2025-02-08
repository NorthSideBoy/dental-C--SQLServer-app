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
    public partial class UserPanel : Form
    {
        Database database = new Database();
        public UserPanel()
        {
            InitializeComponent();
            //database.Connection();
        }

        private void btnAñadirUser_Click(object sender, EventArgs e)
        {
            Register re = new Register();
            re.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
