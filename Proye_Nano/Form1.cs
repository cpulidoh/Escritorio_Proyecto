namespace Proye_Nano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Inicio_Sesion_Click(object sender, EventArgs e)
        {
            Servicios servicios = new Servicios();
            servicios.ShowDialog();
            this.Close();
        }
    }
}
