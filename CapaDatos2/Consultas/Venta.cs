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
    internal class Venta
    {
        /// <summary>
        /// La funcion realiza la venta usando transacciones. Primero, crea una venta vacía, esto como referencia
        /// para la tabla Detalle de Venta; seguido de esto se recorre la lista de los productos para ir agregando
        /// los detalles de venta a la tabla. Una vez que se agregan todos los productos se agrega la informacion
        /// faltante a la tabla de Ventas.
        /// </summary>
        /// <param name="lista">Es una lista de Detalles de Venta que contiene todos los productos.</param>
        /// <param name="metodoDePago">Metodo de pago elegido por el cliente.</param>
        /// <param name="idEmpleado">ID del empleado en turno.</param>
        /// <returns>Retorna True en caso de que se hayan insertado los datos, tanto en la tabla Detalle de Venta,
        /// asi como en la tabla de Ventas.</returns>
        public bool RealizarVenta(List<DetalleVenta> lista, string metodoDePago, int idEmpleado)
        {
            using (MySqlConnection connection = new Conexion().ObtenerConexion())
            {

                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    int idVentaGenerado = 0;
                    using (MySqlCommand venta_vacia = new MySqlCommand("crear_venta_vacia", connection))
                    {
                        venta_vacia.Transaction = transaction;
                        venta_vacia.CommandType = CommandType.StoredProcedure;

                        venta_vacia.Parameters.AddWithValue("@nMetodoPago", metodoDePago);
                        venta_vacia.Parameters.AddWithValue("@nidEmpleado", idEmpleado);

                        MySqlParameter outId = new MySqlParameter("@idVentaGenerado", MySqlDbType.Int32);
                        outId.Direction = ParameterDirection.Output;
                        venta_vacia.Parameters.Add(outId);

                        venta_vacia.ExecuteNonQuery();
                        idVentaGenerado = Convert.ToInt32(outId.Value);
                    }

                    decimal totalVenta = 0;

                    foreach (DetalleVenta product in lista)
                    {
                        using (MySqlCommand insertarDetalle = new MySqlCommand("insertar_detalle_venta", connection))
                        {
                            insertarDetalle.Transaction = transaction;
                            insertarDetalle.CommandType = CommandType.StoredProcedure;

                            insertarDetalle.Parameters.AddWithValue("@nidProducto", product.idProducto);
                            insertarDetalle.Parameters.AddWithValue("@nidVenta", idVentaGenerado);
                            insertarDetalle.Parameters.AddWithValue("@nPrecioUnitario", product.PrecioUnitario);
                            insertarDetalle.Parameters.AddWithValue("@nCantidad", product.Cantidad);
                            insertarDetalle.Parameters.AddWithValue("@nDescuento", product.Descuento);
                            insertarDetalle.Parameters.AddWithValue("@nSubTotal", product.SubTotal);

                            insertarDetalle.ExecuteNonQuery();

                            totalVenta += (decimal)product.SubTotal;
                        }
                    }

                    using(MySqlCommand finalizar_venta = new MySqlCommand("finalizar_venta", connection))
                    {
                        finalizar_venta.Transaction = transaction;
                        finalizar_venta.CommandType = CommandType.StoredProcedure;

                        finalizar_venta.Parameters.AddWithValue("@nidVenta", idVentaGenerado);
                        finalizar_venta.Parameters.AddWithValue("@nMetodoPago", metodoDePago);
                        finalizar_venta.Parameters.AddWithValue("@nTotalVenta", totalVenta);

                        finalizar_venta.ExecuteNonQuery();
                    }
                    

                    transaction.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }
    }
}
