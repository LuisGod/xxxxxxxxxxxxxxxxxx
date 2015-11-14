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
    public partial class Caracteristicas_Rutas : Form
    {
        public Caracteristicas_Rutas()
        {
            InitializeComponent();
        }

        private void btnconv_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RUTA CONVENCIONAL: ECONÓMICA Y LENTA");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RUTA RÁPIDA POR PISTA: COSTOSA Y RÁPIDA");
        }
    }
}
