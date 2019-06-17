using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DUsuario
    {
        private int _IdUsuario;
        private string _Nombre;
        private string _NombreUsuario;
        private byte[] _Salt;
        private byte[] _Pass;
        private int _Estado;
        private string _Acceso;

        public string Acceso
        {
            get { return _Acceso; }
            set { _Acceso = value; }
        }

        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }
      
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
    
        public string NombreUsuario
        {
            get { return _NombreUsuario; }
            set { _NombreUsuario = value; }
        }
      
        public byte[] Salt
        {
            get { return _Salt; }
            set { _Salt = value; }
        }
        
        public byte[] Pass
        {
            get { return _Pass; }
            set { _Pass = value; }
        }
        public int Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }


        public string Insertar(DUsuario Usuario)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código 
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();
                //Establecer el comando 
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spInsertar_Usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Usuario.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.NVarChar;
                ParUsuario.Size = 50;
                ParUsuario.Value = Usuario.NombreUsuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParSalt = new SqlParameter();
                ParSalt.ParameterName = "@salt";
                ParSalt.SqlDbType = SqlDbType.VarBinary;
                ParSalt.Value = Usuario.Salt;
                SqlCmd.Parameters.Add(ParSalt);

                               
                SqlParameter ParPass = new SqlParameter();
                ParPass.ParameterName = "@pass";
                ParPass.SqlDbType = SqlDbType.VarBinary;
                ParPass.Value = Usuario.Pass;
                SqlCmd.Parameters.Add(ParPass);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = Usuario.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParAcceso = new SqlParameter();
                ParAcceso.ParameterName = "@acceso";
                ParAcceso.SqlDbType = SqlDbType.VarChar;
                ParAcceso.Size = 20;
                ParAcceso.Value = Usuario.Acceso;
                SqlCmd.Parameters.Add(ParAcceso);

                //Ejecutamos nuestro comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";

            }
            catch (Exception ex)
            {
                //Mostrar el posible error 
                rpta = ex.Message;
                throw;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public DataTable BuscarIdUsuario()
        {
            string rpta = "";
            DataTable DtResultado = new DataTable("Hola");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código 
                
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();
                //Establecer el comando 
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spGetUserId";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                //Ejecutamos nuestro comando

                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                //Mostrar el posible error 
                rpta = ex.Message;
                throw;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;
        }

        public DataTable ObtenerDesdeBd(DUsuario Usuario)
        {
            DataTable DtResultado = new DataTable("Usuario");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                //Código 
                SqlCon.ConnectionString = DConexion.Cn;
                SqlCon.Open();
                //Establecer el comando 
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "US_ObtenerCredenciales";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre_Usuario";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Usuario.NombreUsuario;
                SqlCmd.Parameters.Add(ParNombre);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {

                DtResultado = null;
            }

            return DtResultado;
        }
    }
}
