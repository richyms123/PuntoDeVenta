using CapaDatos;
using CapaDatos.Objetos;
using CapaDatos2.Objetos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaDatos2.Consultas
{
    public class RepositorioVenta
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
        public bool RealizarVenta(List<DetalleVenta> lista, string metodoDePago, int idEmpleado, string usuarioLogueado)
        {
            using (MySqlConnection connection = new Conexion().ObtenerConexion())
            {

                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    int idVentaGenerado = 0;
                    using (MySqlCommand cmdAudit = new MySqlCommand($"SET @UsuarioActual = '{usuarioLogueado}';", connection))
                    {
                        cmdAudit.Transaction = transaction;
                        cmdAudit.ExecuteNonQuery();
                    }

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
                        string queryStock = "UPDATE productos SET Stock = Stock - @cantidad WHERE idProducto = @id";
                        using (MySqlCommand updateStock = new MySqlCommand(queryStock, connection))
                        {
                            updateStock.Transaction = transaction;
                            updateStock.Parameters.AddWithValue("@cantidad", product.Cantidad);
                            updateStock.Parameters.AddWithValue("@id", product.idProducto);
                            updateStock.ExecuteNonQuery();
                        }
                    }



                    using (MySqlCommand finalizar_venta = new MySqlCommand("finalizar_venta", connection))
                    {
                        finalizar_venta.Transaction = transaction;
                        finalizar_venta.CommandType = CommandType.StoredProcedure;

                        finalizar_venta.Parameters.AddWithValue("@nidVenta", idVentaGenerado);
                        finalizar_venta.Parameters.AddWithValue("@nMetodoPago", metodoDePago);
                        finalizar_venta.Parameters.AddWithValue("@nTotal", totalVenta);

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

        /// <summary>
        /// Obtiene una lista de todos los reportes de ventas obtenidas entre dos fechas diferentes.
        /// </summary>
        /// <param name="PrimeraFecha">Es una lista de Detalles de Venta que contiene todos los productos.</param>
        /// <param name="SegundaFecha">Metodo de pago elegido por el cliente.</param>
        /// <returns>Retorna una lista de Reportes donde proporciona el id del producto, nombre, las unidades
        /// y el monto total de ese producto durante el mes.</returns>
        public List<ReporteVenta> ObtenerReporte(DateTime PrimeraFecha, DateTime SegundaFecha)
        {
            using (MySqlConnection connection = new Conexion().ObtenerConexion())
            {
                try
                {
                    using (MySqlCommand generar_reporte = new MySqlCommand("generar_reporte", connection))
                    {
                        List<ReporteVenta> lista = new List<ReporteVenta>();

                        generar_reporte.CommandType = CommandType.StoredProcedure;
                        generar_reporte.Parameters.AddWithValue("nPrimeraFecha", PrimeraFecha);
                        generar_reporte.Parameters.AddWithValue("nSegundaFecha", SegundaFecha);

                        using (MySqlDataReader reader = generar_reporte.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ReporteVenta reporte = new ReporteVenta();

                                reporte.idProducto = Convert.ToInt32(reader["Clave"]);
                                reporte.Nombre = reader["NombreProducto"].ToString();
                                reporte.Unidades = Convert.ToInt32(reader["Unidades"]);
                                reporte.Monto = Convert.ToDecimal(reader["Monto"]);

                                lista.Add(reporte);
                            }
                        }

                        return lista;
                    }
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<ReporteVentaComparativa> ObtenerReporteComparativo(int mes1,int mes2,List<int> ids)
        {
            List<ReporteVentaComparativa> lista = new List<ReporteVentaComparativa>();
            if(ids.Count==0)
            {
                return lista;
            }
            string idsConcatenados = string.Join(",", ids);
            using (MySqlConnection connection = new Conexion().ObtenerConexion())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("generar_reporte_comparativo", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_mes1", mes1);
                    cmd.Parameters.AddWithValue("p_mes2", mes2);
                    cmd.Parameters.AddWithValue("p_listaids", idsConcatenados);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ReporteVentaComparativa reporte = new ReporteVentaComparativa();
                            reporte.idProducto = Convert.ToInt32(reader["id"]);
                            reporte.Nombre = reader["producto"].ToString();
                            reporte.PrecioUnitario = Convert.ToSingle(reader["precio"]);
                            reporte.MontoMes1 = Convert.ToSingle(reader["ventasmes1"]);
                            reporte.MontoMes2 = Convert.ToSingle(reader["ventasmes2"]);
                            lista.Add(reporte);
                        }
                    }
                    return lista;
                }
                catch
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Calcula el total de ventas realizadas el dia de hoy.
        /// </summary>
        /// <returns></returns>
        public float ObtenerVentasHoy()
        {
            float total = 0;
            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                try
                {
                    string query = "SELECT IFNULL(SUM(Total), 0) FROM Ventas WHERE DATE(Fecha) = CURDATE() AND Estatus = 'Pagada'";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    total = Convert.ToSingle(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    total = 0;
                }
            }
            return total;
        }
    }
}
