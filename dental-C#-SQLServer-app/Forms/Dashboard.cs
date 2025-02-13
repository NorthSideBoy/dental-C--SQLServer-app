using dental_C__SQLServer_app;
using System;
using System.Drawing;
using System.Windows.Forms;
using Svg;


namespace dental_C__SQLServer_app
{
    public partial class Dashboard : Form
    {
        private bool sidebarExpand = true;
        public Dashboard()
        {
            InitializeComponent();

            var svgDocument = SvgDocument.Open("C:\\Users\\USUARIO\\Source\\Repos\\dental-C--SQLServer-app\\dental-C#-SQLServer-app\\Resources\\patient_list.svg");
            var bitmap = svgDocument.Draw();
            svgDocument.Fill = new SvgColourServer(Color.White);

            btnPacientes.Image = bitmap;
            btnPacientes.ImageAlign = ContentAlignment.MiddleLeft;

        }

        public void LoadForm(object Form)
        {
            if (this.MainPanel.Controls.Count >0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            LoadForm(new Patients());
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
         
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            btnConfig.BackColor = Color.FromArgb(0, 255, 183);
        }

        private void btnPacientes_MouseMove(object sender, MouseEventArgs e)
        {
            btnPacientes.BackColor = Color.FromArgb(185, 255, 233);
        }

        private void btnPacientes_MouseLeave(object sender, EventArgs e)
        {
                btnPacientes.BackColor = Color.Transparent;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnConsultas_MouseMove(object sender, MouseEventArgs e)
        {
            btnConsultas.BackColor = Color.FromArgb(185, 255, 233);
        }

        private void btnConsultas_MouseLeave(object sender, EventArgs e)
        {
            btnConsultas.BackColor = Color.Transparent;
        }

        private void btnConfig_MouseMove(object sender, MouseEventArgs e)
        {
            btnConfig.BackColor = Color.FromArgb(185, 255, 233);
        }

        private void btnConfig_MouseLeave(object sender, EventArgs e)
        {
            btnConfig.BackColor = Color.Transparent;
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //seteando el tamaño minimo y maximo del panel
            if (sidebarExpand)
            {
                //si la sidebar esta expandida, minimizar
                sidebar.Width -= 10;
                if (sidebar.Width <= 71)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 220)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_MouseMove(object sender, MouseEventArgs e)
        {
            btnLogout.BackColor = Color.FromArgb(185, 255, 233);
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = Color.Transparent;
        }
    }
}
