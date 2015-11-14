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
    public partial class Solicitud_servicio : Form
    {
        public Solicitud_servicio()
        {
            InitializeComponent();
        }

        private void Solicitud_servicio_Load(object sender, EventArgs e)
        {
            List<RutasBE> listaP = new List<RutasBE>();
            RutasController rutacontrola = new RutasController();
            listaP = rutacontrola.VER_RUTA();

            BindingSource rutasourse = new BindingSource();
            rutasourse.DataSource = listaP;
            cmbruta.DataSource = rutasourse;
            cmbruta.DisplayMember = "RUTA";
           
           

        }

        public void calculo() {

           
            
            if (txtpagacliente.Text == "")
            {   MessageBox.Show("!!!Complete todos los campos!!!");}
            else{
            int num1;
            int num2;
            int resultado;

            num1 = Int32.Parse(txtmonto.Text);
            num2 = Int32.Parse(txtpagacliente.Text);
            resultado = (num2- num1);
            txtvuelto.Text = resultado.ToString();
            }
        }
            
                 
            
        
        
        

        public void calculodolares() {
            if (txtpagacliente.Text == "")
            { MessageBox.Show("!!!Complete todos los campos!!!"); }
            else
            {
                double num1;
                double num2;
                double resultado;

                num1 = double.Parse(txtmonto.Text);
                num2 = double.Parse(txtpagacliente.Text);
                num1 = (num1 / 540);
                //num2 = (num2 * 540);
                resultado = (num2 - num1);
                txtvuelto.Text = resultado.ToString();
            }
        
        }

        public void calcular() {
            Conexion myconexion = new Conexion();
            SqlConnection conexion = myconexion.CreateConnection();
            string sql = "Select *from RUTAS where RUTA='" + cmbruta.Text + "'";
            SqlCommand comando = new SqlCommand(sql, conexion);
            conexion.Open();

            SqlDataReader leer = comando.ExecuteReader();

            if (leer.Read() == true)
               
            {
                txtmonto.Text = leer["MONTO"].ToString();
                double monto;
                double monto2;
                
                monto = double.Parse(txtmonto.Text);
                monto2 = (monto / 540);
                txtdolares.Text = monto2.ToString();


               
            }
            else
            {
                MessageBox.Show("No se encontro al conductor");

                
            }
            conexion.Close();
            
        
        
        }
        public void verconductor() {
            Conexion myconexion = new Conexion();
            SqlConnection conexion = myconexion.CreateConnection();
            string sql = "Select *from Conductor where DNI='" + txtcedulacond.Text + "'";
            SqlCommand comando = new SqlCommand(sql, conexion);
            conexion.Open();

            SqlDataReader leer = comando.ExecuteReader();

            if (leer.Read() == true)
            {

                txtnombrecond.Text = leer["NOMBRES"].ToString();
                txtcolor.Text = leer["COLOR"].ToString();
                txtplaca.Text = leer["PLACA"].ToString();
                tapellidocond.Text = leer["APELLIDOS"].ToString();

            }
            else
            {
                MessageBox.Show("No se encontro al conductor");

                txtnombrecond.Text = "";
                txtcolor.Text = "";
                txtplaca.Text = "";
                tapellidocond.Text = "";
            }
            conexion.Close();
            
        
        
        }

        private void vercliente() {
            Conexion myconexion = new Conexion();
            SqlConnection conexion = myconexion.CreateConnection();
            string sql = "Select *from CLIENTE where DNI='" + txtcedulacliente.Text + "'";
            SqlCommand comando = new SqlCommand(sql, conexion);
            conexion.Open();

            SqlDataReader leer = comando.ExecuteReader();

            if (leer.Read() == true)
            {

                txtname.Text = leer["NOMBRES"].ToString();
                txtapellidocliente.Text = leer["APELLIDOS"].ToString();
              

            }
            else
            {
                MessageBox.Show("No se encontro al cliente");

                txtnombrecond.Text = "";
                txtcolor.Text = "";
                txtplaca.Text = "";
            }
            conexion.Close();
            
        
        }
        private void btnasignachofer_Click(object sender, EventArgs e){
            verconductor();
        
            }

        private void btnasignacliente_Click(object sender, EventArgs e)
        {
            vercliente();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            calcular();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculodolares();
        }

        private void btnservicio_Click(object sender, EventArgs e)
        {
            bool result;
            SolicitudBE  ing_solicitud= new SolicitudBE();
            ing_solicitud.NOMBRE_CONDUCTOR = txtnombrecond.Text;
            ing_solicitud.CED_CONDUCTOR = txtcedulacond.Text;
            ing_solicitud.APELLIDO_CONDUCTOR = tapellidocond.Text;
            ing_solicitud.PLACA = txtplaca.Text;
            ing_solicitud.COLOR = txtcolor.Text;
            ing_solicitud.CED_CLIENTE = txtcedulacliente.Text;
            ing_solicitud.NOMBRE_CLIENTE = txtname.Text;
            ing_solicitud.APELLIDOS_CLIENTE = txtapellidocliente.Text;
            ing_solicitud.RUTA = cmbruta.Text;
            ing_solicitud.MONTO = txtmonto.Text;

            SolicitudController controller = new SolicitudController();
            if (result = controller.REGISTRAR_SERVICIO(ing_solicitud))
            {
                MessageBox.Show("!!!!Datos almacenados correctamente!!!!");
            }
            else
            {
                MessageBox.Show("La inserción fallo");
            }
            
            
        }

        private void btnlista_Click(object sender, EventArgs e)
        {
            ListaSolicitudes frmlista = new ListaSolicitudes();
            frmlista.ShowDialog();

        }
    }
}
