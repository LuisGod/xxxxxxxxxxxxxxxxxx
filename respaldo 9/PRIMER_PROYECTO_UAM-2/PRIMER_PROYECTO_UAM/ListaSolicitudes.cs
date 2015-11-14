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
    public partial class ListaSolicitudes : Form
    {
        public ListaSolicitudes()
        {
            InitializeComponent();
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            SolicitudController controller = new SolicitudController();
            List<SolicitudBE> listData = controller.VER_SERVICIOS();

            var bindingList = new BindingList <SolicitudBE> (listData);
            var source = new BindingSource(bindingList, null);
            datasolicitudes.DataSource = source;

          //  datasolicitudes.Columns[0].HeaderText = "RUTA";
            datasolicitudes.Columns[1].HeaderText = "NOMBRE_CONDUCTOR";
            datasolicitudes.Columns[2].HeaderText = "APELLIDO_CONDUCTOR";
            datasolicitudes.Columns[3].HeaderText = "CED_CONDUCOTOR";
            datasolicitudes.Columns[4].HeaderText = "MONTO";
            datasolicitudes.Columns[5].HeaderText = "NOMBRE_CLIENTE";
            datasolicitudes.Columns[6].HeaderText = "APELLIDOS_CLIENTE";
            datasolicitudes.Columns[7].HeaderText = "PLACA";
        }
    }
}
