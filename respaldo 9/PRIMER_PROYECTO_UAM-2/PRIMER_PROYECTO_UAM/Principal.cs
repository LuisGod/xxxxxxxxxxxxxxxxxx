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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void bTNCONSULTAR_Click(object sender, EventArgs e)
        {
            Consultar frmconsulta = new Consultar();
             frmconsulta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ver_Eliminar frmver = new Ver_Eliminar();
            frmver.Show();

        }

        private void btnrgscondu_Click(object sender, EventArgs e)
        {
            Agrega_Conductor agrr = new Agrega_Conductor();
            agrr.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void buttonELIMCOND_Click(object sender, EventArgs e)
        {
            Elimina_Conductor elimm = new Elimina_Conductor();
            elimm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Monto_Conductores montcond = new Monto_Conductores();
            montcond.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void btnsolicitud_Click(object sender, EventArgs e)
        {
            Solicitud_servicio frmsolicitud = new Solicitud_servicio();
            frmsolicitud.ShowDialog();
        }

        private void buttonREGISTRUT_Click(object sender, EventArgs e)
        {
            Agrega_Ruta agrrut = new Agrega_Ruta();
            agrrut.ShowDialog();
        }

        private void buttonELIMRUT_Click(object sender, EventArgs e)
        {
            Elimina_Ruta eliminrut = new Elimina_Ruta();
            eliminrut.ShowDialog();

        }

        }
    }

