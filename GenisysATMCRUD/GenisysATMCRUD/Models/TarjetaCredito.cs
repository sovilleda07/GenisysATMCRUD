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
    class TarjetaCredito
    {
        // Propiedades
        public int id { get; set; }
        public string descripcion { get; set; }
        public decimal monto { get; set; }
        public decimal limite { get; set; }
        public int idCliente { get; set; }
        public string descripcionNueva { get; set; }

        // Constructor
        public TarjetaCredito() { }

        // Metodos

        /// <summary>
        /// Método para listar todas las tarjetas de crédito de un Cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static List<TarjetaCredito> LeerTodo(string cliente)
        {
            // instanciamos la clase conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");

            // Lista de tipo TarjetaCredito
            List<TarjetaCredito> resultados = new List<TarjetaCredito>();

            // Creamos el query
            string sql = @"DECLARE @clienteId INT
                           SELECT @clienteId = (SELECT id
					                            FROM ATM.Cliente
					                            WHERE nombres = @cliente)
                           SELECT id, descripcion, monto, limite
                           FROM ATM.TarjetaCredito 
                           WHERE idCliente = @clienteId";

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

                // Recorremos los elementos del Reader y los almacenamos en la Lista
                while (rdr.Read())
                {
                    TarjetaCredito laTarjeta = new TarjetaCredito();
                    laTarjeta.id = Convert.ToInt16(rdr[0]);
                    laTarjeta.descripcion = rdr.GetString(1);
                    laTarjeta.monto = rdr.GetDecimal(2);
                    laTarjeta.limite = rdr.GetDecimal(3);

                    // Agregamos la tarjeta a la lista
                    resultados.Add(laTarjeta);
                }
                // Retornamos la lista de las tarjetas del cliente
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
        /// Método que carga toda la informacion de la tarjeta de un cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="tarjeta"></param>
        /// <returns></returns>
        public static TarjetaCredito LeerInformacionTarjeta(string cliente, string tarjeta)
        {
            // instanciamos la clase conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");

            // Lista de tipo TarjetaCredito
            TarjetaCredito laTarjeta = new TarjetaCredito();

            // Creamos el query
            string sql = @"DECLARE @clienteId INT,
                                   @tarjetaId INT
                           SELECT @clienteId = (SELECT id
					                            FROM ATM.Cliente
					                            WHERE nombres = @cliente)
                           SELECT @tarjetaId = (SELECT id
                                                FROM ATM.TarjetaCredito
                                                WHERE descripcion = @tarjeta)
                           SELECT id, descripcion, monto, limite
                           FROM ATM.TarjetaCredito 
                           WHERE idCliente = @clienteId and id = @tarjetaId";

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@cliente", SqlDbType.NVarChar, 100).Value = cliente;
                    cmd.Parameters.Add("@tarjeta", SqlDbType.NVarChar, 100).Value = tarjeta;
                }

                // Establecemos la conexion
                conexion.EstablecerConexion();
                // Ejecutamos el query vía un ExecuteReader
                rdr = cmd.ExecuteReader();

                // Recorremos los elementos del Reader y los almacenamos en la Lista
                while (rdr.Read())
                {
                    laTarjeta.id = Convert.ToInt16(rdr[0]);
                    laTarjeta.descripcion = rdr.GetString(1);
                    laTarjeta.monto = rdr.GetDecimal(2);
                    laTarjeta.limite = rdr.GetDecimal(3);

                }
                // Retornamos la lista de las tarjetas del cliente
                return laTarjeta;
            }
            catch (SqlException)
            {
                return laTarjeta;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        /// <summary>
        /// Método para insertar la tarjeta a un cliente
        /// </summary>
        /// <param name="laTarjeta"></param>
        /// <param name="elCliente"></param>
        /// <returns></returns>
        public static bool InsertarTarjetaCredito (TarjetaCredito laTarjeta, string elCliente)
        {
            // instanciamos la conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");
            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_InsertarTarjetaCredito");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 100));
            cmd.Parameters["@descripcion"].Value = laTarjeta.descripcion;
            cmd.Parameters.Add(new SqlParameter("@monto", SqlDbType.Decimal));
            cmd.Parameters["@monto"].Value = laTarjeta.monto;
            cmd.Parameters.Add(new SqlParameter("@limite", SqlDbType.Decimal));
            cmd.Parameters["@limite"].Value = laTarjeta.limite;
            cmd.Parameters.Add(new SqlParameter("@cliente", SqlDbType.NVarChar, 100));
            cmd.Parameters["@cliente"].Value = elCliente;

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
        /// Método para Actualizar una tarjeta de un Cliente
        /// </summary>
        /// <param name="laTarjeta"></param>
        /// <param name="elCliente"></param>
        /// <returns></returns>
        public static bool actualizarTarjetaCredito(TarjetaCredito laTarjeta, string elCliente)
        {
            // instanciamos la conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");
            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_ActualizarTarjetaCredito");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 100));
            cmd.Parameters["@descripcion"].Value = laTarjeta.descripcion;
            cmd.Parameters.Add(new SqlParameter("@descripcionNueva", SqlDbType.NVarChar, 100));
            cmd.Parameters["@descripcionNueva"].Value = laTarjeta.descripcion;
            cmd.Parameters.Add(new SqlParameter("@monto", SqlDbType.Decimal));
            cmd.Parameters["@monto"].Value = laTarjeta.monto;
            cmd.Parameters.Add(new SqlParameter("@limite", SqlDbType.Decimal));
            cmd.Parameters["@limite"].Value = laTarjeta.limite;
            cmd.Parameters.Add(new SqlParameter("@cliente", SqlDbType.NVarChar, 100));
            cmd.Parameters["@cliente"].Value = elCliente;


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
        /// Método para Eliminar una Tarjeta de Crédito 
        /// </summary>
        /// <param name="laTarjeta"></param>
        /// <param name="elCliente"></param>
        /// <returns></returns>
        public static bool EliminarTarjetaCredito(TarjetaCredito laTarjeta, string elCliente)
        {
            // instanciamos la conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");
            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_EliminarTarjetaCredito");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 100));
            cmd.Parameters["@descripcion"].Value = laTarjeta.descripcion;
            cmd.Parameters.Add(new SqlParameter("@cliente", SqlDbType.NVarChar, 100));
            cmd.Parameters["@cliente"].Value = elCliente;


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



    }
}
