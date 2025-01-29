using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dental_C__SQLServer_app.Clases;

namespace dental_C__SQLServer_app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CConexion.Conectar();
        }

        public DataTable index()
        {
            DataTable dt = new DataTable();
            String sql = "selec * from pacientes";
            SqlCommand ct= new SqlCommand(sql, CConexion.Conectar()); 
            SqlDataAdapter adapter = new SqlDataAdapter (ct);

            adapter.Fill(dt);

            return dt;


        }



    }
}
