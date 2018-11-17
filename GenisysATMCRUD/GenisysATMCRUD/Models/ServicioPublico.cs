using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregar los namespaces necesarios
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GenisysATM.Models
{
    class ServicioPublico
    {
        // Propiedades
        public int id { get; set; }
        public string descripcion { get; set; }
        public string descripcionNueva { get; set; }

        // Constructores
        public ServicioPublico() { }

        // Métodos

        /// <summary>
        /// Método para listar todo los servicios publicos
        /// Utilizado en el ListBox
        /// </summary>
        /// <returns>Una lista con toso los servicios</returns>
        public static List<ServicioPublico> LeerTodo()
        {
            // instanciamos la clase conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");

            // Lista una de tipo de ServicioPublico
            List<ServicioPublico> resultados = new List<ServicioPublico>();

            // Creamos el query
            string sql = @"SELECT id, Descripcion
                            FROM ATM.ServicioPublico";

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando(sql);

            try
            {
                // Establecemos la conexion
                conexion.EstablecerConexion();
                // Ejecutamos el query vía un ExecuteReader
                SqlDataReader rdr = cmd.ExecuteReader();

                // Recorremos los elemtos del Reader y los almacenamos
                // en la lista de tipo ServicioPublico
                while (rdr.Read())
                {
                    ServicioPublico elServicio = new ServicioPublico();

                    // Asignamos los valores de Reader al objeto Cliente
                    elServicio.id = Convert.ToInt16(rdr[0]);
                    elServicio.descripcion = rdr.GetString(1);

                    // Agregamos El Servicio a la lista
                    resultados.Add(elServicio);
                }
                // Retornamos la lista de los servicios
                return resultados;

            }
            catch (SqlException)
            {
                return resultados; 
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        /// <summary>
        /// Método para insertar un servicio publcio
        /// </summary>
        /// <param name="elServicio"></param>
        /// <returns></returns>
        public static bool InsertarServicio(ServicioPublico elServicio)
        {
            // instanciamos la conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");
            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_InsertarServicioP");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 100));
            cmd.Parameters["@descripcion"].Value = elServicio.descripcion;

            // intentamos ejecutar el procedimiento
            try
            {
                conexion.EstablecerConexion();

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                // MessageBox.Show(ex.StackTrace);

                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }   
        
        /// <summary>
        /// Método para actualizar un servicio
        /// </summary>
        /// <param name="elServicio"></param>
        /// <returns>Un objeto de tipo ServicioPublico</returns>
        public static bool ActualizarServicio(ServicioPublico elServicio)
        {
            // instanciamos la conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");
            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_ActualizarServicioP");

            // definimos el tipo de comando
            cmd.CommandType = CommandType.StoredProcedure;

            // Declaramos los parámetros necesarios
            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 100));
            cmd.Parameters["@descripcion"].Value = elServicio.descripcion;

            cmd.Parameters.Add(new SqlParameter("@descripcionNueva", SqlDbType.NVarChar, 100));
            cmd.Parameters["@descripcionNueva"].Value = elServicio.descripcionNueva;

            // intentamos ejecutar el procedimiento
            try
            {
                conexion.EstablecerConexion();

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                // MessageBox.Show(ex.StackTrace);

                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }


        }

        /// <summary>
        /// Método para Eliminar un Servicio
        /// </summary>
        /// <param name="elServicio"></param>
        /// <returns>Un objeto de tipo ServicioPublico</returns>
        public static bool EliminarServicio(ServicioPublico elServicio)
        {
            // instanciamos la conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");
            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_EliminarServicioP");

            // Definimos que tipo de comando es
            cmd.CommandType = CommandType.StoredProcedure;

            // Definimos los parametros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 100));
            cmd.Parameters["@descripcion"].Value = elServicio.descripcion;

            try
            {
                // Establecemos la conexion
                conexion.EstablecerConexion();

                // Ejecutamos el query vía un ExecuteNonQuery
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (SqlException ex)
            {
                
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }


        }

        public static ServicioPublico ObtenerInformacion(string descripcion)
        {
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");
            ServicioPublico resultado = new ServicioPublico();

            // Query SQL
            string sql = @"SELECT *
                    FROM ATM.ServicioPublico
                    WHERE descripcion = @descripcion";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@descripcion", SqlDbType.NVarChar, 100).Value = descripcion;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.id = Convert.ToInt16(rdr[0]);
                    resultado.descripcion = rdr.GetString(1);
                }

                return resultado;
            }
            catch (SqlException ex)
            {
                return resultado;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }


    }
}
