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
    public partial class frmTarjetaCredito : Form
    {
        public frmTarjetaCredito()
        {
            InitializeComponent();
        }

        private void frmTarjetaCredito_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void Limpiar()
        {
            lstClientes.SelectedIndex = -1;
            lstTarjeta.SelectedIndex = -1;
            lstTarjeta.Items.Clear();
            btnAgregar.Enabled = true;
            txtDescripcion.Text = "";
            txtLimite.Text = "";
            txtMonto.Text = "";
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
        /// Evento para Agregar una Tarjeta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validamos si se ingresaron todos los datos
            if (lstClientes.SelectedIndex == -1 || txtDescripcion.Text == "" || txtLimite.Text == "" || txtMonto.Text =="")
            {
                MessageBox.Show("Ingrese y Seleccione todos los datos", "Información");
            }
            else
            {
                // Instanciamos la clase TarjetaCredito
                TarjetaCredito laTarjeta = new TarjetaCredito();
                // nuestro objeto adqueire los valores del formulario
                laTarjeta.descripcion = txtDescripcion.Text;
                laTarjeta.monto = Convert.ToDecimal(txtMonto.Text);
                laTarjeta.limite = Convert.ToDecimal(txtLimite.Text);

                // Verificamos si se realizó el método
                if (TarjetaCredito.InsertarTarjetaCredito(laTarjeta, lstClientes.SelectedItem.ToString()))
                {
                    MessageBox.Show("Tarjeta Agregada", "Información");
                    ListarTarjetas();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }
            }
        }

        /// <summary>
        /// Evento para actualizar una tarjeta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex == -1 || lstTarjeta.SelectedIndex == -1 || txtDescripcion.Text == "" || txtLimite.Text == "" || txtMonto.Text == "")
            {
                MessageBox.Show("Ingrese y Seleccione todos los datos", "Información");
            }
            else
            {
                // Instanciamos la clase Tarjeta Credito
                TarjetaCredito laTarjeta = new TarjetaCredito();
                // Nuestro objeto adquiere los valores del formulario
                laTarjeta.descripcion = lstTarjeta.SelectedItem.ToString();
                laTarjeta.descripcionNueva = txtDescripcion.Text;
                laTarjeta.monto = Convert.ToDecimal(txtMonto.Text);
                laTarjeta.limite = Convert.ToDecimal(txtLimite.Text);

                if (TarjetaCredito.actualizarTarjetaCredito(laTarjeta, lstClientes.SelectedItem.ToString()))
                {
                    MessageBox.Show("Tarjeta del Cliente " + lstClientes.SelectedItem.ToString() + " Actualizada", "Información");
                    ListarTarjetas();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }
            }
        }

        /// <summary>
        /// Evento para eliminar una tarjeta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex == -1 || lstTarjeta.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione todos los datos", "Información");
            }
            else
            {
                // Instanciamos un objeto de tipo TarjetaCredito
                TarjetaCredito laTarjeta = new TarjetaCredito();
                laTarjeta.descripcion = lstTarjeta.SelectedItem.ToString();
                if (TarjetaCredito.EliminarTarjetaCredito(laTarjeta, lstClientes.SelectedItem.ToString()))
                {
                    MessageBox.Show("Tarjeta del Cliente  " + lstClientes.SelectedItem.ToString() + " Eliminada", "Información");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }
            }
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

        private void lstClientes_Click(object sender, EventArgs e)
        {
            ListarTarjetas();
        }

        /// <summary>
        /// Carga todas las tarjetas de un cliente
        /// </summary>
        private void ListarTarjetas()
        {
            // Limpiamos los items existentes
            lstTarjeta.Items.Clear();

            // Instanciamos la Clase TarjetaCredito
            TarjetaCredito laTarjeta = new TarjetaCredito();

            // Almacenamos todas las tarjetas existentes de un cliente
            List<TarjetaCredito> listaTarjetas = TarjetaCredito.LeerTodo(lstClientes.SelectedItem.ToString());

            // Si hay algun elemento en la lista, loa agregaremos al ListBox
            if (listaTarjetas.Any())
            {
                listaTarjetas.ForEach(tc => lstTarjeta.Items.Add(tc.descripcion.ToString()));
            }
            else
            {
                lstTarjeta.Items.Add("No hay tartejas");
            }
        }

        /// <summary>
        /// Carga la informacion de la tarjeta de un cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstTarjeta_Click(object sender, EventArgs e)
        {
            // Limpiamos los textbox
            txtDescripcion.Text = "";
            txtMonto.Text = "";
            txtLimite.Text = "";

            TarjetaCredito laTarjeta = TarjetaCredito.LeerInformacionTarjeta(lstClientes.SelectedItem.ToString(), lstTarjeta.SelectedItem.ToString());
            txtDescripcion.Text = laTarjeta.descripcion;
            txtMonto.Text = laTarjeta.monto.ToString();
            txtLimite.Text = laTarjeta.limite.ToString();
            btnAgregar.Enabled = false;

        }
    }
}
