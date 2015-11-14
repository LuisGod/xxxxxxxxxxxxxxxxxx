using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PRIMER_PROYECTO_UAM
{
    public class SolicitudController
    {

        //public static ConductorBE ObtenerConductor(int pPlaca)
        //{
        //    ConductorBE pConductor = new ConductorBE();

        //    Conexion myConnection = new Conexion();
        //    SqlConnection conexion = myConnection.CreateConnection();
        //    SqlCommand comando = new SqlCommand(String.Format("SELECT PLACA, AñO, COLOR, NOMBRES,APELLIDOS, DNI, EDAD, DIRECCION, PROVINCIA FROM CONDUCTOR where PLACA ='{0}'", pPlaca), conexion);
        //    SqlDataReader cconductor;

        //    conexion.Open();

        //    cconductor = comando.ExecuteReader();
        //    while (cconductor.Read())
        //    {

        //        pConductor.Placa = cconductor.GetString(0);
        //        pConductor.Año = cconductor.GetString(1);
        //        pConductor.Color = cconductor.GetString(2);
        //        pConductor.Nombres = cconductor.GetString(3);
        //        pConductor.Apellidos = cconductor.GetString(4);
        //        pConductor.DNI = cconductor.GetString(5);
        //        pConductor.Edad = cconductor.GetString(6);
        //        pConductor.Direccion = cconductor.GetString(7);
        //        pConductor.Provincia = cconductor.GetString(8);


        //    }

        //    conexion.Close();
        //    return pConductor;

        //}
            //metodo para almcenar la informacion del servicio
        public bool REGISTRAR_SERVICIO(SolicitudBE solicitud)
        {
            bool result = false;
            try
            {
                Conexion myConnection = new Conexion();
                SqlConnection conexion = myConnection.CreateConnection();
                SqlCommand comando = myConnection.CreateCommand(conexion);

                comando.CommandText = "REGISTRAR_SERVICIO";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("CED_CLIENTE", solicitud.CED_CLIENTE);
                comando.Parameters.AddWithValue("NOMBRE_CLIENTE", solicitud.NOMBRE_CLIENTE);
                comando.Parameters.AddWithValue("APELLIDOS_CLIENTE", solicitud.APELLIDOS_CLIENTE);
                comando.Parameters.AddWithValue("PLACA", solicitud.PLACA);
                comando.Parameters.AddWithValue("COLOR", solicitud.COLOR);
                comando.Parameters.AddWithValue("CED_CONDUCTOR", solicitud.CED_CONDUCTOR);
                comando.Parameters.AddWithValue("NOMBRE_CONDUCTOR", solicitud.NOMBRE_CONDUCTOR);
                comando.Parameters.AddWithValue("APELLIDO_CONDUCTOR", solicitud.APELLIDO_CONDUCTOR);
                comando.Parameters.AddWithValue("RUTA", solicitud.RUTA);
                comando.Parameters.AddWithValue("MONTO", solicitud.MONTO);


                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                result = true;
            }
            catch (SqlException e)
            {
                //insert error in a log
                result = false;
            }
            return result;
        }


        public List<SolicitudBE> VER_SERVICIOS()  //lista para poder visualizar los servicios
        {
            List<SolicitudBE> listResult = new List<SolicitudBE>();
            try
            {
                Conexion myConnection = new Conexion();
                SqlConnection conexion = myConnection.CreateConnection();
                SqlCommand comando = myConnection.CreateCommand(conexion);
                SqlDataReader solicitudReader;

                comando.CommandText = "VER_SERVICIOS";
                comando.CommandType = CommandType.StoredProcedure;

                conexion.Open();
                solicitudReader = comando.ExecuteReader();

                while (solicitudReader.Read())
                {
                    SolicitudBE solicitudBE = new SolicitudBE();
                    solicitudBE.CED_CLIENTE = solicitudReader["CED_CLIENTE"].ToString();
                    solicitudBE.NOMBRE_CLIENTE = solicitudReader["NOMBRE_CLIENTE"].ToString();
                    solicitudBE.APELLIDOS_CLIENTE = solicitudReader["APELLIDOS_CLIENTE"].ToString();
                    solicitudBE.CED_CONDUCTOR = solicitudReader["CED_CONDUCTOR"].ToString();
                    solicitudBE.NOMBRE_CONDUCTOR = solicitudReader["NOMBRE_CONDUCTOR"].ToString();
                    solicitudBE.APELLIDO_CONDUCTOR = solicitudReader["APELLIDO_CONDUCTOR"].ToString();
                    solicitudBE.COLOR = solicitudReader["COLOR"].ToString();
                    solicitudBE.PLACA = solicitudReader["PLACA"].ToString();
                    solicitudBE.MONTO = solicitudReader["MONTO"].ToString();
                    solicitudBE.RUTA = solicitudReader["RUTA"].ToString();



                    listResult.Add(solicitudBE);
                }

                conexion.Close();
            }
            catch (SqlException e)
            {
                //insert error in a log
            }
            return listResult;
        }
    }
}