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
    public partial class FrmExportarGeneral : Form
    {
        public FrmExportarGeneral()
        {
            InitializeComponent();
        }
        string resp;
        int contador;
        DataTable tabla = new DataTable();
        /*SP de dimensiones*/
        string sp_seguro = "sp_SeleccionarSeguro";
        string sp_UnidadNegocio = "sp_Seleccionar_unidadNegocio";
        string sp_medicoEnvia = "sp_SeleccionarMedicoEnvia";
        string sp_Usuarios = "sp_SeleccionarUsuarios";
        string sp_MedicoServicio = "sp_SeleccionarMedicoServicio";
        string sp_Servicio = "sp_SeleccionarServicio";
        string sp_Cliente = "sp_SeleccionarClientes";
        string sp_GrupoServicio = "sp_SeleccionarGrupoServicio";
        /*Direcciones donde se guardara los datos de dimensiones en archivo de texto*/
        string ruta_Dseguro = "C:/ARCHIVOS/seguros.txt";
        string ruta_DunidadNegocio = "C:/ARCHIVOS/unidad_negocio.txt";
        string ruta_DmedicoEnvia = "C:/ARCHIVOS/medico_envia.txt";
        string ruta_Dusuarios = "C:/ARCHIVOS/usuarios.txt";
        string ruta_DmedicoServicio ="C:/ARCHIVOS/medico_servicio.txt";
        string ruta_Dservicio = "C:/ARCHIVOS/servicio.txt";
        string ruta_Dcliente = "C:/ARCHIVOS/cliente.txt";
        string ruta_D_grupoServicio = "C:/ARCHIVOS/gruposervicio.txt";

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbUbicacion.Text == "")
            {
                MessageBox.Show("Seleccione ubicación para la exportacion de datos!", "Sistema DW Future", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else {
                lbBOT.Text = lbUbicacion.Text;
                timer1.Enabled = true;
                contador = 0;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            contador++;
            if (contador == 1)
            {
                pbSeguro.Image = Properties.Resources.bien;
                pbSeguro.Visible = true;
                tabla = Ntabla_dimensiones.Dimension(sp_seguro);
                Guardar_archivo(ruta_Dseguro, tabla);
            }
         if (contador == 3)
            {
                pbUN.Visible = true;
                pbUN.Image = Properties.Resources.bien;
                tabla = Ntabla_dimensiones.Dimension(sp_UnidadNegocio);
                Guardar_archivo(ruta_DunidadNegocio, tabla);
            }
            if (contador == 5)
            {
                pbUsuarios.Visible = true;
                pbUsuarios.Image = Properties.Resources.bien;
                tabla = Ntabla_dimensiones.Dimension(sp_medicoEnvia);
                Guardar_archivo(ruta_DmedicoEnvia, tabla);
            }
           if (contador == 7)
            {
                pbServicios.Visible = true;
                pbServicios.Image = Properties.Resources.bien;
                tabla = Ntabla_dimensiones.Dimension(sp_Usuarios);
                Guardar_archivo(ruta_Dusuarios, tabla);
            }
         if (contador == 9)
              {
                pbMedicoEnvia.Visible = true;
                pbMedicoEnvia.Image = Properties.Resources.bien;
                tabla = Ntabla_dimensiones.Dimension(sp_MedicoServicio);
                Guardar_archivo(ruta_DmedicoServicio, tabla);
            }
            if (contador == 11)
            {
                pbMedicoServicio.Visible = true;
                pbMedicoServicio.Image = Properties.Resources.bien;
                tabla = Ntabla_dimensiones.Dimension(sp_Servicio);
                Guardar_archivo(ruta_Dservicio, tabla);
            }
            if (contador == 11)
            {
                pbGRUPO.Visible = true;
                pbGRUPO.Image = Properties.Resources.bien;
                tabla = Ntabla_dimensiones.Dimension(sp_GrupoServicio);
                Guardar_archivo(ruta_D_grupoServicio, tabla);
            }
            if (contador == 14)
            {
                pbCliente.Visible = true;
                pbCliente.Image = Properties.Resources.bien;
                tabla = Ntabla_dimensiones.Dimension(sp_Cliente);
                Guardar_archivo(ruta_Dcliente, tabla);
            }
            if (contador == 14)
            {
                timer1.Enabled = false;
                MessageBox.Show("Se ha exportado los datos correctamente", "Sistema DW Future", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  visible(false);
                  DateTime fecha = DateTime.Today;
                  string hora = DateTime.Now.Hour.ToString("D2") + ":" + DateTime.Now.Minute.ToString("D2") + ":" + DateTime.Now.Second.ToString("D2");
                  resp = Noperaciones.Registrar(1, "Exportacion de todas las dimensiones", hora, fecha);
                  visible(false);

            }
        }
        public void Guardar_archivo(string pruta, DataTable tabla)
        {
            using (StreamWriter Oarchivo = File.CreateText(pruta))
            {}
            StreamWriter ESCRIBIR = File.AppendText(pruta);
            try
            {
                string Linea = "";
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    Linea = tabla.Rows[i][0].ToString() + "|" +
                            tabla.Rows[i][1].ToString();
                    ESCRIBIR.WriteLine(Linea);
                }
               ESCRIBIR.Close();
            }
            catch (Exception)
            {ESCRIBIR.Close();}
        }
        public void visible(bool bandera)
        {
            pbUN.Visible = bandera;
            pbSeguro.Visible = bandera;
            pbUsuarios.Visible = bandera;
            pbServicios.Visible = bandera;
            pbMedicoEnvia.Visible = bandera;
            pbMedicoServicio.Visible = bandera;
            pbGRUPO.Visible = bandera;
            pbCliente.Visible = bandera;
        }
        private void label36_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {


            if (lbUbicacion.Text == "")
            {
                MessageBox.Show("Seleccione ubicación para la exportacion de datos!", "Sistema DW Future", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                lbBOT.Text = lbUbicacion.Text;
                timer1.Enabled = true;
                contador = 0;
            }
        }
        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
