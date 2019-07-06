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
    public partial class frmGeneral : Form
    {
        public frmGeneral()
        {
            InitializeComponent();
        }
        string resp;
        DataTable FechaVenta = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            if (Convert.ToInt16(cbAÑODesde.Text)<Convert.ToInt16(cbAÑOHasta.Text))
            {
                      respuesta = MessageBox.Show("Se eliminará registros de exportación periodica, ¿esta seguro que desea continuar?","Confirmación",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (respuesta == DialogResult.Yes)
                    {
                        int AñoDesde, MesDesde, AñoHasta, MesHasta;
                        AñoDesde = Convert.ToInt16(cbAÑODesde.Text);
                        MesDesde = Convert.ToInt16(obtenerMes(cbMESDesde));
                        AñoHasta = Convert.ToInt16(cbAÑOHasta.Text);
                        MesHasta = Convert.ToInt16(obtenerMes(cbMEShasta));
                        int dias = DateTime.DaysInMonth(AñoHasta, MesHasta);
                        DateTime desde = new DateTime(AñoDesde, MesDesde, 1);
                        DateTime hasta = new DateTime(AñoHasta, MesHasta, dias);
                        if (checkDimensiones.Checked==true)
                        {
                        NcargaGeneral.Cargar_Dimensiones();
                        }
                        NcargaGeneral.Cargar(desde, hasta);

                        
                        File.Delete(@"C:\ARCHIVOS\venta.txt");
                        File.Delete(@"C:\ARCHIVOS\tiempo.txt");
                       
                        tmProgresaBar.Enabled = true;
                    }
            }
            else
            {
                if (Convert.ToInt16(cbAÑODesde.Text) == Convert.ToInt16(cbAÑOHasta.Text))
                {
                    if (obtenerMes(cbMESDesde) <=obtenerMes(cbMEShasta))
                    {

                        respuesta = MessageBox.Show("Se eliminará registros de exportación periodica, ¿esta seguro que desea continuar?", "Confirmación",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        if (respuesta == DialogResult.Yes)
                        {
                            int AñoDesde, MesDesde, AñoHasta, MesHasta;
                            AñoDesde = Convert.ToInt16(cbAÑODesde.Text);
                            MesDesde = Convert.ToInt16(obtenerMes(cbMESDesde));
                            AñoHasta = Convert.ToInt16(cbAÑOHasta.Text);
                            MesHasta = Convert.ToInt16(obtenerMes(cbMEShasta));
                            int dias = DateTime.DaysInMonth(AñoHasta, MesHasta);
                            DateTime desde = new DateTime(AñoDesde, MesDesde, 1);
                            DateTime hasta = new DateTime(AñoHasta, MesHasta, dias);
                            if (checkDimensiones.Checked == true)
                            {
                                NcargaGeneral.Cargar_Dimensiones();
                            }
                            NcargaGeneral.Cargar(desde, hasta);

                            File.Delete(@"C:\ARCHIVOS\venta.txt");
                            File.Delete(@"C:\ARCHIVOS\tiempo.txt");

                            tmProgresaBar.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error no se puede exportar error en los meses de exportacion","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        
                    }
                }
                else
                {
                    MessageBox.Show("Error no se puede exportar error en los meses de exportacion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                
            }
        }

        private void tmProgresaBar_Tick(object sender, EventArgs e)
        {
                progressBar1.Value = progressBar1.Value + 2;
                

            if (progressBar1.Value <= 50)
            {
                lbCARGANDO.Text = "Analizando datos..." + progressBar1.Value + " %";
            }
            else {
                lbCARGANDO.Text = "Cargando Ventas..." + progressBar1.Value + " %";
            }
                    
              if (progressBar1.Value == 100)
                {
                    tmProgresaBar.Enabled = false;
                     progressBar1.Value = 0;
                    lbCARGANDO.Text = "";
                DateTime fecha = DateTime.Today;
                string fecha_Actual = Convert.ToString(fecha.ToString("dd-MM-yyyy"));
                string hora = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
                resp = Nregistro_exportacion.RegistrarDW("1", cbMEShasta.Text, cbAÑOHasta.Text, hora, fecha_Actual);
                MessageBox.Show("Cargado de Datos Exitoso", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void frmGeneral_Load(object sender, EventArgs e)
        {
            FechaVenta = NcargaGeneral.ObtenerFechaInicioVenta();
            DataRow fila = FechaVenta.Rows[0];
            lbInicioVenta.Text="Ventas registradas desde el "+ fila["dia"].ToString()+" \nde "+fila["mes"]+" del "+fila["año"];

            FechaVenta = NcargaGeneral.ObtenerFechaFinVenta();
            fila = FechaVenta.Rows[0];
            lbFinVenta.Text = "Ultima venta registrada el " + fila["dia"].ToString() + " \nde " + fila["mes"] + " del " + fila["año"];

            cbAÑODesde.DisplayMember = "año";
            cbAÑODesde.ValueMember = "año";
            cbAÑODesde.DataSource = NcargaGeneral.ObtenerGestion();

            cbAÑOHasta.DisplayMember = "año";
            cbAÑOHasta.ValueMember = "año";
            cbAÑOHasta.DataSource = NcargaGeneral.ObtenerGestion();

        }
        private void cbAÑODesde_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMESDesde.ValueMember = "id_tiempo";
            cbMESDesde.DisplayMember = "mes";
            cbMESDesde.DataSource = NcargaGeneral.ObtenerMesesDeGestion(Convert.ToInt16(cbAÑODesde.Text),1);
         
        }
        private void cbAÑOHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMEShasta.ValueMember = "id_tiempo";
            cbMEShasta.DisplayMember = "mes";
            cbMEShasta.DataSource = NcargaGeneral.ObtenerMesesDeGestion(Convert.ToInt16(cbAÑOHasta.Text), 2);
        }
        private void cbMESDesde_SelectedIndexChanged(object sender, EventArgs e)
        {

    
        }

        public int obtenerMes(ComboBox cb) {
            int numero = 0;
            string mes = cb.Text;
            if (mes == "Enero")
                numero =1;
            else if (mes == "Febrero")
                numero = 2;
            else if (mes == "Marzo")
                numero = 3;
            else if (mes == "Abril")
                  numero = 4;
            else if (mes == "Mayo")
                numero = 5;
            else if (mes == "Junio")
                numero = 6;
            else if (mes == "Julio")
                numero = 7;
            else if (mes == "Agosto")
                numero = 8;
            else if (mes == "Septiembre")
                numero = 9;
            else if (mes == "Octubre")
                numero = 10;
            else if (mes == "Noviembre")
                numero = 11;
            else if (mes == "Diciembre")
                numero = 12;
            return numero;
        }

        private void lbInicioVenta_Click(object sender, EventArgs e)
        {

        }

        private void lbFinVenta_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            if (Convert.ToInt16(cbAÑODesde.Text) < Convert.ToInt16(cbAÑOHasta.Text))
            {
                respuesta = MessageBox.Show("Se eliminará registros de exportación periodica, ¿esta seguro que desea continuar?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (respuesta == DialogResult.Yes)
                {
                    int AñoDesde, MesDesde, AñoHasta, MesHasta;
                    AñoDesde = Convert.ToInt16(cbAÑODesde.Text);
                    MesDesde = Convert.ToInt16(obtenerMes(cbMESDesde));
                    AñoHasta = Convert.ToInt16(cbAÑOHasta.Text);
                    MesHasta = Convert.ToInt16(obtenerMes(cbMEShasta));
                    int dias = DateTime.DaysInMonth(AñoHasta, MesHasta);
                    DateTime desde = new DateTime(AñoDesde, MesDesde, 1);
                    DateTime hasta = new DateTime(AñoHasta, MesHasta, dias);
                    if (checkDimensiones.Checked == true)
                    {
                        NcargaGeneral.Cargar_Dimensiones();
                    }
                    NcargaGeneral.Cargar(desde, hasta);


                    File.Delete(@"C:\ARCHIVOS\venta.txt");
                    File.Delete(@"C:\ARCHIVOS\tiempo.txt");

                    tmProgresaBar.Enabled = true;
                }
            }
            else
            {
                if (Convert.ToInt16(cbAÑODesde.Text) == Convert.ToInt16(cbAÑOHasta.Text))
                {
                    if (obtenerMes(cbMESDesde) <= obtenerMes(cbMEShasta))
                    {

                        respuesta = MessageBox.Show("Se eliminará registros de exportación periodica, ¿esta seguro que desea continuar?", "Confirmación",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                        if (respuesta == DialogResult.Yes)
                        {
                            int AñoDesde, MesDesde, AñoHasta, MesHasta;
                            AñoDesde = Convert.ToInt16(cbAÑODesde.Text);
                            MesDesde = Convert.ToInt16(obtenerMes(cbMESDesde));
                            AñoHasta = Convert.ToInt16(cbAÑOHasta.Text);
                            MesHasta = Convert.ToInt16(obtenerMes(cbMEShasta));
                            int dias = DateTime.DaysInMonth(AñoHasta, MesHasta);
                            DateTime desde = new DateTime(AñoDesde, MesDesde, 1);
                            DateTime hasta = new DateTime(AñoHasta, MesHasta, dias);
                            if (checkDimensiones.Checked == true)
                            {
                                NcargaGeneral.Cargar_Dimensiones();
                            }
                            NcargaGeneral.Cargar(desde, hasta);

                            File.Delete(@"C:\ARCHIVOS\venta.txt");
                            File.Delete(@"C:\ARCHIVOS\tiempo.txt");

                            tmProgresaBar.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error no se puede exportar error en los meses de exportacion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
                else
                {
                    MessageBox.Show("Error no se puede exportar error en los meses de exportacion", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
