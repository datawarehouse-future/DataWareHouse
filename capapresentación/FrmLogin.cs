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

            FrmPrincipal FrmPrincpal = new FrmPrincipal();

            FrmPrincpal.Show();
            
            

            /*
            string username = txtUsuario.Text.Trim();
            string pass = txtPassword.Text.Trim();

            if (rdLogin.Checked)
            {
                if (isValidPassword(username,pass))
                {
                                        
                }
                else
                {
                    MessageBox.Show("Los datos son incorrectos");
                }
            }
                
            else
            {

            }
            */
        } 
            

            /*
        private bool isValidPassword(string username, string password)
        {
            UserB
        }
            */
    }
}
