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

            // Si hay algun elemento en la lista
            // Lo agregaremos al listbox
            if (listaClientes.Any())
            {
                // listaClientes.ForEach(client => lbClientes.Items.Add(client.nombres.ToString() + "  " + client.apellidos.ToString()));
                listaClientes.ForEach(client => lbClientes.Items.Add(client.nombres.ToString()));

            }
            // sino, mostraremos un mensaje
            else
            {
                lbClientes.Items.Add("No hay Clientes disponibles");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Instanciamos un objeto de tipo Cliente
            Cliente elCliente = new Cliente();

            // Verificar que se seleccionó un elemento de la lista
            if (lbClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Favor Seleccionar un cliente de la lista para eliminar", "Información");
            }
            else
            {
                // Obtenemos el nombre y apellido del cliente seleccionado en el list box
                elCliente.nombres = lbClientes.SelectedItem.ToString();

                if (Cliente.eliminarCliente(elCliente))
                {
                    MessageBox.Show("Cliente Eliminado","Informacion");
                    ListarListBox();
                }
                else
                {
                    MessageBox.Show("Ha Ocurrido un error", "Informacion");
                }
                
            }
        }

    }
}
