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
    class ServicioCliente
    {
        // Propiedades
        public int id { get; set; }
        public int idCliente { get; set; }
        public int idServicio { get; set; }
        public decimal saldo { get; set; }
        public string descripcionServicio { get; set; }

        // Constructores
        public ServicioCliente() { }

        // Métodos

        /// <summary>
        /// Método para listar todos los servicios de un Cliente
        /// </summary>
        /// <returns>Una lista con todos los servicios de un cliente</returns>
        public static List<ServicioCliente> LeerTodos(string cliente)
        {
            // instanciamos la clase conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");

            // Lista de tipo ServicioCliente
            List<ServicioCliente> resultados = new List<ServicioCliente>();

            // Creamos el query
            string sql = @"DECLARE @clienteId INT
                           SELECT @clienteId = (SELECT id
                                                FROM ATM.Cliente
                                                WHERE nombres = @cliente)
                           SELECT sp.descripcion, sc.saldo
                           FROM ATM.ServicioPublico AS sp
                           INNER JOIN ATM.ServicioCliente AS sc
                           ON sc.idServicio = sp.id
                           AND sc.idCliente = @clienteId";

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@cliente", SqlDbType.NVarChar, 100).Value = cliente;

                }

                // Establecemos la conexion
                conexion.EstablecerConexion();
                // Ejecutamos el query vía un ExecuteReader
                rdr = cmd.ExecuteReader();


                // Recorremos los elementos del Reader y los almacenamos en la lista
                while (rdr.Read())
                {
                    ServicioCliente sv = new ServicioCliente();
                    sv.descripcionServicio = rdr.GetString(0);
                    sv.saldo = rdr.GetDecimal(1);

                    // Agregamos el Servicio a la lista
                    resultados.Add(sv);
                }
                // retornamos la lista de los servicios del cliente
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
        /// Método para Traer el id y el saldo del servicio de un cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="servicio"></param>
        /// <returns>Id y Saldo de un servicio de un cliente</returns>
        public static ServicioCliente LeerSaldoServicio(string cliente, string servicio)
        {
            // instanciamos la clase conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");

            // Objeto de tipo ServicioCliente
            ServicioCliente sv = new ServicioCliente();

            // Creamos el query
            string sql = @"DECLARE @clienteId INT
                           DECLARE @servicioId INT
                           SELECT @clienteId = (SELECT id
                                                FROM ATM.Cliente
                                                WHERE nombres = @cliente)
                           SELECT @servicioId = (SELECT id
                                                 FROM ATM.ServicioPublico
                                                 WHERE descripcion = @servicio)
                           SELECT id, saldo
                           FROM ATM.ServicioCliente
                           WHERE idServicio = @servicioId AND idCliente = @clienteId";

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@cliente", SqlDbType.NVarChar, 100).Value = cliente;
                    cmd.Parameters.Add("@servicio", SqlDbType.NVarChar, 100).Value = servicio;

                }

                // Establecemos la conexion
                conexion.EstablecerConexion();
                // Ejecutamos el query vía un ExecuteReader
                rdr = cmd.ExecuteReader();


                // Recorremos los elementos del Reader y los almacenamos en la lista
                while (rdr.Read())
                {
                   sv.id = Convert.ToInt16(rdr[0]);
                   sv.saldo = rdr.GetDecimal(1);

                }
                // retornamos de los servicios del cliente
                return sv;

            }
            catch (SqlException)
            {
                return sv;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }


        /// <summary>
        /// Método para insertar un Servicio del Cliente
        /// </summary>
        /// <param name="elSC"></param>
        /// <param name="elCliente"></param>
        /// <param name="elServicio"></param>
        /// <returns></returns>
        public static bool insertarServicioCliente(ServicioCliente elSC, string elCliente, string elServicio)
        {
            // instanciamos la conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");
            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_InsertarServicioCliente");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@cliente", SqlDbType.NVarChar, 100));
            cmd.Parameters["@cliente"].Value = elCliente;
            cmd.Parameters.Add(new SqlParameter("@servicio", SqlDbType.NVarChar, 100));
            cmd.Parameters["@servicio"].Value = elServicio;
            cmd.Parameters.Add(new SqlParameter("@saldo", SqlDbType.Decimal));
            cmd.Parameters["@saldo"].Value = elSC.saldo;

            // intentamos ejecutar el procedimiento
            try
            {
                conexion.EstablecerConexion();

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.StackTrace);
                //MessageBox.Show(ex.Errors[0].ToString());

                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }

        /// <summary>
        /// Método para actualizar el servicio de un cliente
        /// </summary>
        /// <param name="elSC"></param>
        /// <param name="elCliente"></param>
        /// <param name="elServicio"></param>
        /// <returns></returns>
        public static bool actualizarServicioCliente(ServicioCliente elSC, string elCliente, string elServicio)
        {
            // instanciamos la clase conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");
            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_ActualizarServicioCliente");

            // definimos el tipo de comando
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@cliente", SqlDbType.NVarChar, 100));
            cmd.Parameters["@cliente"].Value = elCliente;
            cmd.Parameters.Add(new SqlParameter("@servicio", SqlDbType.NVarChar, 100));
            cmd.Parameters["@servicio"].Value = elServicio;
            cmd.Parameters.Add(new SqlParameter("@saldo", SqlDbType.Decimal));
            cmd.Parameters["@saldo"].Value = elSC.saldo;

            // intentamos ejecutar el procedimiento
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
        
        /// <summary>
        /// Método para eliminar el servicio de un Cliente
        /// </summary>
        /// <param name="elSC"></param>
        /// <param name="cliente"></param>
        /// <param name="servicio"></param>
        /// <returns></returns>
        public static bool eliminarServicioCliente(string elCliente, string elServicio)
        {
            // instanciamos la clase conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");
            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_EliminarServicioCliente");

            // definimos el tipo de comando
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@cliente", SqlDbType.NVarChar, 100));
            cmd.Parameters["@cliente"].Value = elCliente;
            cmd.Parameters.Add(new SqlParameter("@servicio", SqlDbType.NVarChar, 100));
            cmd.Parameters["@servicio"].Value = elServicio;

            // intentamos ejecutar el procedimiento
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
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.Errors[0].ToString());
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }



    }
}
