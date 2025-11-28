using CapaDatos;
using CapaDatos.Objetos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaDatos2.Consultas
{
    public class RepositorioCategoria
    {
        /// <summary>
        /// Obtiene todas las categorias de la base de datos
        /// </summary>
        /// <returns>Regresa una lista con todas las categorias</returns>
        public List<Categoria> ObtenerTodos()
        {
            string query = "SELECT * FROM categorias";
            List<Categoria> listaCategorias = new List<Categoria>();
            using (MySqlConnection connection = new Conexion().ObtenerConexion())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.CommandType = CommandType.Text;
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        Categoria categoria = new Categoria()
                        {
                            idCategoria = Convert.ToInt32(dr["idCategoria"]),
                            Nombre = dr["Nombre"].ToString(),
                            Descripcion = dr["Descripcion"].ToString()
                        };
                        listaCategorias.Add(categoria);
                    }
                    dr.Close();
                    return listaCategorias;
                }
                catch (Exception ex)
                {
                    return listaCategorias;
                }
            }
        }
    }
}
