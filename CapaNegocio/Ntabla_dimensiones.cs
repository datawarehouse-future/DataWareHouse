using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class Ntabla_dimensiones
    {
      
        public static DataTable Dimension(string sp_dimension)
        {
            return new Dtabla_dimensiones().Dimension(sp_dimension);
        }
      
        public static DataTable Hventa(int mes, int año)
        {
            return new Dtabla_dimensiones().Hventa(mes, año);
        }
        public static string Cargar(string nombre)
        {
            return new Dtabla_dimensiones().Cargar(nombre);
        }
    }
}
