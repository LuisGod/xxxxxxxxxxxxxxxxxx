using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PRIMER_PROYECTO_UAM
{
    public partial class Agrega_Conductor : Form
    {
        public Agrega_Conductor()
        {
            InitializeComponent();
        }

        public ConductorBE conductorActual { get; set; }

        private void Agrega_Conductor_Load(object sender, EventArgs e)
        {
            List<ProvinciaBE> provinciaLista = new List<ProvinciaBE>();
            ProvinciaController provinciaresult = new ProvinciaController();
            provinciaLista = provinciaresult.CONSULTAPROVINCIA();

            BindingSource provinciaSource = new BindingSource();
            provinciaSource.DataSource = provinciaLista;
            comboprovin.DataSource = provinciaSource;
            comboprovin.DisplayMember = "PROVINCIA";
            comboprovin.ValueMember = "IDPROVINCIAS";
        }

        private void buttonagrega_Click(object sender, EventArgs e)
        {
            bool result;

            ConductorBE conductorbe = new ConductorBE();
            conductorbe.Placa = textboxplaca.Text;
            conductorbe.Año = textboxyear.Text;
            conductorbe.Color = textboxcolor.Text;
            conductorbe.Nombres = textboxnombr.Text;
            conductorbe.Apellidos = textboxapell.Text;
            conductorbe.DNI = textboxcedul.Text;
            conductorbe.Edad = numericUpDown1.Text;
            conductorbe.Direccion = textdirec.Text;
            conductorbe.Provincia = comboprovin.Text;
            
            


            ConductorController controler = new ConductorController();
            if (result = controler.AgregaConductor(conductorbe))
            {
                MessageBox.Show("Conductor Almacenado con Exito");
            }
            else
            {
                MessageBox.Show("La Insercion ha Fallado");
            }
        }

        private void buttonbuscareditar_Click(object sender, EventArgs e)
        {
            BuscarConductores busc = new BuscarConductores();
            busc.ShowDialog();

            if (busc.ConductorSeleccionado != null)
            {

                conductorActual = busc.ConductorSeleccionado;
                textboxplaca.Text = busc.ConductorSeleccionado.Placa;
                textboxyear.Text = busc.ConductorSeleccionado.Año;
                textboxcolor.Text = busc.ConductorSeleccionado.Color;
                textboxnombr.Text = busc.ConductorSeleccionado.Nombres;
                textboxapell.Text = busc.ConductorSeleccionado.Apellidos;
                textboxcedul.Text = busc.ConductorSeleccionado.DNI;
                numericUpDown1.Text = busc.ConductorSeleccionado.Edad;
                textdirec.Text = busc.ConductorSeleccionado.Direccion;
                comboprovin.Text = busc.ConductorSeleccionado.Provincia;
               
                
            
            }
        }

        private void buttonactualizar_Click(object sender, EventArgs e)
        {
            ConductorBE pConduct = new ConductorBE();
            
            pConduct.Año = textboxyear.Text.Trim();
            pConduct.Color = textboxcolor.Text.Trim();
            pConduct.Nombres = textboxnombr.Text.Trim();
            pConduct.Apellidos = textboxapell.Text.Trim();
            pConduct.DNI = textboxcedul.Text.Trim();
            pConduct.Edad = numericUpDown1.Text.Trim();
            pConduct.Direccion = textdirec.Text.Trim();
            pConduct.Provincia = comboprovin.Text.Trim();
            pConduct.Placa = conductorActual.Placa;



            if (ConductorController.Actualizar(pConduct) > 0)
            {
                MessageBox.Show("Los datos del conductor se actualizaron", "Datos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo actualizar", "Error al Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        

        
    }
}
