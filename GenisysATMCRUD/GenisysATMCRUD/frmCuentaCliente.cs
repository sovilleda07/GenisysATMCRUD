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
    public partial class frmCuentaCliente : Form
    {
        public frmCuentaCliente()
        {
            InitializeComponent();
        }

        private void frmCuentaCliente_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void Limpiar()
        {
            lstClientes.SelectedIndex = -1;
            lsCuenta.SelectedIndex = -1;
            lsCuenta.Items.Clear();
            btnAgregar.Enabled = true;
            txtNumero.Text = "";
            txtPin.Text = "";
            txtSaldo.Text = "";
        }

        /// <summary>
        /// Método para listar todos los clientes existentes
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
            if (lstClientes.SelectedIndex == -1 || txtNumero.Text == "" || txtPin.Text == "" || txtSaldo.Text =="")
            {
                MessageBox.Show("Ingrese y Seleccione todos los datos", "Información");
            }
            else
            {
                // Instanciamos la clase CuentaCliente
                CuentaCliente laCuenta = new CuentaCliente();
                // nuestro objeto adquiere los valores del formulario
                laCuenta.numero = txtNumero.Text;
                laCuenta.saldo = Convert.ToDecimal(txtSaldo.Text);
                laCuenta.pin = txtPin.Text;

                //Verificamos si se realizó el método
                if (CuentaCliente.InsertarCuentaCliente(laCuenta, lstClientes.SelectedItem.ToString()))
                {
                    MessageBox.Show("Cuenta Agregada", "Información");
                    //ListarTarjetas();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }
            }
        }

        /// <summary>
        /// Evento para Actualizar una Tarjeta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex == -1 || lsCuenta.SelectedIndex == -1 || txtNumero.Text == "" || txtPin.Text == "" || txtSaldo.Text == "")
            {
                MessageBox.Show("Ingrese y Seleccione todos los datos", "Informacion");
            }
            else
            {
                //Instanciamos la Clase Cuenta Cliente
                CuentaCliente laCuenta = new CuentaCliente();
                // Nuestro Objeto adquiere los valores del formulario
                laCuenta.numero = lsCuenta.SelectedItem.ToString();
                laCuenta.numeroNuevo = txtNumero.Text;
                laCuenta.saldo = Convert.ToDecimal(txtSaldo.Text);
                laCuenta.pin = txtPin.Text;

                // Verificamos si se realizó el métodos
                if (CuentaCliente.ActualizarCuentaCliente(laCuenta, lstClientes.SelectedItem.ToString()))
                {
                    MessageBox.Show("Cuenta del Cliente " + lstClientes.SelectedItem.ToString() + " Actualizada", "Información");
                    ListarCuentas();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Informacion");
                }
            }
        }

        /// <summary>
        /// Evento para Eliminar una Tarjeta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex == -1 || lsCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione todos los datos", "Información");
            }
            else
            {
                // Instanciamos un objeto de tipo CuentaCliente
                CuentaCliente laCuenta = new CuentaCliente();
                laCuenta.numero = lsCuenta.SelectedItem.ToString();
                if (CuentaCliente.EliminarCuentaCliente(laCuenta, lstClientes.SelectedItem.ToString()))
                {
                    MessageBox.Show("Cuenta del Cliente " + lstClientes.SelectedItem.ToString() + " Eliminada", "Información");
                    ListarCuentas();
                    Limpiar();
                }
            }
        }

        /// <summary>
        /// Evento para Limpiar la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void lstClientes_Click(object sender, EventArgs e)
        {
            ListarCuentas();
        }

        /// <summary>
        /// Método para cargar todas las tarjetas de un cliente
        /// </summary>
        private void ListarCuentas()
        {
            // Limpiamos los items existentes
            lsCuenta.Items.Clear();

            // Instancicamos la clase CuentaCliente
            CuentaCliente laCuenta = new CuentaCliente();

            // Almacenamos todas las cuentas existente de un cliente
            List<CuentaCliente> listaCuentas = CuentaCliente.LeerTodo(lstClientes.SelectedItem.ToString());

            // Si hay algun elemento en la lista, los agregamos al ListBox
            if (listaCuentas.Any())
            {
                listaCuentas.ForEach(cc => lsCuenta.Items.Add(cc.numero.ToString()));
            }
            else
            {
                lsCuenta.Items.Add("No hay cuentas");
            }
        }

        private void lsCuenta_Click(object sender, EventArgs e)
        {
            // Limpiamos los textbox
            txtNumero.Text = "";
            txtPin.Text = "";
            txtSaldo.Text = "";

            CuentaCliente laCuenta = CuentaCliente.ObtenerCliente(lsCuenta.SelectedItem.ToString());
            txtNumero.Text = laCuenta.numero;
            txtPin.Text = laCuenta.pin;
            txtSaldo.Text = laCuenta.saldo.ToString();
            btnAgregar.Enabled = false;


        }
    }
}
