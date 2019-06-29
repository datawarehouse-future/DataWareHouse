using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DcargaGeneral
    {

        SqlCommand Sqlcmd;
        SqlConnection SqlCn;
        SqlTransaction Sqltra;
        DataTable tablaResultados;

        DateTime _desde, _hasta;
        int _combobox;
        int _año;

        public DateTime Pdesde
        {
            get { return _desde; }
            set { _desde = value; }
        }
        public DateTime Phasta
        {
            get { return _hasta; }
            set { _hasta = value; }
        }
        public int Pcombobox
        {
            get { return _combobox; }
            set { _combobox = value; }
        }
        public int Paño
        {
            get { return _año; }
            set { _año = value; }
        }

        public string Cargar (DcargaGeneral cargar)
        {
            string resp = "";
            try
            {

                SqlCn = new SqlConnection();
                Sqlcmd = new SqlCommand();
                SqlCn.ConnectionString = DConexion.Cn;
                SqlCn.Open();
                Sqltra = SqlCn.BeginTransaction();
                Sqlcmd.Connection = SqlCn;
                Sqlcmd.Transaction = Sqltra;
                Sqlcmd.CommandText = "sp_CargaGeneral";
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.AddWithValue("@desde", cargar.Pdesde);
                Sqlcmd.Parameters.AddWithValue("@hasta", cargar.Phasta);

                resp = Sqlcmd.ExecuteNonQuery() >= 1 ? "ok" : "No se pudo registrar";

                if (resp.Equals("ok"))
                {
                    Sqltra.Commit();
                }
                else
                {
                    Sqltra.Rollback();
                }
            }

            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCn.State == ConnectionState.Open)
                    SqlCn.Close();
            }
            return resp;

        }

        public string Cargar_Dimensiones()
        {
            string resp = "";
            try
            {

                SqlCn = new SqlConnection();
                Sqlcmd = new SqlCommand();
                SqlCn.ConnectionString = DConexion.Cn;
                SqlCn.Open();
                Sqltra = SqlCn.BeginTransaction();
                Sqlcmd.Connection = SqlCn;
                Sqlcmd.Transaction = Sqltra;
                Sqlcmd.CommandText = "sp_CargaGeneralDimensiones";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                resp = Sqlcmd.ExecuteNonQuery() >= 1 ? "ok" : "No se pudo registrar";

                if (resp.Equals("ok"))
                {
                    Sqltra.Commit();
                }
                else
                {
                    Sqltra.Rollback();
                }
            }

            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCn.State == ConnectionState.Open)
                    SqlCn.Close();
            }
            return resp;

        }

        public DataTable ObtenerGestion()
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = DConexion.Cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "sp_ObtenerGestion";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(Sqlcmd);
                SqlDat.Fill(tablaResultados);

            }
            catch (Exception)
            {
                tablaResultados = null;
            }
            return tablaResultados;
        }

        public DataTable ObteneMesesDeGestion(int año, int combobox)
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = DConexion.Cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "sp_ObtenerMesesDeGestion";
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.AddWithValue("@año", año);
                Sqlcmd.Parameters.AddWithValue("@combobox",combobox);

                SqlDataAdapter SqlDat = new SqlDataAdapter(Sqlcmd);
                SqlDat.Fill(tablaResultados);

            }
            catch (Exception)
            {
                tablaResultados = null;
            }
            return tablaResultados;
        }

        public DataTable ObtenerFechaInicioVenta()
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = DConexion.Cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "sp_ObtenerFechaInicioDeVenta";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(Sqlcmd);
                SqlDat.Fill(tablaResultados);

            }
            catch (Exception)
            {
                tablaResultados = null;
            }
            return tablaResultados;
        }
        public DataTable ObtenerFechaFinVenta()
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = DConexion.Cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "sp_ObtenerFechaFinDeVenta";
                Sqlcmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(Sqlcmd);
                SqlDat.Fill(tablaResultados);

            }
            catch (Exception)
            {
                tablaResultados = null;
            }
            return tablaResultados;
        }
    }
}
