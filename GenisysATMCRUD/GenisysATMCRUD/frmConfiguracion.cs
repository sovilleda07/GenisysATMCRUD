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
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            ListarListBox();
        }

        private void Limpiar()
        {
            txtAppKey.Text = "";
            txtValor.Text = "";
            txtDescripcion.Text = "";
            btnAgregar.Enabled = true;
            lstConfiguracion.SelectedIndex = -1;
            txtAppKey.Focus();
        }

        /// <summary>
        /// Método para listar todas las Configuraciones en el listbox
        /// Al cargar el formulario y al realizarse cualquier otra acción.
        /// </summary>
        private void ListarListBox()
        {
            // Limpiamos los items existentes
            lstConfiguracion.Items.Clear();

            // Instanciamos la Clase ServicioPublico
            Configuracion laConfiguracion = new Configuracion();

            // Almacenamos todos las configuraciones
            List<Configuracion> listaConfiguraciones = Configuracion.LeerTodos();

            // Si hay algun elemento en la lista
            // Lo agregamos al ListBox
            if (listaConfiguraciones.Any())
            {
                listaConfiguraciones.ForEach(conf => lstConfiguracion.Items.Add(conf.appKey.ToString()));
            }
            // sino, mostraremos un mensaje
            else
            {
                lstConfiguracion.Items.Add("No hay Configuraciones Disponibles");
            }
        }

        /// <summary>
        /// Evento para agregar Configuración
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtAppKey.Text == "" || txtValor.Text == "" || txtDescripcion.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos", "Información");
            }
            else
            {
                // Instanciamos la Clase
                Configuracion laConfiguracion = new Configuracion();
                //nuestro objeto adquiere los valores del formulario.
                laConfiguracion.appKey = txtAppKey.Text;
                laConfiguracion.valor = txtValor.Text;
                laConfiguracion.descripcion = txtDescripcion.Text;

                // Verificamos si se realizó el método
                if (Configuracion.InsertarConfiguracion(laConfiguracion))
                {
                    MessageBox.Show("Configuracion Agregada", "Información");
                    ListarListBox();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, verifique los datos", "Información");
                }
                 
            }
        }

        /// <summary>
        /// Evento para Actualizar una Configuración
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Verificamos que se seleccionó un elemento de la lista
            if (lstConfiguracion.SelectedIndex == -1)
            {
                MessageBox.Show("Favor Seleccionaruna Configuracion de la lista para actualizar", "Información");
            }
            else
            {
                // Verificamos si se llenaron los datos
                if (txtAppKey.Text == "" || txtValor.Text == "" || txtDescripcion.Text == "")
                {
                    MessageBox.Show("Ingrese todos los datos", "Información");
                }
                else
                {
                    // Instanciamos la clase
                    Configuracion laConfiguracion = new Configuracion();

                    //nuestro objeto adquiere los valores del formulario
                    laConfiguracion.appKey = lstConfiguracion.SelectedItem.ToString();
                    laConfiguracion.appKeyNuevo = txtAppKey.Text;
                    laConfiguracion.valor = txtValor.Text;
                    laConfiguracion.descripcion = txtDescripcion.Text;

                    if (Configuracion.actualizarConfiguracion(laConfiguracion))
                    {
                        MessageBox.Show("Configuración Actualizada", "Información");
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
        /// Evento para Eliminar una Configuración
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar que se seleccionó un elemento de la lista
            if (lstConfiguracion.SelectedIndex == -1)
            {
                MessageBox.Show("Favor Seleccionar una Configuración de la lista para eliminar", "Información");
            }
            else
            {
                // Instanciamos un objeto de tipo Configuracion
                Configuracion laConfiguracion = new Configuracion();
                laConfiguracion.appKey = txtAppKey.Text;

                if (Configuracion.eliminarConfiguracion(laConfiguracion))
                {
                    MessageBox.Show("Configuración Eliminada", "Informacion");
                    ListarListBox();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha Ocurrido un error", "Informacion");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Evento click para que cuando se seleccione
        /// un elemento del listbox, traiga los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstConfiguracion_Click(object sender, EventArgs e)
        {
            // Creamos un Objeto de tipo Configuracion
            Configuracion laConfiguracion = new Configuracion();

            // Obtenemos la información, enviando el nombre
            laConfiguracion = Configuracion.ObtenerInformacionConfiguracion(lstConfiguracion.SelectedItem.ToString());

            txtAppKey.Text = laConfiguracion.appKey;
            txtValor.Text = laConfiguracion.valor;
            txtDescripcion.Text = laConfiguracion.descripcion;

            btnAgregar.Enabled = false;
        }


    }
}
