using CapaDatos;
using CapaDatos.Objetos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos2.Consultas
{
    public class RepositorioAuditorias
    {
        
        public List<AuditoriaProducto> ObtenerTodos()
        {
            List<AuditoriaProducto> listaAuditorias = new List<AuditoriaProducto>();
            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                try
                {
                    string query = @"SELECT ap.*,p.Nombre 
                             FROM AuditoriaProductos ap
                            JOIN Productos p ON ap.idProducto = p.idProducto
                             ORDER BY ap.FechaDeCambio DESC";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        AuditoriaProducto auditoria = new AuditoriaProducto()
                        {
                            idAuditoria = Convert.ToInt32(dr["idAuditoria"]),
                            FechaDeCambio = Convert.ToDateTime(dr["FechaDeCambio"]),
                            TipoCambio = dr["TipoCambio"].ToString(),
                            Usuario = dr["Usuario"].ToString(),
                            ValorAnterior = Convert.ToSingle(dr["ValorAnterior"]),
                            ValorNuevo = Convert.ToSingle(dr["ValorNuevo"]),
                            idProducto = Convert.ToInt32(dr["idProducto"]),
                            NombreProducto= dr["Nombre"].ToString()
                        };
                        listaAuditorias.Add(auditoria);
                    }
                    dr.Close();
                    return listaAuditorias;
                }
                catch (Exception ex)
                {
                    return listaAuditorias;
                }
            }
            return listaAuditorias;


        }
    }
}
