using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
   public class NcargaGeneral
    {
        public static string Cargar(DateTime desde, DateTime hasta) {

            DcargaGeneral general = new DcargaGeneral();
            general.Pdesde = desde;
            general.Phasta = hasta;
            return general.Cargar(general);
        }
        public static string Cargar_Dimensiones()
        {
            return new DcargaGeneral().Cargar_Dimensiones();
        }
        public static DataTable ObtenerGestion()
        {
            return new DcargaGeneral().ObtenerGestion();
        }
        public static DataTable ObtenerMesesDeGestion(int año, int combobox)
        {
            return new DcargaGeneral().ObteneMesesDeGestion(año,combobox);
        }
        public static DataTable ObtenerFechaInicioVenta()
        {
            return new DcargaGeneral().ObtenerFechaInicioVenta();
        }
        public static DataTable ObtenerFechaFinVenta()
        {
            return new DcargaGeneral().ObtenerFechaFinVenta();
        }
    }
}
