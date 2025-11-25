using CapaDatos.Objetos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaDatos.Consultas
{
    public class RepositorioEmpleados
    {
        public Empleado Login(string usuario, string clave)
        {
            Empleado objEmpleado = null;

            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("login", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("user", usuario);
                    cmd.Parameters.AddWithValue("password", clave);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            objEmpleado = new Empleado()
                            {
                                idEmpleado = Convert.ToInt32(dr["idEmpleado"]),
                                Nombre = dr["Nombre"].ToString(),
                                Apellidos = dr["Apellidos"].ToString(),
                                Rol = Convert.ToInt32(dr["Rol"]),
                                Turno = dr["Turno"].ToString(),
                                Mail = dr["Email"].ToString(), 
                                Usuario = dr["Usuario"].ToString(),
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    objEmpleado = null;
                }
            }
            return objEmpleado;
        }
    }
}
