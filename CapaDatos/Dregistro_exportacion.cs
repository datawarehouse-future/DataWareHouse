using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class Dregistro_exportacion
    {

        private string _idusuario;
        private string _mes;
        private string _año;
        private string _hora;
        private string _fecha;



        SqlCommand Sqlcmd;
        SqlConnection SqlCn;
        SqlTransaction Sqltra;
        DataTable tablaResultados;



        public string Id_usuario
        {
            get { return _idusuario; }
            set { _idusuario = value; }
        }

        public string Mes
        {
            get { return _mes; }
            set { _mes = value; }
        }

        public string Año
        {
            get { return _año; }
            set { _año = value; }
        }
        public string Hora
        {
            get { return _hora; }
            set { _hora = value; }
        }
        public string Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public string RegistrarDW(Dregistro_exportacion registrarDW)
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
                Sqlcmd.CommandText = "registrar_exportacion_periodicamente";
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.AddWithValue("@id_usuario", registrarDW.Id_usuario);
                Sqlcmd.Parameters.AddWithValue("@mes_exportado", registrarDW.Mes);
                Sqlcmd.Parameters.AddWithValue("@año_exportado", registrarDW.Año);
                Sqlcmd.Parameters.AddWithValue("@hora", registrarDW.Hora);
                Sqlcmd.Parameters.AddWithValue("@fecha", registrarDW.Fecha);

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
        public DataTable Mostrar()
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = DConexion.Cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "obtener_registroDW";
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
        public DataTable Mostrar_ULTI()
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = DConexion.Cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "sp_obtener_registroExp_ULTI";
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
        public DataTable Mostrar_Campo(DateTime desde, DateTime hasta)
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = DConexion.Cn;

                Sqlcmd.Connection = SqlCn;
                Sqlcmd.Transaction = Sqltra;
                Sqlcmd.Parameters.AddWithValue("@desde", desde);
                Sqlcmd.Parameters.AddWithValue("@hasta", hasta);
                Sqlcmd.CommandText = "buscar_registroDW";

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
