using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using CapaNegocio;

namespace CapaPresentación
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IngresarSistema();


           
        } 
            

           
        private bool usuarioValido(string username, string password)
        {



            bool isValid = false;

            try
            {
                DataTable DataUser = new DataTable();
                DataUser = NUsuario.BuscarUsuario(username);

                DataRow row = DataUser.Rows[0];
                if (!string.IsNullOrEmpty(row["US_NombreUsuario"].ToString()))
                {
                    byte[] salt = (byte[])row["US_Salt"];
                    byte[] pass = (byte[])row["US_Pass"];
                    string nombreUsuario = row["US_NombreUsuario"].ToString();
                    byte[] hashedPassword = Cryptographic.HashPasswordWithSalt(Encoding.UTF8.GetBytes(password), salt);

                    if (hashedPassword.SequenceEqual(pass))
                        isValid = true;
                }
               
               
            }
            catch (Exception)
            {
                MessageBox.Show("Usuarios o Contraseñas incorrectos","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Error);
                isValid = false;
            }

            return isValid;


            /*   string UserForm = txtUsuario.Text;
               string nombreUsuario = row["US_NombreUsuario"].ToString(); */

        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
        
            
        }

       
private void GroupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                IngresarSistema();
            }
        }

        public void IngresarSistema()
        {
            string userName = txtUsuario.Text.Trim();
            string userPass = txtPassword.Text.Trim();

            if (usuarioValido(userName, userPass))
            {
                FrmPrincipal FrmPrincipal = new FrmPrincipal();
                FrmPrincipal.Show();
                this.Hide();
            }
            
        }
    }
}
