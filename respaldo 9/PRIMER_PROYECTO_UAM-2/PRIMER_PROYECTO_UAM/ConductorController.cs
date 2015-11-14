using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PRIMER_PROYECTO_UAM
{
    public class ConductorController
    {
        //metodos para agregar conductor -------------------------------------------------------
        public bool AgregaConductor(ConductorBE ConductorAgrega)
        {
            bool result = false;
            try
            {
                Conexion myConnection = new Conexion();
                SqlConnection conexion = myConnection.CreateConnection();
                SqlCommand comando = myConnection.CreateCommand(conexion);



                comando.CommandText = "REGISTRAR_CONDUCTOR";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@PLACA", ConductorAgrega.Placa);
                comando.Parameters.AddWithValue("@AñO", ConductorAgrega.Año);
                comando.Parameters.AddWithValue("@COLOR", ConductorAgrega.Color);
                comando.Parameters.AddWithValue("@NOMBRES", ConductorAgrega.Nombres);
                comando.Parameters.AddWithValue("@APELLIDOS", ConductorAgrega.Apellidos);
                comando.Parameters.AddWithValue("@DNI", ConductorAgrega.DNI);
                comando.Parameters.AddWithValue("@EDAD", ConductorAgrega.Edad);
                comando.Parameters.AddWithValue("@DIRECCION", ConductorAgrega.Direccion);
                comando.Parameters.AddWithValue("@PROVINCIA", ConductorAgrega.Provincia);



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
        public List<ConductorBE> Agregaconduct()
        {
            ConductorBE conductorBE;
            List<ConductorBE> listaResult = new List<ConductorBE>();

            Conexion myConnection = new Conexion();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader cconduct;

            comando.CommandText = "REGISTRAR_CONDUCTOR";
            comando.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cconduct = comando.ExecuteReader();
            while (cconduct.Read())
            {
                conductorBE = new ConductorBE();

                conductorBE.Placa = cconduct["PLACA"].ToString();
                conductorBE.Año = cconduct["AñO"].ToString();
                conductorBE.Color = cconduct["COLOR"].ToString();
                conductorBE.Nombres = cconduct["NOMBRES"].ToString();
                conductorBE.Apellidos = cconduct["APELLIDOS"].ToString();
                conductorBE.DNI = cconduct["DNI"].ToString();
                conductorBE.Edad = cconduct["EDAD"].ToString();
                conductorBE.Direccion = cconduct["DIRECCION"].ToString();
                conductorBE.Provincia = cconduct["PROVINCIA"].ToString();


                listaResult.Add(conductorBE);

            }

            conexion.Close();

            return listaResult;
        }

        //metodos para eliminar un conductor---------------------------------------------------
        public bool EliminaConductor(ConductorBE ConductorElimina)
        {
            bool result = false;
            try
            {
                Conexion myConnection = new Conexion();
                SqlConnection conexion = myConnection.CreateConnection();
                SqlCommand comando = myConnection.CreateCommand(conexion);



                comando.CommandText = "BORRAR_CONDUCTOR";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@DNI", ConductorElimina.DNI);
                


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

        public List<ConductorBE> Eliminaconduct()
        {
            ConductorBE conductorBE;
            List<ConductorBE> listaResult = new List<ConductorBE>();

            Conexion myConnection = new Conexion();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader cconduct;

            comando.CommandText = "BORRAR_CONDUCTOR";
            comando.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            cconduct = comando.ExecuteReader();
            while (cconduct.Read())
            {
                conductorBE = new ConductorBE();
                conductorBE.DNI = cconduct["DNI"].ToString();
                


                listaResult.Add(conductorBE);

            }

            conexion.Close();

            return listaResult;
        }

        //metodos para editar un conductor-------------------------------------------------

        public static List<ConductorBE> Buscar(string pNombre, string pApellido)
        {
            List<ConductorBE> resultadolista = new List<ConductorBE>();

            ConductorBE vvv = new ConductorBE();

            Conexion myConnection = new Conexion();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = new SqlCommand(String.Format("SELECT PLACA, AñO, COLOR, NOMBRES, APELLIDOS,DNI, EDAD, DIRECCION, PROVINCIA FROM CONDUCTOR where NOMBRES ='{0}' or APELLIDOS='{1}'", pNombre,pApellido), conexion);
            SqlDataReader cconductor;

            conexion.Open();

            cconductor = comando.ExecuteReader();
            while (cconductor.Read())
            {
                ConductorBE pConductor = new ConductorBE();
                pConductor.Placa = cconductor.GetString(0);
                pConductor.Año = cconductor.GetString(1);
                pConductor.Color = cconductor.GetString(2);
                pConductor.Nombres=cconductor.GetString(3);
                pConductor.Apellidos = cconductor.GetString(4);
                pConductor.DNI = cconductor.GetString(5);
                pConductor.Edad = cconductor.GetString(6);
                pConductor.Direccion = cconductor.GetString(7);
                pConductor.Provincia = cconductor.GetString(8);
               
                resultadolista.Add(pConductor);
            }
            conexion.Close();
            return resultadolista;
        }




        public static ConductorBE ObtenerConductor(int pPlaca)
        {
            ConductorBE pConductor = new ConductorBE();

            Conexion myConnection = new Conexion();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = new SqlCommand(String.Format("SELECT PLACA, AÑO, COLOR, NOMBRES,APELLIDOS, DNI, EDAD, DIRECCION, PROVINCIA FROM CONDUCTOR where PLACA ='{0}'", pPlaca), conexion);
            SqlDataReader cconductor;

            conexion.Open();

            cconductor = comando.ExecuteReader();
            while (cconductor.Read())
            {
                pConductor.Placa = cconductor.GetString(0);
                pConductor.Año = cconductor.GetString(1);
                pConductor.Color = cconductor.GetString(2);
                pConductor.Nombres = cconductor.GetString(3);
                pConductor.Apellidos = cconductor.GetString(4);
                pConductor.DNI = cconductor.GetString(5);
                pConductor.Edad = cconductor.GetString(6);
                pConductor.Direccion = cconductor.GetString(7);
                pConductor.Provincia = cconductor.GetString(8);

                
            }

           conexion.Close();
           return pConductor;

        }

        public static int Actualizar(ConductorBE mConductor)

        {
            int retorno = 0;


            Conexion myConnection = new Conexion();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = new SqlCommand(string.Format("UPDATE CONDUCTOR set AÑO ='{0}', COLOR ='{1}', NOMBRES ='{2}', APELLIDOS ='{3}', DNI ='{4}', EDAD='{5}', DIRECCION='{6}',PROVINCIA='{7}' where PLACA={8}",
            mConductor.Año, mConductor.Color, mConductor.Nombres, mConductor.Apellidos, mConductor.DNI,mConductor.Edad,mConductor.Direccion,mConductor.Provincia,mConductor.Placa), conexion);

            conexion.Open();
            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;


        }
    }

}
