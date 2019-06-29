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
using System.Configuration;

namespace CapaPresentación
{
    public partial class FrmImportar : Form
    {
        public FrmImportar()
        {
            InitializeComponent();
        }
        int contador = 0;
        int contador2 = 0;
        string resp = "";
        bool bandera = false;
        /*Ruta de archivos de dimensiones y hecho*/
        string ruta_seguro = @"C:\ARCHIVOS\seguros.txt";
        string ruta_medico_envia = @"C:\ARCHIVOS\medico_envia.txt";
        string ruta_servicio = @"C:\ARCHIVOS\servicio.txt";
        string ruta_medico_servicio = @"C:\ARCHIVOS\medico_servicio.txt";
        string ruta_usuario = @"C:\ARCHIVOS\usuarios.txt";
        string ruta_unidad_negocio= @"C:\ARCHIVOS\unidad_negocio.txt";
        string ruta_cliente = @"C:\ARCHIVOS\cliente.txt";
        string ruta_tiempo = @"C:\ARCHIVOS\tiempo.txt";
        string ruta_venta = @"C:\ARCHIVOS\venta.txt";

        /*Sp de Carga de a la Bd*/
        string sp_seguro = "sp_SubirSeguro";
        string sp_medicoEnvia = "sp_SubirMedicoEnvia";
        string sp_servicio = "sp_SubirServicio";
        string sp_medicoServicio = "sp_SubirMedicoServicio";
        string sp_usuario = "sp_SubirUsuario";
        string sp_UnidadNegocio = "sp_Unidad_Negocio";
        string sp_cliente = "sp_SubirCliente";
        string sp_tiempo = "sp_SubirTiempo";
        string sp_venta = "sp_SubirVenta";
        private void button1_Click(object sender, EventArgs e)
        {
            btnAceptar2.Enabled = false;
            visible(false);
            visiblelab(false);
            tmExiste.Enabled = true;
            contador = 0;
            contador2 = 0;
            bandera = false;
        }

        private void tmExiste_Tick(object sender, EventArgs e)
        {
            FrmExportarPeriodicamente Frm = new FrmExportarPeriodicamente();

            

            contador++;
            if (contador == 1)
            {
                existe(ruta_seguro, pbSeguro);
            }
            if (contador == 10)
            {
                existe(ruta_medico_envia, pbMedicoEnvia);
            }
            if (contador == 15)
            {
                existe(ruta_servicio, pbServicio);  
            }
            if (contador == 20)
            {
                existe(ruta_medico_servicio, pbMedicoServicio);
            }
            if (contador == 25)
            {
                existe(ruta_usuario, pbUsuario);
            }
            if (contador == 30)
            {
                existe(ruta_unidad_negocio, pbUn);              
            }
            if (contador == 35)
            {
                existe(ruta_cliente, pbCliente);
            }
            if (contador == 40)
            {
                existe(ruta_tiempo, pbTiempo);  
            }
            if (contador == 45)
            {
                existe(ruta_venta, pbVenta);      
            }
            if (contador == 50)
            {
                tmOk.Enabled = false;
                if (bandera == true)
                {
                    MessageBox.Show("Error, Verifique los archivos para importar", "Sistema DW Future", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    btnAceptar2.Enabled = true;
                    visible(false);
                }
                else
                {
                    /*Existen todos los archivos */ 
                    button2.Enabled = true;
                    btnAceptar2.Enabled = true;
                    btnAceptar2.Enabled = true;
                }
            }
        }
        public void visible(bool bandera)
        {
            pbSeguro.Visible = bandera;
            pbMedicoEnvia.Visible = bandera;
            pbServicio.Visible = bandera;
            pbMedicoServicio.Visible = bandera;
            pbUsuario.Visible = bandera;
            pbUn.Visible = bandera;
            pbCliente.Visible = bandera;
            pbTiempo.Visible = bandera;
            pbVenta.Visible = bandera;

        }
        public void visiblelab(bool bandera)
        {
            lbSEGURO.Visible = bandera;
            lbMEDICOENVIA.Visible = bandera;
            lbSERVICIO.Visible = bandera;
            lbMedicoServicio.Visible = bandera;
            lbUSUARIO.Visible = bandera;
            lbUN.Visible = bandera;
            lbCLIENTE.Visible = bandera;
            lbTIEMPO.Visible = bandera;
            lbVENTA.Visible = bandera;
         
           
   
          
        }
        public void existe(string ruta,PictureBox pb) {

            pb.Visible = true;
            if (System.IO.File.Exists(ruta))
            {
                pb.Image = Properties.Resources.bien;
            }
            else
            {
                pb.Image = Properties.Resources.mal;
                bandera = true;
            }
        }

        private void tmOk_Tick(object sender, EventArgs e)
        {
            contador2++;
            if (contador2 == 1)
            {
                cargar(sp_seguro);
                lbSEGURO.Visible = true;
            }
            if (contador2 == 3)
            {
                cargar(sp_medicoEnvia);
                lbMEDICOENVIA.Visible = true;
            }
            if (contador2 == 5)
            {
                cargar(sp_servicio);
                lbSERVICIO.Visible = true;
            }
            if (contador2 == 7)
            {
                cargar(sp_medicoServicio);
                lbMedicoServicio.Visible = true;
            }
            if (contador2 == 9)
            {
                cargar(sp_usuario);
                lbUSUARIO.Visible = true;
            }

            if (contador2 == 11)
            {
                cargar(sp_UnidadNegocio);
                lbUN.Visible = true;
            }

            if (contador2 == 13)
            {
                cargar(sp_cliente);
                lbCLIENTE.Visible = true;
            }
            if (contador2 == 15)
            {
                cargar(sp_tiempo);
                lbTIEMPO.Visible = true;
            }
            if (contador2 == 17)
            {
                cargar(sp_venta);
                lbVENTA.Visible = true;
            }
            if (contador2 == 18)
            {

                tmOk.Enabled = false;
                /* Vaciar Archivo VENTAS */
                string path = @"C:\ARCHIVOS\venta.txt";
                string path1 = @"C:\ARCHIVOS\tiempo.txt";


                // This text is added only once to the file.
                if (File.Exists(path))
                {
                    /* Create a file to write to.
                    string createText = "Hello and Welcome" + Environment.NewLine;
                    File.WriteAllText(path, createText, Encoding.UTF8); */
                    File.Delete(path);
                    File.Delete(path1);
                }

                MessageBox.Show("Se han importado los datos correctamente", "Sistema DW Future", MessageBoxButtons.OK, MessageBoxIcon.Information);
                visible(false);
                visiblelab(false);
                btnAceptar2.Enabled = false;

               /* DateTime fecha = DateTime.Today;
                string fecha_Actual = Convert.ToString(fecha.ToString("dd-MM-yyyy"));
                string hora = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
                resp = Nregistrar_DW_imp.RegistrarDW_imp(Program.id_usuario, hora, fecha_Actual);*/
            }
        }

        private void btnACEPTAR_Click(object sender, EventArgs e)
        {
             tmOk.Enabled = true;
            contador2 = 0;
        }
        public void cargar(string sp) {
            resp = Ntabla_dimensiones.Cargar(sp);
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tmOk.Enabled = true;
            contador2 = 0;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            btnAceptar2.Enabled = false;
            visible(false);
            visiblelab(false);
            tmExiste.Enabled = true;
            contador = 0;
            contador2 = 0;
            bandera = false;
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmImportar_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
        private void FrmImportar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
