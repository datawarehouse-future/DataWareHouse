using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
   public class Dtabla_dimensiones
    {

        SqlCommand Sqlcmd;
        SqlConnection SqlCn;

        DataTable tablaResultados;
     
        public DataTable Dimension(string sp_dimension)
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();
            try
            {
                SqlCn.ConnectionString = DConexion.Cn;
                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = sp_dimension;
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(Sqlcmd);
                SqlDat.Fill(tablaResultados);
            }
            catch (Exception ex)
            {
                tablaResultados = null;
            }
            return tablaResultados;
        }
        public DataTable Hventa(int mes, int año)
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();
            try
            {
                SqlCn.ConnectionString = DConexion.Cn;
                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "sp_Seleccionar_Hecho";
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.AddWithValue("@MES", mes);
                Sqlcmd.Parameters.AddWithValue("@AÑO", año);
                SqlDataAdapter SqlDat = new SqlDataAdapter(Sqlcmd);
                SqlDat.Fill(tablaResultados);

            }
            catch (Exception)
            {
                tablaResultados = null;
            }
            return tablaResultados;
        }
        public string Cargar(string nombre)
        {
            string rpta = "";
            SqlCn = new SqlConnection();
            try
            {

                SqlCn.ConnectionString = DConexion.Cn;
                SqlCn.Open();

                Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = nombre;
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                rpta = Sqlcmd.ExecuteNonQuery() >= 1 ? "ok" : "NO se cargo el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCn.State == ConnectionState.Open) SqlCn.Close();
            }
            return rpta;
        }
    }
}
