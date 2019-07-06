using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class Doperaciones
    {
        private int _idusuario;
        private string _operacion;
        private string _hora;
        private DateTime _fecha;



        SqlCommand Sqlcmd;
        SqlConnection SqlCn;
        SqlTransaction Sqltra;
        DataTable tablaResultados;



        public int Id_usuario
        {
            get { return _idusuario; }
            set { _idusuario = value; }
        }
        public string Operacion
        {
            get { return _operacion; }
            set { _operacion = value; }
        }
        public string Hora
        {
            get { return _hora; }
            set { _hora = value; }
        }
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public string RegistrarOperacion(Doperaciones operaciones)
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
                Sqlcmd.CommandText = "sp_operaciones_registrar";
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.AddWithValue("@id_usuario", operaciones.Id_usuario);
                Sqlcmd.Parameters.AddWithValue("@operaciones", operaciones.Operacion);
                Sqlcmd.Parameters.AddWithValue("@hora", operaciones.Hora);
                Sqlcmd.Parameters.AddWithValue("@fecha", operaciones.Fecha);

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
                Sqlcmd.CommandText = "sp_operaciones_mostrar";
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

        public DataTable Mostrar_parametro(string texto, string campo, DateTime desde, DateTime hasta)
        {
            tablaResultados = new DataTable();
            SqlCn = new SqlConnection();
            Sqlcmd = new SqlCommand();

            try
            {
                SqlCn.ConnectionString = DConexion.Cn;
                Sqlcmd.Connection = SqlCn;
                Sqlcmd.CommandText = "sp_operaciones_BuscarParametro";
                Sqlcmd.CommandType = CommandType.StoredProcedure;
                Sqlcmd.Parameters.AddWithValue("@texto", texto);
                Sqlcmd.Parameters.AddWithValue("@campo", campo);
                Sqlcmd.Parameters.AddWithValue("@fechade", desde);
                Sqlcmd.Parameters.AddWithValue("@fechahasta", hasta);

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
