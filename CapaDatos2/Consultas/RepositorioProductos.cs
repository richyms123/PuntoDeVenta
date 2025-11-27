using CapaDatos;
using CapaDatos.Objetos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos2.Consultas
{
    internal class RepositorioProductos

    {
        /// <summary>
        /// Agrega productos a la tabla Productos.
        /// </summary>
        /// <param name="product">Recibe el producto que se vaya a agregar en la tabla Productos.</param>
        /// <returns>Retorna un entero en caso de que se haya agregado correctamente el producto.</returns>
        public int Agregar(Producto product)
        {
            using (MySqlConnection connection = new Conexion().ObtenerConexion())
            {
                try
                {
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
                    return 0;
                }
            }
        }

        /// <summary>
        /// Se edita el producto.
        /// </summary>
        /// <param name="product">Recibe el producto a editar.</param>
        /// <returns>Retorna un entero en caso de que se haya editado correctamente el producto.</returns>
        public int Editar(Producto product)
        {
            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("add_product", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nidProducto", product.idProducto);
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
                    return 0;
                }
            }
        }

        /// <summary>
        /// Se hace una eliminacion logica del producto, cambiando su estado a descontinuado.
        /// </summary>
        /// <param name="product">Recibe el producto a eliminar.</param>
        /// <returns>Retorna un entero en caso de que se haya eliminado correctamente el producto.</returns>
        public int Eliminar(Producto product)
        {
            using (MySqlConnection connection = new Conexion().ObtenerConexion())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("delete_product", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nidProducto", product.idProducto);
                    int result = cmd.ExecuteNonQuery();
                    return Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }
    }
}
