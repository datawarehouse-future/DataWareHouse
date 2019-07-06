using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
namespace CapaPresentación
{
    public partial class Frm_Operaciones : Form
    {
        public Frm_Operaciones()
        {
            InitializeComponent();
        }

        private void Frm_Operaciones_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Noperaciones.Mostrar();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Noperaciones.Mostrar_parametro(txtBuscar.Text, cbxFiltro.Text, dmDESDE.Value, dmHASTA.Value);
        }
    }
}
