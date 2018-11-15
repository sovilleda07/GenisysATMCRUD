using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenisysATM.Models;

namespace GenisysATMCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Instanciamos la Clase Cliente
            Cliente nuevo = new Cliente();
            nuevo.nombres = txtNombres.Text;
            nuevo.apellidos = txtApellidos.Text;
            nuevo.identidad = txtIdentidad.Text;
            nuevo.direccion = txtDireccion.Text;
            nuevo.telefono = txtTelefono.Text;
            nuevo.celular = txtCelular.Text;

            if (Cliente.InsertarCliente(nuevo))
            {
                MessageBox.Show("Agregado");
                ListarListBox();
            }
            else
            {
                MessageBox.Show("Error");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarListBox();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void ListarListBox()
        {
            lbClientes.Items.Clear();
            // Instanciamos la Clase Cliente
            Cliente elCliente = new Cliente();

            // Almacenamos todos los clientes existentes
            List<Cliente> listaClientes = Cliente.LeerTodos();

            if (listaClientes.Any())
            {
                listaClientes.ForEach(client => lbClientes.Items.Add(client.nombres.ToString() + "  " + client.apellidos.ToString()));

            }
            else
            {
                lbClientes.Items.Add("No hay Clientes disponibles");
            }
        }
    }
}
