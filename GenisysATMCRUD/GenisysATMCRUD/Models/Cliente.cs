using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Agregar los namespaces necesarios
using System.Data;
using System.Data.SqlClient;

namespace GenisysATM.Models
{
    class Cliente
    {
        // Propiedades
        public int id { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string identidad { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }

        // Métodos
        /// <summary>
        /// Obtiene un cliente desde la tabla ATM.Cliente
        /// </summary>
        /// <param name="identidad">La identidad del cliente (13 caracteres)</param>
        /// <returns>Un objeto de tipo Cliente.</returns>
        public static Cliente ObtenerCliente(string identidad)
        {
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");
            string sql;
            Cliente resultado = new Cliente();

            // Query SQL
            sql = @"SELECT *
                    FROM ATM.Cliente
                    WHERE identidad = @identidad";

            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@identidad", SqlDbType.Char, 13).Value = identidad;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.id = rdr.GetInt16(0);
                    resultado.nombres = rdr.GetString(1);
                    resultado.apellidos = rdr.GetString(2);
                    resultado.identidad = rdr.GetString(3);
                    resultado.direccion = rdr.GetString(4);
                    resultado.telefono = rdr.GetString(5);
                    resultado.celular = rdr.GetString(6);

                    // Remover espacios
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

        /// <summary>
        /// Método para la inserción de datos del Cliente
        /// </summary>
        public static bool InsertarCliente(Cliente nuevoCliente)
        {
            // instanciamos la conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");
            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_insertarCliente");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;


            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 100));
            cmd.Parameters["@nombre"].Value = nuevoCliente.nombres;
            cmd.Parameters.Add(new SqlParameter("@apellido", SqlDbType.NVarChar, 100));
            cmd.Parameters["@apellido"].Value = nuevoCliente.apellidos;
            cmd.Parameters.Add(new SqlParameter("@identidad", SqlDbType.Char, 13));
            cmd.Parameters["@identidad"].Value = nuevoCliente.identidad;
            cmd.Parameters.Add(new SqlParameter("@direccion", SqlDbType.NVarChar, 2000));
            cmd.Parameters["@direccion"].Value = nuevoCliente.direccion;
            cmd.Parameters.Add(new SqlParameter("@telefono", SqlDbType.Char, 9));
            cmd.Parameters["@telefono"].Value = nuevoCliente.telefono;
            cmd.Parameters.Add(new SqlParameter("@celular", SqlDbType.Char, 9));
            cmd.Parameters["@celular"].Value = nuevoCliente.celular;

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
        /// Método para listar todos los clientes
        /// </summary>
        /// <returns>Una lista con todos los clientes</returns>
        public static List<Cliente> LeerTodos()
        {
            // instanciamos la clase conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");

            // Lista una de tipo de Cliente
            List<Cliente> resultados = new List<Cliente>();

            // Creamos el query
            string sql = @"SELECT id, nombres, apellidos, identidad, direccion, telefono, celular
                            FROM ATM.Cliente";

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando(sql);

            
            try
            {
                // Establecemos la conexions
                conexion.EstablecerConexion();
                // Ejecutamos el query vía un ExecuteReader
                SqlDataReader rdr = cmd.ExecuteReader();

                // Recorremos los elementos del Reader y los almacenamos
                // en la lista de tipo Cliente
                while (rdr.Read())
                {
                    Cliente elCliente = new Cliente();
                    // Asignamos los valores de Reader al objeto Cliente
                    elCliente.id = Convert.ToInt16(rdr[0]);
                    elCliente.nombres = rdr.GetString(1);
                    elCliente.apellidos = rdr.GetString(2);
                    elCliente.identidad = rdr.GetString(3);
                    elCliente.direccion = rdr.GetString(4);
                    elCliente.telefono = rdr.GetString(5);
                    elCliente.celular = rdr.GetString(6);

                    // Agregamos el Cliente a la lista
                    resultados.Add(elCliente);
                }
                // retornamos la lista de los clientes
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
        /// Método para la eliminación de un cliente
        /// </summary>
        /// <param name="elCliente"></param>
        /// <returns></returns>
        public static bool eliminarCliente(Cliente elCliente)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_EliminarCliente");

            // Definimos que tipo de comando es
            cmd.CommandType = CommandType.StoredProcedure;

            // Definimos los parametros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 100));
            cmd.Parameters["@nombre"].Value = elCliente.nombres;

            //cmd.Parameters.Add(new SqlParameter("@apellido", SqlDbType.NVarChar, 100));
            //cmd.Parameters["@apellido"].Value = elCliente.apellidos;

            try
            {
                // Establecemos la conexion
                conexion.EstablecerConexion();

                // Ejecutamos el query de eliminacion
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }





        //-------DANGER----

        /// <summary>
        /// ARREGLAR
        /// </summary>
        /// <param name="elCliente"></param>
        /// <returns></returns>
        public static bool actualizarCliente(Cliente elCliente)
        {
            // instanciamos la clase conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");
            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_actualizarCliente");

            // definimos el tipo de comando
            cmd.CommandType = CommandType.StoredProcedure;

            return true;

        }

    }
}
