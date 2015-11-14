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
    public partial class Agrega_Ruta : Form
    {
        public Agrega_Ruta()
        {
            InitializeComponent();
        }

        private void Agrega_Ruta_Load(object sender, EventArgs e)
        {

        }

        private void buttonAlmaRut_Click(object sender, EventArgs e)
        {
            bool result;

            RutasBE rutasbe = new RutasBE();
            rutasbe.Ruta = textBoxRutaNom.Text;
            rutasbe.Distanciakm = textBoxDistanK.Text;
            rutasbe.Monto = textBoxMontPas.Text;

            RutasController controler = new RutasController();
            if (result = controler.AgregaRuta(rutasbe))
            {
                MessageBox.Show("Ruta Almacenada con Exito");
            }
            else
            {
                MessageBox.Show("La Insercion ha Fallado");
            }
        }

        private void buttonBuscRut_Click(object sender, EventArgs e)
        {

        }
    }
}
