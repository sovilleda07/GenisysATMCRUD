using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregar los namespaces necesarios
using System.Data;
using System.Data.SqlClient;

namespace GenisysATM.Models
{
    class CuentaCliente
    {
        // Propiedades
        public string numero { get; set; }
        public int idCliente { get; set; }
        public decimal saldo { get; set; }
        public string pin { get; set; }
        public string numeroNuevo { get; set; }

        // Constructores
        public CuentaCliente() { }

        // Métodos
        /// <summary>
        /// Obtiene la información de una cuenta para un cliente.
        /// </summary>
        /// <param name="cuenta">El número de cuenta del cliente</param>
        /// <returns>CuentaCliente el objeto que contiene la información de la cuenta del cliente</returns>
        public static CuentaCliente ObtenerCliente(string cuenta)
        {
            Conexion conn = new Conexion(@"(local)", "GenisysATM_V2");
            CuentaCliente laCuenta = new CuentaCliente();
            string sql = @"SELECT *
                           FROM ATM.CuentaCliente
                           WHERE numero = @cuenta";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@cuenta", SqlDbType.Char, 14).Value = cuenta;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    laCuenta.numero = rdr.GetString(0);
                    laCuenta.idCliente = Convert.ToInt16(rdr[1]);
                    laCuenta.saldo = rdr.GetDecimal(2);
                    laCuenta.pin = rdr.GetString(3);
                }

                return laCuenta;
            }
            catch (SqlException ex)
            {
                return laCuenta;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        /// <summary>
        /// Actualiza el saldo en la cuenta de un cliente. Dicha actualización
        /// solamente toma en cuenta débitos.
        /// </summary>
        /// <param name="cuenta">el número de cuenta del cliente</param>
        /// <param name="debito">el valor a ser debitado del saldo de la cuenta</param>
        /// <returns>true si el débidto pudo ser realizado. false en caso contrario.</returns>
        public static bool ActualizarSaldo(string cuenta, decimal debito)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            CuentaCliente laCuenta = CuentaCliente.ObtenerCliente(cuenta);

            SqlCommand cmd = conn.EjecutarComando("sp_ActualizarSaldoCuenta");

            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros
            cmd.Parameters.Add(new SqlParameter("cuenta", SqlDbType.Char, 14));
            cmd.Parameters.Add(new SqlParameter("debito", SqlDbType.Decimal));
            cmd.Parameters["cuenta"].Value = laCuenta.numero;
            cmd.Parameters["debito"].Value = debito;

            try
            {
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        /// <summary>
        /// Actualiza el valor del PIN para la cuenta de un cliente.
        /// </summary>
        /// <param name="laCuenta">número de cuenta del cliente</param>
        /// <param name="pinNuevo">el nuevo valor para el PIN</param>
        /// <returns>true si se actualiza el PIN. false en caso contrario.</returns>
        public static bool ActualizarPin(CuentaCliente laCuenta, string pinNuevo)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");

            SqlCommand cmd = conn.EjecutarComando("sp_ActualizarPin");
            cmd.Parameters.Add(new SqlParameter("cuenta", SqlDbType.Char, 14));
            cmd.Parameters.Add(new SqlParameter("pinActual", SqlDbType.Char, 4));
            cmd.Parameters.Add(new SqlParameter("pinNuevo", SqlDbType.Char, 4));

            cmd.Parameters["cuenta"].Value = laCuenta.numero;
            cmd.Parameters["pinActual"].Value = laCuenta.pin;
            cmd.Parameters["pinNuevo"].Value = pinNuevo;

            try
            {
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        /// <summary>
        /// Método para listar todas las cuentas de un cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static List<CuentaCliente> LeerTodo(string cliente)
        {
            // instanciamos la clase conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");

            // Lista de tipo TarjetaCredito
            List<CuentaCliente> resultados = new List<CuentaCliente>();

            // Creamos el query
            string sql = @"DECLARE @clienteId INT
                           SELECT @clienteId = (SELECT id
					                            FROM ATM.Cliente
					                            WHERE nombres = @cliente)
                           SELECT numero, saldo, pin
                           FROM ATM.CuentaCliente
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
                    CuentaCliente laCuenta = new CuentaCliente();
                    laCuenta.numero = rdr.GetString(0);
                    laCuenta.saldo = rdr.GetDecimal(1);
                    laCuenta.pin = rdr.GetString(2);

                    // Agregamos la cuenta a la lista
                    resultados.Add(laCuenta);
                }
                // Retornamos la lista de las cuentas del cliente
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
        /// Método para Ingresar una CuentaCliente
        /// </summary>
        /// <param name="laCuenta"></param>
        /// <param name="elCliente"></param>
        /// <returns></returns>
        public static bool InsertarCuentaCliente(CuentaCliente laCuenta, string elCliente)
        {
            // instanciamos la conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");
            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_InsertarCuentaCliente");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@numero", SqlDbType.Char, 14));
            cmd.Parameters["@numero"].Value = laCuenta.numero;
            cmd.Parameters.Add(new SqlParameter("@cliente", SqlDbType.NVarChar, 100));
            cmd.Parameters["@cliente"].Value = elCliente;
            cmd.Parameters.Add(new SqlParameter("@saldo", SqlDbType.Decimal));
            cmd.Parameters["@saldo"].Value = laCuenta.saldo;
            cmd.Parameters.Add(new SqlParameter("@pin", SqlDbType.Char, 4));
            cmd.Parameters["@pin"].Value = laCuenta.pin;

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
        /// Método para Actualizar la cuenta de un Cliente
        /// </summary>
        /// <param name="laCuenta"></param>
        /// <param name="elCliente"></param>
        /// <returns></returns>
        public static bool ActualizarCuentaCliente(CuentaCliente laCuenta, string elCliente)
        {
            // instanciamos la conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");
            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_ActualizarCuentaCliente");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@numero", SqlDbType.Char, 14));
            cmd.Parameters["@numero"].Value = laCuenta.numero;
            cmd.Parameters.Add(new SqlParameter("@numeroNuevo", SqlDbType.Char, 14));
            cmd.Parameters["@numeroNuevo"].Value = laCuenta.numeroNuevo;
            cmd.Parameters.Add(new SqlParameter("@cliente", SqlDbType.NVarChar, 100));
            cmd.Parameters["@cliente"].Value = elCliente;
            cmd.Parameters.Add(new SqlParameter("@saldo", SqlDbType.Decimal));
            cmd.Parameters["@saldo"].Value = laCuenta.saldo;
            cmd.Parameters.Add(new SqlParameter("@pin", SqlDbType.Char, 4));
            cmd.Parameters["@pin"].Value = laCuenta.pin;

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
        /// Método para Eliminar una Cuenta de un Cliente
        /// </summary>
        /// <param name="laCuenta"></param>
        /// <param name="elCliente"></param>
        /// <returns></returns>
        public static bool EliminarCuentaCliente(CuentaCliente laCuenta, string elCliente)
        {
            // instanciamos la conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");
            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_EliminarCuentaCliente");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parámetros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@numero", SqlDbType.Char, 14));
            cmd.Parameters["@numero"].Value = laCuenta.numero;
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
