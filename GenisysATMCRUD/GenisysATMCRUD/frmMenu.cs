using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenisysATMCRUD
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.ShowDialog();
            //this.Hide();
        }

        private void btnServiciosPublicos_Click(object sender, EventArgs e)
        {
            frmServicioPublico servicioPublico = new frmServicioPublico();
            servicioPublico.ShowDialog();
            //this.Hide();
        }
    }
}
