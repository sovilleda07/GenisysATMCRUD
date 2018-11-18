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

        private void btnConfiguración_Click(object sender, EventArgs e)
        {
            frmConfiguracion configuracion = new frmConfiguracion();
            configuracion.ShowDialog();
        }

        private void btnServicioCliente_Click(object sender, EventArgs e)
        {
            frmServicioCliente scliente = new frmServicioCliente();
            scliente.ShowDialog();
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            frmTarjetaCredito tarjeta = new frmTarjetaCredito();
            tarjeta.ShowDialog();
        }

        private void btnCuentaCliente_Click(object sender, EventArgs e)
        {
            frmCuentaCliente cuenta = new frmCuentaCliente();
            cuenta.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elaborado Por: Sonia Villeda \nPOO IIIP 2018", "Información", MessageBoxButtons.OK);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
