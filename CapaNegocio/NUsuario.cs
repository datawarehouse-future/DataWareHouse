using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;



namespace CapaNegocio
{
    public class NUsuario
    {
        //Método Insertar que llama al método Insertar de la Clase DUsuario de la capaDatos

  


        public static string Insertar(string nombre, string nombre_usuario, byte[] salt, byte[] pass, int estado, string acceso)
        {
            
            DUsuario Obj = new DUsuario();
            Obj.Nombre = nombre;
            Obj.NombreUsuario = nombre_usuario;
            Obj.Salt = salt;
            Obj.Pass = pass;
            Obj.Estado = estado;
            Obj.Acceso = acceso;


            return Obj.Insertar(Obj);
        }

        public static DataTable  BuscarUser()
        {
            DUsuario Obj = new DUsuario();
            return Obj.BuscarIdUsuario();   
        }

        public static DataTable BuscarUsuario(string UsuarioBuscar)
        {
            DUsuario Obj = new DUsuario();
            Obj.NombreUsuario = UsuarioBuscar;
            return Obj.ObtenerDesdeBd(Obj);
        }

    }
}
