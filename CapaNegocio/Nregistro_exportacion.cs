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
   public class Nregistro_exportacion
    {
       


        public static string RegistrarDW(string id_usuario, string mes, string año, string hora, string fecha)
        {
            Dregistro_exportacion obj = new Dregistro_exportacion();
            obj.Id_usuario = id_usuario;
            obj.Mes = mes;
            obj.Año = año;
            obj.Hora = hora;
            obj.Fecha = fecha;
            return obj.RegistrarDW(obj);

        }
        public static DataTable Mostrar_ULTI()
        {
            return new Dregistro_exportacion().Mostrar_ULTI();
        }
    }
}
