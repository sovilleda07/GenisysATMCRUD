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
    public partial class frmServicioPublico : Form
    {
        public frmServicioPublico()
        {
            InitializeComponent();
        }

        private void frmServicioPublico_Load(object sender, EventArgs e)
        {
            ListarListBox();
        }

        private void Limpiar()
        {
            txtDescripcion.Text = "";
            txtDescripcion.Focus();
            btnAgregar.Enabled = true;
            lstServicioP.SelectedIndex = -1;
        }

        /// <summary>
        /// Método para listar todos los Servicios en el list bos
        /// Al cargar el formulario y al realizarse cualquier otra acción.
        /// </summary>
        private void ListarListBox()
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
        /// Evento para agregar Servicio Publico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validamos si se ingresaron los datos
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos", "Información");
            }
            else
            {
                //Instanciamos la clase ServicioPublico
                ServicioPublico elServicio = new ServicioPublico();
                //nuestro objeto adquiere los valores del formulario.
                elServicio.descripcion = txtDescripcion.Text;

                // Verificamos si se realizó el método
                if (ServicioPublico.InsertarServicio(elServicio))
                {
                    MessageBox.Show("Servicio Agregado", "Información");
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
        /// Evento para Actualizar un Servicio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Verificamos que se seleccionó un elemento de la lista
            if (lstServicioP.SelectedIndex == -1)
            {
                MessageBox.Show("Favor Seleccionar un servicio de la lista para actualizar", "Información");
            }
            else
            {
                // Verificamos si se llenaron los datos
                if (txtDescripcion.Text == "")
                {
                    MessageBox.Show("Ingrese todos los datos", "Información");
                }
                else
                {
                    // Instanciamos la clase ServicioPublico
                    ServicioPublico elServicio = new ServicioPublico();

                    //nuestro objeto adquiere los valores del formulario
                    elServicio.descripcion = lstServicioP.SelectedItem.ToString();
                    elServicio.descripcionNueva = txtDescripcion.Text;

                    if (ServicioPublico.ActualizarServicio(elServicio))
                    {
                        MessageBox.Show("Servicio Actualizado");
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar que se seleccionó un elemento de la lista
            if (lstServicioP.SelectedIndex == -1)
            {
                MessageBox.Show("Favor Seleccionar un Servicio de la lista para eliminar", "Información");
            }
            else
            {
                // Instanciamos un objeto de tipo ServicioPublico
                ServicioPublico elServicio = new ServicioPublico();
                elServicio.descripcion = txtDescripcion.Text;

                if (ServicioPublico.EliminarServicio(elServicio))
                {
                    MessageBox.Show("Servicio Eliminado", "Informacion");
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
        /// un elementos del listbox, traiga los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstServicioP_Click(object sender, EventArgs e)
        {
            // Creamos un Objeto de tipo ServicioPublico
            ServicioPublico elServicio = new ServicioPublico();

            // Obtenemos la información, enviando la descripcion
            elServicio = ServicioPublico.ObtenerInformacion(lstServicioP.SelectedItem.ToString());

            txtDescripcion.Text = elServicio.descripcion;
            btnAgregar.Enabled = false;
        }
    }
}
