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
    public partial class BuscarConductores : Form
    {
        public BuscarConductores()
        {
            InitializeComponent();
        }

        private void BuscarConductores_Load(object sender, EventArgs e)
        {

        }

        public ConductorBE ConductorSeleccionado { get; set; }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            dgvBuscar.DataSource = ConductorController.Buscar(txtboxnombrebusca.Text, txtboxapellbusca.Text);
        }

        private void buttonacept_Click(object sender, EventArgs e)
        {
            {
                if (dgvBuscar.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt32(dgvBuscar.CurrentRow.Cells[0].Value);
                    ConductorSeleccionado = ConductorController.ObtenerConductor(id);

                    this.Close();
                }
                else
                    MessageBox.Show("Debe de seleccionar una fila");
            }

        }

        private void dgvBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtboxnombrebusca_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
