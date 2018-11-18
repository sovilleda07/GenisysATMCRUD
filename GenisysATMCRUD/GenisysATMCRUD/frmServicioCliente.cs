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
    public partial class frmServicioCliente : Form
    {
        public frmServicioCliente()
        {
            InitializeComponent();
        }


        private void frmServicioCliente_Load(object sender, EventArgs e)
        {
            ListarClientes();
            ListarServicio();
        }

        /// <summary>
        /// Método para limpiar la pantalla
        /// </summary>
        private void Limpiar()
        {
            lstClientes.SelectedIndex = -1;
            lstServicioP.SelectedIndex = -1;
            lstServicioCliente.SelectedIndex = -1;
            lstServicioCliente.Items.Clear();
            txtSaldo.Text = "";
            btnAgregar.Enabled = true;
        }

        /// <summary>
        /// Método que lista todos los clientes existentes
        /// </summary>
        private void ListarClientes()
        {
            // Limpiamos los items existentes
            lstClientes.Items.Clear();

            // Instanciamos la Clase Cliente
            Cliente elCliente = new Cliente();

            // Almacenamos todos los clientes existentes
            List<Cliente> listaClientes = Cliente.LeerTodos();

            // Si hay algun elemento en la lista
            // Lo agregaremos al listbox
            if (listaClientes.Any())
            {
               
                listaClientes.ForEach(client => lstClientes.Items.Add(client.nombres.ToString()));

            }
            // sino, mostraremos un mensaje
            else
            {
                lstClientes.Items.Add("No hay Clientes disponibles");
            }
        }

        /// <summary>
        /// Método que lista todos los Servicios Públicos
        /// </summary>
        private void ListarServicio()
        {
            // Limpiamos los items existentes
            lstServicioP.Items.Clear();

            // Instanciamos la Clase ServicioPublico
            ServicioPublico elServicio = new ServicioPublico();

            // Almacenamos todos los serviicos existentes
            List<ServicioPublico> listaServicios = ServicioPublico.LeerTodo();

            // Si hay algun elemento en la lista
            // Lo agregamos al ListBox
            if (listaServicios.Any())
            {
                listaServicios.ForEach(service => lstServicioP.Items.Add(service.descripcion.ToString()));
            }
            // sino, mostraremos un mensaje
            else
            {
                lstServicioP.Items.Add("No hay Servicios Disponibles");
            }
        }

        /// <summary>
        /// Evento para Agregar un ServicioCliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validamos si se ingresaron todos los datos
            if (lstClientes.SelectedIndex == -1 || lstServicioP.SelectedIndex == -1 || txtSaldo.Text == "")
            {
                MessageBox.Show("Ingrese y Seleccione todos los datos", "Información");
            }
            else
            {
                // Instanciamos la clase ServicioCliente
                ServicioCliente elSC = new ServicioCliente();
                // Nuestro objeto adquiere los valores del formulario
                elSC.saldo = Convert.ToDecimal(txtSaldo.Text);

                // Verificamos si se realizó el método
                if (ServicioCliente.insertarServicioCliente(elSC, lstClientes.SelectedItem.ToString(), lstServicioP.SelectedItem.ToString()))
                {
                    MessageBox.Show("Servicio Agregado", "Información");
                    ListarServiciosCliente();
                   // Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }
            }
        }

        /// <summary>
        /// Evento para actualizar un Servicio Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Verificamos que se seleccionó los datos necesarios
            if (lstClientes.SelectedIndex == -1 || lstServicioCliente.SelectedIndex == -1 || txtSaldo.Text == "")
            {
                MessageBox.Show("Ingrese y Seleccione todos los datos", "Información");
            }
            else
            {
                // Instanciamos la clase ServicioCliente
                ServicioCliente elSC = new ServicioCliente();
                // Nuestro objeto adquiere los valores del formulario
                elSC.saldo = Convert.ToDecimal(txtSaldo.Text);
                if (ServicioCliente.actualizarServicioCliente(elSC, lstClientes.SelectedItem.ToString(), lstServicioCliente.SelectedItem.ToString()))
                {
                    MessageBox.Show("Servicio del Cliente " + lstClientes.SelectedItem.ToString() + " Actualizado", "Información");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }
            }
        }

        /// <summary>
        /// Evento para eliminar un servicio de un cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificamos que se seleccionó los datos necesarios
            if (lstClientes.SelectedIndex == -1 || lstServicioCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione todos los datos", "Información");
            }
            else
            {
                // Instanciamos un objeto de tipo ServicioCliente
                ServicioCliente elSC = new ServicioCliente();
                if (ServicioCliente.eliminarServicioCliente(lstClientes.SelectedItem.ToString(), lstServicioCliente.SelectedItem.ToString()))
                {
                    MessageBox.Show("Servicio del Cliente " + lstClientes.SelectedItem.ToString() + " Eliminado", "Información");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        /// <summary>
        /// Evento para listar todos los servicios publicos de un cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstClientes_Click(object sender, EventArgs e)
        {
            ListarServiciosCliente();
            lblTitulo.Text = "Servicios de " + lstClientes.SelectedItem.ToString();
        }

        /// <summary>
        /// Carga todos los servicios de un cliente en específico
        /// </summary>
        private void ListarServiciosCliente()
        {
            //Limpiamos el textbox
            txtSaldo.Text = "";

            // Limpiamos los items existentes
            lstServicioCliente.Items.Clear();

            // Instanciamos la Clase ServicioCliente
            ServicioCliente elServicioC = new ServicioCliente();

            // Almacenmos todos los servicios existentes de un cliente
            List<ServicioCliente> listaSC = ServicioCliente.LeerTodos(lstClientes.SelectedItem.ToString());

            // Si hay algun elemento en la lista
            // Lo agregaremos al Listbox
            if (listaSC.Any())
            {
                listaSC.ForEach(sc => lstServicioCliente.Items.Add(sc.descripcionServicio.ToString()));
            }
            else
            {
                lstServicioCliente.Items.Add("No hay servicios del cliente");
            }
            
        }

        /// <summary>
        /// Carga la información del servicio de un cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstServicioCliente_Click(object sender, EventArgs e)
        {
            //Limpiamos el textbox
            txtSaldo.Text = "";

            ServicioCliente elSaldo = ServicioCliente.LeerSaldoServicio(lstClientes.SelectedItem.ToString(), lstServicioCliente.SelectedItem.ToString());
            txtSaldo.Text = Convert.ToString(elSaldo.saldo);
            btnAgregar.Enabled = false;            

        }
    }
}
