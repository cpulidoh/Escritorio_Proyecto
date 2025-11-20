using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proye_Nano
{
    public partial class Servicios : Form
    {
        public Servicios()
        {
            InitializeComponent();
        }

        private void Boton_CrearProyecto_Click(object sender, EventArgs e)
        {
            CrearProyecto crearProyecto = new CrearProyecto();
            crearProyecto.ShowDialog();
            this.Close();
        }

        private void Servicios_Load(object sender, EventArgs e)
        {

        }
    }
}
