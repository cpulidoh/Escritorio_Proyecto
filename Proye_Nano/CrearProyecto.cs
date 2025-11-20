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
    public partial class CrearProyecto : Form
    {
        public CrearProyecto()
        {
            InitializeComponent();

            dateTimePicker_Inicio.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Inicio.CustomFormat = "dd/MM/yyyy";

            dateTimePicker_Final.Format = DateTimePickerFormat.Custom;
            dateTimePicker_Final.CustomFormat = "dd/MM/yyyy";
        }

        private void CrearProyecto_Load(object sender, EventArgs e)
        {
            textBox_Descripcion.Height = 100;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Estado.Items.Add("Sin Comenzar");
            comboBox_Estado.Items.Add("En Proceso");
            comboBox_Estado.Items.Add("Completado");

            comboBox_Estado.SelectedIndex = 0;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
