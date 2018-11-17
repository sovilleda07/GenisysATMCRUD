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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarListBox();
        }

        /// <summary>
        /// Método para limpiar todos los campos
        /// </summary>
        private void Limpiar()
        {
            txtIdentidad.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCelular.Text = "";
            txtIdentidad.Enabled = true;
            txtIdentidad.Focus();
            btnAgregar.Enabled = true;
            lbClientes.SelectedIndex = -1;
        }

        /// <summary>
        /// Evento para Agregar Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validamos si se ingresaron todos los datos
            if (txtIdentidad.Text == "" || txtNombres.Text == "" || txtApellidos.Text == "" || txtIdentidad.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtCelular.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos", "Información");
            }
            else
            {
                //Instanciamos la Clase Cliente
                Cliente nuevo = new Cliente();
                //nuestro objeto adquiere los valores del formulario
                nuevo.nombres = txtNombres.Text;
                nuevo.apellidos = txtApellidos.Text;
                nuevo.identidad = txtIdentidad.Text;
                nuevo.direccion = txtDireccion.Text;
                nuevo.telefono = txtTelefono.Text;
                nuevo.celular = txtCelular.Text;

                // Verificamos si se realizó el método
                if (Cliente.InsertarCliente(nuevo))
                {
                    MessageBox.Show("Cliente Agregado", "Información");
                    ListarListBox();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos","Informacion");
                }


            }        
                       
        }
        
        /// <summary>
        /// Evento para Actualizar el Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Verificar que se seleccionó un elemento de la lista
            if (lbClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Favor Seleccionar un cliente de la lista para actualizar", "Información");
            }
            else
            {
                // Verificamos si se llenaron los datos
                if (txtIdentidad.Text == "" || txtNombres.Text == "" || txtApellidos.Text == "" || txtIdentidad.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtCelular.Text == "")
                {
                    MessageBox.Show("Ingrese todos los datos", "Información");
                }
                else
                {
                    //Instanciamos la Clase Cliente
                    Cliente actualizar = new Cliente();
                    //nuestro objeto adquiere los valores del formulario
                    actualizar.nombres = txtNombres.Text;
                    actualizar.apellidos = txtApellidos.Text;
                    actualizar.identidad = txtIdentidad.Text;
                    actualizar.direccion = txtDireccion.Text;
                    actualizar.telefono = txtTelefono.Text;
                    actualizar.celular = txtCelular.Text;

                    if (Cliente.actualizarCliente(actualizar))
                    {
                        MessageBox.Show("Actualizado");
                        ListarListBox();
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                }
            }                  
                     
        }

        /// <summary>
        /// Método para listar todos los clientes en el list box 
        /// al cargar el formulario y al realizarse cualquier otra acción.
        /// </summary>
        private void ListarListBox()
        {
            // Limpiamos los items existentes
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

        /// <summary>
        /// Evento para eliminar el cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            // Verificar que se seleccionó un elemento de la lista
            if (lbClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Favor Seleccionar un cliente de la lista para eliminar", "Información");
            }
            else
            {
                // Instanciamos un objeto de tipo Cliente
                Cliente elCliente = new Cliente();

                // Obtenemos el nombre y apellido del cliente seleccionado en el list box
                elCliente.nombres = lbClientes.SelectedItem.ToString();
                elCliente.identidad = txtIdentidad.Text;

                if (Cliente.eliminarCliente(elCliente))
                {
                    MessageBox.Show("Cliente Eliminado","Informacion");
                    ListarListBox();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha Ocurrido un error", "Informacion");
                }
                
            }
        }

        /// <summary>
        /// Evento click para que cuando se seleccione
        /// Un elemento del ListBox, traiga los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbClientes_Click(object sender, EventArgs e)
        {
            // Creamos un objeto de tipo Cliente
            Cliente elCliente = new Cliente();

            // Obtenemos la información del cliente, enviando su nombre
            elCliente= Cliente.ObtenerInformacionCliente(lbClientes.SelectedItem.ToString());

            txtNombres.Text = elCliente.nombres;
            txtApellidos.Text = elCliente.apellidos;
            txtIdentidad.Text = elCliente.identidad;
            txtIdentidad.Enabled = false;
            txtDireccion.Text = elCliente.direccion;
            txtTelefono.Text = elCliente.telefono;
            txtCelular.Text = elCliente.celular;
            btnAgregar.Enabled = false;

        }

        /// <summary>
        /// Evento para limpiar la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
