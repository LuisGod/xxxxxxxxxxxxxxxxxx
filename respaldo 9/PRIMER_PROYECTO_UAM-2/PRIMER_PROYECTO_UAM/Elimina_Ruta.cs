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
    public partial class Elimina_Ruta : Form
    {
        public Elimina_Ruta()
        {
            InitializeComponent();
        }

        private void buttonDesac_Click(object sender, EventArgs e)
        {
            bool result;

            RutasBE rutasbe = new RutasBE();
            rutasbe.Ruta = textBoxRutDesac.Text;
            RutasController controler = new RutasController();

            if (result = controler.EliminaRuta(rutasbe))
            {
                MessageBox.Show("Ruta Eliminada con Exito");
            }
            else
            {
                MessageBox.Show("Revise que el Formato del Nombre de la Ruta sea Identico al Ingresado");
            }
        }

        private void buttonCanc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Elimina_Ruta_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
