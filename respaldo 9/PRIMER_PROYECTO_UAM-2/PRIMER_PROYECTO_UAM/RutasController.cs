using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace PRIMER_PROYECTO_UAM
{
    class RutasController
    {

        //metodos para agregar una ruta---------------------------------------------------------

        public bool AgregaRuta(RutasBE RutaAgrega)
        {
            bool result = false;
            try
            {
                Conexion myConnection = new Conexion();
                SqlConnection conexion = myConnection.CreateConnection();
                SqlCommand comando = myConnection.CreateCommand(conexion);


                comando.CommandText = "REGISTRA_RUTAS";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@RUTA", RutaAgrega.Ruta);
                comando.Parameters.AddWithValue("@DISTANCIAKM", RutaAgrega.Distanciakm);
                comando.Parameters.AddWithValue("@MONTO", RutaAgrega.Monto);
                

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


        public List<RutasBE> Agregarut()
        {
            RutasBE rutasBE;
            List<RutasBE> listaResult = new List<RutasBE>();

            Conexion myConnection = new Conexion();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader rrutas;

            comando.CommandText = "REGISTRA_RUTAS";
            comando.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            rrutas = comando.ExecuteReader();
            while (rrutas.Read())
            {
                rutasBE = new RutasBE();

                rutasBE.Ruta = rrutas["RUTA"].ToString();
                rutasBE.Distanciakm = rrutas["DISTANCIAKM"].ToString();
                rutasBE.Monto = rrutas["MONTO"].ToString();

                listaResult.Add(rutasBE);

            }

            conexion.Close();

            return listaResult;
        }

        //metodos para eliminar una ruta ---------------------------------------------------------------

        public bool EliminaRuta(RutasBE RutaElimina)
        {
            bool result = false;
            try
            {
                Conexion myConnection = new Conexion();
                SqlConnection conexion = myConnection.CreateConnection();
                SqlCommand comando = myConnection.CreateCommand(conexion);



                comando.CommandText = "DESACTIVA_RUTA";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@RUTA", RutaElimina.Ruta);



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

        public List<RutasBE> Eliminaruta()
        {
            RutasBE rutasBE;
            List<RutasBE> listaResult = new List<RutasBE>();

            Conexion myConnection = new Conexion();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader rrrutas;

            comando.CommandText = "DESACTIVA_RUTA";
            comando.CommandType = CommandType.StoredProcedure;

            conexion.Open();

            rrrutas = comando.ExecuteReader();
            while (rrrutas.Read())
            {
                rutasBE = new RutasBE();
                rutasBE.Ruta = rrrutas["RUTA"].ToString();



                listaResult.Add(rutasBE);

            }

            conexion.Close();

            return listaResult;
        }

        public List<RutasBE> VER_RUTA()
        {

            RutasBE rutasBE;
            List<RutasBE> listaResulta = new List<RutasBE>();

            Conexion myConnection = new Conexion();
            SqlConnection conexion = myConnection.CreateConnection();
            SqlCommand comando = myConnection.CreateCommand(conexion);
            SqlDataReader rutas;

            comando.CommandText = "VER_RUTA";
            comando.CommandType = CommandType.StoredProcedure;


            conexion.Open();

            rutas = comando.ExecuteReader();
            while (rutas.Read())
            {
                rutasBE = new RutasBE();

                rutasBE.Ruta = rutas["RUTA"].ToString();




                listaResulta.Add(rutasBE);

            }

            conexion.Close();

            return listaResulta;

        }

    }
}
