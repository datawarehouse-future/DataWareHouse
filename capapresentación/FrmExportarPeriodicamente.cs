using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using CapaNegocio;
namespace CapaPresentación
{
    public partial class FrmExportarPeriodicamente : Form
    {
        public FrmExportarPeriodicamente()
        {
            InitializeComponent();
        }

        
        /**Direccion del archivo tiempo*/
        string ruta_tiempo = "C:/ARCHIVOS/tiempo.txt";
        string ruta_venta = "C:/ARCHIVOS/venta.txt";
        /**/
        DataTable tabla = new DataTable();
        string resp = "";
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int resultado = Convert.ToInt16(txtMES.Text) + 1;
                int ultimoAño = Convert.ToInt16(txtAÑO.Text);
                if (lbMES.Text == "Mes" || txtAÑOEX.Text == "")
                {
                    MessageBox.Show("Error, Verifique los campos para exportar");
                }
                else
                {
                    int resultadoB = Convert.ToInt16(txtMESEX.Text);
                    int ultimoAño2 = Convert.ToInt16(txtAÑOEX.Text);

                    if (txtMES.Text == "12")
                    {
                        ultimoAño = ultimoAño + 1;
                        resultado = 1;
                    }
                    if ((resultado == resultadoB) && (ultimoAño == ultimoAño2))
                    {
                        int mes = Convert.ToInt16(txtMESEX.Text);
                        int año = Convert.ToInt16(txtAÑOEX.Text);
                        Guardar_archivo_tiempo(ruta_tiempo,mes,año.ToString());
                        tabla = Ntabla_dimensiones.Hventa(mes,año);
                        Guardar_archivo_hventa(ruta_venta,tabla);
                        if (tabla.Rows.Count == 0)
                        {MessageBox.Show("Error, No se ha encontrado datos en el periodo para exportar");}
                        else
                        {
                            DateTime fecha = DateTime.Today;
                            string fecha_Actual = Convert.ToString(fecha.ToString("dd-MM-yyyy"));
                            string hora = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
                            MessageBox.Show("Datos exportados correctamente");
                            resp = Nregistro_exportacion.RegistrarDW("1", lbMES.Text, txtAÑOEX.Text, hora, fecha_Actual);
                            ultimo_exportado();
                            sugerir();
                            cambiar_mes();
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR, SE DEBE EXPORTAR EL AÑO CON LOS MESES CONTINUOS ", "System DW", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            catch (Exception)
            {
                if (lbMES.Text == "Mes" || txtAÑOEX.Text == "")
                {
                    MessageBox.Show("Error, Verifique los campos para exportar");
                }
                else
                {
                    int mes = Convert.ToInt16(txtMESEX.Text);
                    int año = Convert.ToInt16(txtAÑOEX.Text);
                    Guardar_archivo_tiempo(ruta_tiempo, mes, año.ToString());
                    tabla = Ntabla_dimensiones.Hventa(mes, año);
                    Guardar_archivo_hventa(ruta_venta, tabla);

                    if (tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("Error, No se ha encontrado datos en el periodo para exportar");
                    }
                    else
                    {
                        DateTime fecha = DateTime.Today;
                        string fecha_Actual = Convert.ToString(fecha.ToString("dd-MM-yyyy"));
                        string hora = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");



                        MessageBox.Show("Datos exportados correctamente");
                        resp = Nregistro_exportacion.RegistrarDW("1", lbMES.Text, txtAÑOEX.Text, hora, fecha_Actual);
                        ultimo_exportado();
                        sugerir();
                        cambiar_mes();

                    }

                }

            }

        }
        public void cambiar_mes()
        {
            string mes = txtMESEX.Text;
            if (mes == "1")
                lbMES.Text = "Enero";
            else if (mes == "2")
                lbMES.Text = "Febrero";
            else if (mes == "3")
                lbMES.Text = "Marzo";
            else if (mes == "4")
                lbMES.Text = "Abril";
            else if (mes == "5")
                lbMES.Text = "Mayo";
            else if (mes == "6")
                lbMES.Text = "Junio";
            else if (mes == "7")
                lbMES.Text = "Julio";
            else if (mes == "8")
                lbMES.Text = "Agosto";
            else if (mes == "9")
                lbMES.Text = "Septiembre";
            else if (mes == "10")
                lbMES.Text = "Octubre";
            else if (mes == "11")
                lbMES.Text = "Noviembre";
            else if (mes == "12")
                lbMES.Text = "Diciembre";
            else
                lbMES.Text = "Mes";
        }

        public void sugerir()
        {
            try
            {   int año = Convert.ToInt16(txtAÑO.Text);
                int mes = Convert.ToInt16(txtMES.Text);
                if (mes == 12)
                {  año = año + 1;
                   mes = 1;
                }else
                {  mes = mes + 1; }
                  txtAÑOEX.Text = año.ToString();
                txtMESEX.Text = mes.ToString();
            }
            catch (Exception){}
        }
        public void Guardar_archivo_tiempo(string pruta,int mes,string año)
        {
           
            StreamWriter ESCRIBIR = new StreamWriter(pruta, true);
            try
            {
                string Linea = "";
                if (mes < 10) {
                    Linea = año + "0"+mes+"|"+lbMES.Text+"|"+año;
                } else
                { Linea = año+mes+"|"+lbMES.Text+"|"+año;}

                ESCRIBIR.WriteLine(Linea);
                ESCRIBIR.Close();
            }
            catch (Exception)
            {
                ESCRIBIR.Close();
            }
        }
        public void Guardar_archivo_hventa(string pruta, DataTable tabla)
        {

            StreamWriter ESCRIBIR = new StreamWriter(pruta, true);
            try
            {

                string Linea = "";
                for (int v = 0; v <= tabla.Rows.Count; v++)
                {

                   

                    Linea = tabla.Rows[v][0].ToString() + "|" +
                            tabla.Rows[v][1].ToString() + "|" +
                            tabla.Rows[v][2].ToString() + "|" +
                            tabla.Rows[v][3].ToString() + "|" +
                            tabla.Rows[v][4].ToString() + "|" +
                            tabla.Rows[v][5].ToString() + "|" +
                            tabla.Rows[v][6].ToString() + "|" +
                            tabla.Rows[v][7].ToString() + "|" +
                            tabla.Rows[v][8].ToString() + "|" +
                            tabla.Rows[v][9].ToString();
                    Linea = Linea.Replace(",", ".");
                    ESCRIBIR.WriteLine(Linea);
                }

                ESCRIBIR.Close();
            }
            catch (Exception)
            {
                ESCRIBIR.Close();
            }

        }
        public void ultimo_exportado()
        {
            try
            {
                tabla= Nregistro_exportacion.Mostrar_ULTI();

               txtAÑO.Text =tabla.Rows[0][1].ToString();
                string mes =tabla.Rows[0][0].ToString();
                if (mes == "Enero")
                {
                    txtMES.Text = "1";
                    lbMES2.Text = "Enero";
                }
                else if (mes == "Febrero")
                {
                    txtMES.Text = "2";
                    lbMES2.Text = "Febrero";
                }
                else if (mes == "Marzo")
                {
                    txtMES.Text = "3";
                    lbMES2.Text = "Marzo";
                }
                else if (mes == "Abril")
                {
                    txtMES.Text = "4";
                    lbMES2.Text = "Abril";
                }
                else if (mes == "Mayo")
                {
                    txtMES.Text = "5";
                    lbMES2.Text = "Mayo";
                }
                else if (mes == "Junio")
                {
                    txtMES.Text = "6";
                    lbMES2.Text = "Junio";
                }
                else if (mes == "Julio")
                {
                    txtMES.Text = "7";
                    lbMES2.Text = "Julio";
                }
                else if (mes == "Agosto")
                {
                    txtMES.Text = "8";
                    lbMES2.Text = "Agosto";
                }
                else if (mes == "Septiembre")
                {
                    txtMES.Text = "9";
                    lbMES2.Text = "Septiembre";
                }
                else if (mes == "Octubre")
                {
                    txtMES.Text = "10";
                    lbMES2.Text = "Octubre";
                }
                else if (mes == "Noviembre")
                {
                    txtMES.Text = "11";
                    lbMES2.Text = "Noviembre";
                }
                else if (mes == "Diciembre")
                {
                    txtMES.Text = "12";
                    lbMES2.Text = "Diciembre";
                }
                else
                    txtMES.Text = "Mes";
            }
            catch (Exception)
            { }
        }

        private void FrmExportarPeriodicamente_Load(object sender, EventArgs e)
        {

            ultimo_exportado();
            sugerir();
            cambiar_mes();
        }

        private void txtAÑOEX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMESEX_TextChanged(object sender, EventArgs e)
        {
            string mes = txtMESEX.Text;
            if (mes == "1")
                lbMES.Text = "Enero";
            else if (mes == "2")
                lbMES.Text = "Febrero";
            else if (mes == "3")
                lbMES.Text = "Marzo";
            else if (mes == "4")
                lbMES.Text = "Abril";
            else if (mes == "5")
                lbMES.Text = "Mayo";
            else if (mes == "6")
                lbMES.Text = "Junio";
            else if (mes == "7")
                lbMES.Text = "Julio";
            else if (mes == "8")
                lbMES.Text = "Agosto";
            else if (mes == "9")
                lbMES.Text = "Septiembre";
            else if (mes == "10")
                lbMES.Text = "Octubre";
            else if (mes == "11")
                lbMES.Text = "Noviembre";
            else if (mes == "12")
                lbMES.Text = "Diciembre";
            else
                lbMES.Text = "Mes";
        }

        private void txtMESEX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(ruta_venta);

            System.IO.File.Delete(ruta_tiempo);
            using (StreamWriter Oarchivo = File.CreateText(ruta_venta))
            using (StreamWriter Oarchivo2 = File.CreateText(ruta_tiempo))
            {   }

            txtAÑO.Text = "";
            txtMES.Text = "";
            txtAÑOEX.Text = "";
            txtMESEX.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
