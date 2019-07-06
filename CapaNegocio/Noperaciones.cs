using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
namespace CapaNegocio
{
  public  class Noperaciones
    {
        public static string Registrar(int id_usuario,string operacion, string hora, DateTime fecha)
        {
           Doperaciones obj = new Doperaciones();
            obj.Id_usuario = id_usuario;
            obj.Operacion = operacion;
            obj.Hora = hora;
            obj.Fecha = fecha;
            return obj.RegistrarOperacion(obj);
        }
        public static DataTable Mostrar()
        {
            return new Doperaciones().Mostrar();
        }

        public static DataTable Mostrar_parametro(string texto, string campo, DateTime desde,DateTime hasta)
        {
            return new Doperaciones().Mostrar_parametro(texto,campo,desde,hasta);
        }
    }
}
