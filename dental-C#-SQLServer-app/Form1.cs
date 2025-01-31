namespace dental_C__SQLServer_app
{
    public partial class Form1 : Form
    {
        bool sidebarExpand;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            btnPacientes.BackColor = Color.FromArgb(0, 255, 183);
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            btnConsultas.BackColor = Color.FromArgb(0, 255, 183);
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
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else 
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
    }
}
