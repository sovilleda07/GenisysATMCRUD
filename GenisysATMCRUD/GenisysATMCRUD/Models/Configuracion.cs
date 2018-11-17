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
    class Configuracion
    {
        // Propiedades
        public int id { get; set; }
        public string appKey { get; set; }
        public string valor { get; set; }
        public string descripcion { get; set; }
        public string appKeyNuevo { get; set; }

        // Constructores
        public Configuracion() { }

        // Métodos
        public static string ObtenerConfiguracion(string key)
        {
            string valor = "";
            SqlDataReader rdr;
            Conexion conn = new Conexion(@"(local)", "GenisysATM_V2");
            SqlCommand cmd = conn.EjecutarComando(@"SELECT valor 
                                                    FROM ATM.Configuracion 
                                                    WHERE appKey = @key");

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@key", SqlDbType.NVarChar, 50).Value = key;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    valor = rdr.GetString(0);
                }

                return valor;
            }
            catch (SqlException ex)
            {
                return "Clave no válida";
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        /// <summary>
        /// Métod para Insertar una nueva Configuración
        /// </summary>
        /// <param name="laConfiguracion"></param>
        /// <returns></returns>
        public static bool InsertarConfiguracion(Configuracion laConfiguracion)
        {
            // instanciamos la conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");
            // enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_InsertarConfiguracion");

            // Establecer el comando como un Stored Procedure
            cmd.CommandType = CommandType.StoredProcedure;

            // Parametros del Stored Procedure
            cmd.Parameters.Add(new SqlParameter("@appKey", SqlDbType.NChar, 50));
            cmd.Parameters["@appKey"].Value = laConfiguracion.appKey;
            cmd.Parameters.Add(new SqlParameter("@valor", SqlDbType.NChar, 50));
            cmd.Parameters["@valor"].Value = laConfiguracion.valor;
            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 2000));
            cmd.Parameters["@descripcion"].Value = laConfiguracion.descripcion;

            // intentamos ejecutar el procedimiento
            try
            {
                // Establecemos la conexion
                conexion.EstablecerConexion();

                // Ejecutamos el query de eliminacion
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
        /// Método para Actualizar la Configuración
        /// </summary>
        /// <param name="laConfiguracion"></param>
        /// <returns></returns>
        public static bool actualizarConfiguracion(Configuracion laConfiguracion)
        {
            // instanciamos la clase conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");
            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_ActualizarConfiguracion");

            // definimos el tipo de comando
            cmd.CommandType = CommandType.StoredProcedure;

            // Declaramos los parámetros necesarios 
            cmd.Parameters.Add(new SqlParameter("@appKey", SqlDbType.NChar, 50));
            cmd.Parameters["@appKey"].Value = laConfiguracion.appKey;
            cmd.Parameters.Add(new SqlParameter("@appKeyNueva", SqlDbType.NChar, 50));
            cmd.Parameters["@appKeyNueva"].Value = laConfiguracion.appKeyNuevo;
            cmd.Parameters.Add(new SqlParameter("@valor", SqlDbType.NChar, 50));
            cmd.Parameters["@valor"].Value = laConfiguracion.valor;
            cmd.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 2000));
            cmd.Parameters["@descripcion"].Value = laConfiguracion.descripcion;

            // intentamos ejecutar el procedimiento
            try
            {
                // Establecemos la conexion
                conexion.EstablecerConexion();

                // Ejecutamos el query de eliminacion
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

        public static bool eliminarConfiguracion(Configuracion laConfiguracion)
        {
            // Instanciamos la conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando("sp_EliminarConfiguracion");

            // Definimos que tipo de comando es
            cmd.CommandType = CommandType.StoredProcedure;

            // Declaramos los parámetros necesarios 
            cmd.Parameters.Add(new SqlParameter("@appKey", SqlDbType.NChar, 50));
            cmd.Parameters["@appKey"].Value = laConfiguracion.appKey;

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


        public static List<Configuracion> LeerTodos()
        {
            // instanciamos la clase conexion
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");

            // Lista una de tipo de Configuracion
            List<Configuracion> resultados = new List<Configuracion>();

            // Creamos el query
            string sql = @"SELECT id, appKey, valor, descripcion
                            FROM ATM.Configuracion";

            // Enviamos el comando a ejecutar
            SqlCommand cmd = conexion.EjecutarComando(sql);

            try
            {
                // Establecemos la conexion
                conexion.EstablecerConexion();
                // Ejecutamos el query vía un ExecuteReader
                SqlDataReader rdr = cmd.ExecuteReader();

                // Recorremos los elementos del Reader y los almacenamos
                // en la lista de tipo Configuracion
                while (rdr.Read())
                {
                    Configuracion laConfiguracion = new Configuracion();
                    // Asignamos los valores de Reader al objeto Configuracion
                    laConfiguracion.id = Convert.ToInt16(rdr[0]);
                    laConfiguracion.appKey = rdr.GetString(1);
                    laConfiguracion.valor = rdr.GetString(2);
                    laConfiguracion.descripcion = rdr.GetString(3);

                    // Agregamos el Cliente a la lista
                    resultados.Add(laConfiguracion);
                }
                // retornamos la lista de la Configuracion
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

        public static Configuracion ObtenerInformacionConfiguracion(string key)
        {
            Conexion conexion = new Conexion(@"(local)", "GenisysATM_V2");
            string sql;
            Configuracion resultado = new Configuracion();

            // Query SQL
            sql = @"SELECT id, appKey, valor, descripcion
                    FROM ATM.Configuracion 
                    WHERE appKey = @key";


            SqlCommand cmd = conexion.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@key", SqlDbType.NChar, 50).Value = key;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    resultado.id = Convert.ToInt16(rdr[0]);
                    resultado.appKey = rdr.GetString(1);
                    resultado.valor = rdr.GetString(2);
                    resultado.descripcion = rdr.GetString(3);

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
