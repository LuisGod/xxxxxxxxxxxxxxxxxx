using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRIMER_PROYECTO_UAM
{
    public partial class Elimina_Conductor : Form
    {
        public Elimina_Conductor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result;

            ConductorBE conductorbe = new ConductorBE();
            conductorbe.DNI = textBoxelim.Text;

            ConductorController controler = new ConductorController();
            if (result = controler.EliminaConductor(conductorbe))
            {
                MessageBox.Show("Conductor Eliminado con Exito");
            }
            else
            {
                MessageBox.Show("Revise que el numero de cedula sea el correcto");
            }
        }

        private void Elimina_Conductor_Load(object sender, EventArgs e)
        {

        }


    }
}
