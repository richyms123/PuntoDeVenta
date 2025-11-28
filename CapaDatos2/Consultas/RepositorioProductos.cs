using CapaDatos;
using CapaDatos.Objetos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaDatos2.Consultas
{
    public class RepositorioProductos

    {
        /// <summary>
        /// Este metodo obtiene todos los productos de la tabla Productos.
        /// </summary>
        /// <returns>
        /// Retorna una lista de productos obtenidos de la tabla Productos.
        /// </returns>
        public List<Producto> ObtenerTodos()
        {
            List<Producto> listaProductos = new List<Producto>();
            using (MySqlConnection connection = new Conexion().ObtenerConexion())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("select_product", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Producto product = new Producto()
                        {
                            idProducto = Convert.ToInt32(dr["idProducto"]),
                            Nombre = dr["Nombre"].ToString(),
                            CantidadPorUnidad = dr["CantidadPorUnidad"].ToString(),
                            PrecioUnitario = Convert.ToSingle(dr["PrecioUnitario"]),
                            Stock = Convert.ToInt32(dr["Stock"]),
                            FotoProducto = dr["FotoProducto"] == DBNull.Value ? null : (byte[])dr["FotoProducto"],
                            idCategoria = Convert.ToInt32(dr["idCategoria"])
                        };
                        listaProductos.Add(product);
                    }
                    dr.Close();
                    return listaProductos;
                }
                catch (Exception ex)
                {
                    return listaProductos;
                }
            }
        }
        /// <summary>
        /// Agrega productos a la tabla Productos.
        /// </summary>
        /// <param name="product" name="usuarioLogueado" name="mensaje">
        /// Recibe el producto que se vaya a agregar en la tabla Productos.
        /// Y el usuario logeuado para registrar quien realiza la insercion.
        /// </param>
        /// <returns>Retorna un entero en caso de que se haya agregado correctamente el producto.</returns>
        public int Agregar(Producto product, string usuarioLogueado, out string mensaje)
        {
            mensaje = string.Empty;
            using (MySqlConnection connection = new Conexion().ObtenerConexion())
            {
                try
                {
                    string queryUser = $"SET @UsuarioActual = '{usuarioLogueado}';";
                    new MySqlCommand(queryUser, connection).ExecuteNonQuery();

                    MySqlCommand cmd = new MySqlCommand("add_product", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nNombre", product.Nombre);
                    cmd.Parameters.AddWithValue("@nCantidadPorUnidad", product.CantidadPorUnidad);
                    cmd.Parameters.AddWithValue("@nPrecioUnitario", product.PrecioUnitario);
                    cmd.Parameters.AddWithValue("@nStock", product.Stock);
                    cmd.Parameters.AddWithValue("@nFotoProducto", product.FotoProducto);
                    cmd.Parameters.AddWithValue("@idCategoria", product.idCategoria);
                    int result = cmd.ExecuteNonQuery();
                    return Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;

                    return 0;
                }
            }
        }

        /// <summary>
        /// Se edita el producto.
        /// </summary>
        /// <param name="product" name="usuarioLogueado" name="mensaje">Recibe el producto a editar.
        /// Y el usuario logeuado para registrar quien realiza la edicion.
        /// </param>
        /// <returns>Retorna un entero en caso de que se haya editado correctamente el producto.</returns>
        public int Editar(Producto product, string usuarioLogueado, out string mensaje)
        {
            mensaje = string.Empty;
            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                try
                {
                    string queryUser = $"SET @UsuarioActual = '{usuarioLogueado}';";
                    new MySqlCommand(queryUser, conexion).ExecuteNonQuery();

                    MySqlCommand cmd = new MySqlCommand("update_product", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nidProducto", product.idProducto);
                    cmd.Parameters.AddWithValue("@nNombre", product.Nombre);
                    cmd.Parameters.AddWithValue("@nCantidadPorUnidad", product.CantidadPorUnidad);
                    cmd.Parameters.AddWithValue("@nPrecioUnitario", product.PrecioUnitario);
                    cmd.Parameters.AddWithValue("@nStock", product.Stock);
                    cmd.Parameters.AddWithValue("@nFotoProducto", product.FotoProducto);
                    cmd.Parameters.AddWithValue("@nidCategoria", product.idCategoria);
                    int result = cmd.ExecuteNonQuery();
                    return Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;

                    return 0;
                }
            }
        }

        /// <summary>
        /// Se hace una eliminacion logica del producto, cambiando su estado a descontinuado.
        /// </summary>
        /// <param name="idProducto" name="usuarioLogueado" name="mensaje">
        /// Recibe el id del producto a eliminar.
        /// El usuario logeuado para registrar quien realiza la eliminacion.
        ///     
        /// </param>
        /// <returns>Retorna un entero en caso de que se haya eliminado correctamente el producto.</returns>
        public int Eliminar(int idProducto, string usuarioLogueado, out string mensaje)
        {
            mensaje = string.Empty;
            using (MySqlConnection connection = new Conexion().ObtenerConexion())
            {
                try
                {

                    string queryUser = $"SET @UsuarioActual = '{usuarioLogueado}';";
                    new MySqlCommand(queryUser, connection).ExecuteNonQuery();
                    MySqlCommand cmd = new MySqlCommand("delete_product", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nidProducto", idProducto);
                    int result = cmd.ExecuteNonQuery();
                    return Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    return 0;
                }
            }
        }

        /// <summary>
        /// Obtiene la cantidad de productos activos en la tabla Productos.
        /// </summary>
        /// <returns></returns>
        public int ContarProductosActivos()
        {
            int cantidad = 0;
            using (MySqlConnection oconexion = new Conexion().ObtenerConexion())
            {
                try
                {
                    string query = "SELECT COUNT(*) FROM Productos WHERE Descontinuado = 0";
                    MySqlCommand cmd = new MySqlCommand(query, oconexion);

                    cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    cantidad = 0;
                }
            }
            return cantidad;
        }

        /// <summary>
        /// Cuenta la cantidad de productos con stock bajo (20 unidades o menos) en la tabla Productos.
        /// </summary>
        /// <returns></returns>
        public int ContarProductosBajoStock()
        {
            int cantidad = 0;
            using (MySqlConnection oconexion = new Conexion().ObtenerConexion())
            {
                try
                {
                    string query = "SELECT COUNT(*) FROM Productos WHERE Stock <= 20 AND Descontinuado = 0";
                    MySqlCommand cmd = new MySqlCommand(query, oconexion);

                    cantidad = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    cantidad = 0;
                }
            }
            return cantidad;
        }

        /// <summary>
        /// Obtiene el nombre y el stock de los productos con stock menor a o igual a 20 unidades.
        /// </summary>
        /// <returns></returns>
        public List<Producto> ListarProductosBajoStock()
        {
            List<Producto> listaProductos = new List<Producto>();
            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                try
                {
                    string query = @"SELECT Nombre, Stock 
                             FROM Productos 
                             WHERE Stock <= 20 AND Descontinuado = 0 
                             ORDER BY Stock ASC";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Producto product = new Producto()
                        {              
                            Nombre = dr["Nombre"].ToString(),             
                            Stock = Convert.ToInt32(dr["Stock"]),
                            
                        };
                        listaProductos.Add(product);
                    }
                    dr.Close();
                    return listaProductos;
                }
                catch (Exception ex)
                {
                    return listaProductos;
                }
            }
            return listaProductos;
        }


        /// <summary>
        /// Obtiene el Top 5 productos más vendidos.
        /// </summary>
        /// <returns></returns>
        public List<Producto> SeleccionarTop5MasVendidos()
        {
            List<Producto> listaProductos = new List<Producto>();
            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                try
                {
                    string query = @"SELECT 
                        p.Nombre, 
                        SUM(dv.Cantidad) as TotalVendidos
                    FROM 
                        DetalleVenta dv
                    INNER JOIN 
                        Productos p ON dv.idProducto = p.idProducto
                    INNER JOIN 
                        Ventas v ON dv.idVenta = v.idVenta
                    WHERE 
                        v.Estatus = 'Pagada'
                    GROUP BY 
                        p.idProducto, p.Nombre
                    ORDER BY 
                        TotalVendidos DESC
                    LIMIT 5;";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Producto product = new Producto()
                        {
                            Nombre = dr["Nombre"].ToString(),
                            productosActivos = Convert.ToInt32(dr["TotalVendidos"]),
                        };
                        listaProductos.Add(product);
                    }
                    dr.Close();
                    return listaProductos;
                }
                catch (Exception ex)
                {
                    return listaProductos;
                }
            } 
        }



    }
}
