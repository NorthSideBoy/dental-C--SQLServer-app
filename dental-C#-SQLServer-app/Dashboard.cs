
namespace dental_C__SQLServer_app
{
    public partial class Dashboard : Form
    {
        private Button selectedButton;
        private bool sidebarExpand = true;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            // Restablecer el botón previamente seleccionado
            if (selectedButton != null)
            {
                selectedButton.BackColor = SystemColors.Control; // Color original
                selectedButton.ForeColor = Color.Black; // Color original
            }

            btnPacientes.BackColor = Color.FromArgb(0, 255, 183);
            clickedButton.ForeColor = Color.White;

            // Actualizar el botón seleccionado
            selectedButton = clickedButton;
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
            Button button = sender as Button;
            if (button != selectedButton) // Solo cambiar si no es el botón seleccionado
            {

                btnPacientes.BackColor = Color.FromArgb(185, 255, 233);
                button.ForeColor = Color.White; // Cambiar color de fuente
            }
        }

        private void btnPacientes_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != selectedButton) // Solo restablecer si no es el botón seleccionado
            {

                btnPacientes.BackColor = Color.Transparent;
                button.ForeColor = Color.Black; // Color original
            }
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
