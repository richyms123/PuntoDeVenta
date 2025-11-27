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

        public List<Empleado> ObtenerTodos()
        {
            List<Empleado> lista = new List<Empleado>();

            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("select_user", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Empleado()
                            {
                                idEmpleado = Convert.ToInt32(dr["idEmpleado"]),
                                Nombre = dr["Nombre"].ToString(),
                                Apellidos = dr["Apellidos"].ToString(),
                                Rol = Convert.ToInt32(dr["Rol"]),
                                Usuario = dr["Usuario"].ToString(),
                                Turno = dr["Turno"].ToString(),
                                FehaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]),
                                Direccion = dr["Direccion"].ToString(),
                                Municipio = dr["Municipio"].ToString(),
                                Estado = dr["Estado"].ToString(),
                                Pasword = dr["Pasword"].ToString(),
                                CodigoPostal = dr["CodigoPostal"].ToString(),
                                Pais = dr["Pais"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Mail = dr["Email"].ToString(),
                                FotoEmpleado = dr["FotoEmpleado"] == DBNull.Value ? null : (byte[])dr["FotoEmpleado"],
                                FechaDeAlta = Convert.ToDateTime(dr["FechaDeAlta"])
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Empleado>();
                }
            }
            return lista;
        }

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
                                Pasword = dr["Pasword"].ToString(),
                                FotoEmpleado = dr["FotoEmpleado"] == DBNull.Value ? null : (byte[])dr["FotoEmpleado"]
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

        public int Editar(Empleado user)
        {
            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("update_user", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nnombre", user.Nombre);
                    cmd.Parameters.AddWithValue("@napellidos", user.Apellidos);
                    cmd.Parameters.AddWithValue("@nrol", user.Rol);
                    cmd.Parameters.AddWithValue("@nusuario", user.Usuario);
                    cmd.Parameters.AddWithValue("@nPasword", user.Pasword);
                    cmd.Parameters.AddWithValue("@nturno", user.Turno);
                    cmd.Parameters.AddWithValue("@nfechaNacimiento", user.FehaNacimiento);
                    cmd.Parameters.AddWithValue("@ndireccion", user.Direccion);
                    cmd.Parameters.AddWithValue("@nmunicipio", user.Municipio);
                    cmd.Parameters.AddWithValue("@nestado", user.Estado);
                    cmd.Parameters.AddWithValue("@nCodigoPostal", user.CodigoPostal);
                    cmd.Parameters.AddWithValue("@npais", user.Pais);
                    cmd.Parameters.AddWithValue("@ntelefono", user.Telefono);
                    cmd.Parameters.AddWithValue("@nemail", user.Mail);
                    cmd.Parameters.AddWithValue("@nFotoEmpleado", user.FotoEmpleado);
                    cmd.Parameters.AddWithValue("@nFechaDeAlta", user.FechaDeAlta);
                    cmd.Parameters.AddWithValue("@nidEmpleado", user.idEmpleado);
                    cmd.Parameters.AddWithValue("@nActivo", user.Activo);
                    int result = cmd.ExecuteNonQuery();
                    return Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }

        }

        public int Agregar(Empleado user)
        {
            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("add_user", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nnombre", user.Nombre);
                    cmd.Parameters.AddWithValue("@napellidos", user.Apellidos);
                    cmd.Parameters.AddWithValue("@nrol", user.Rol);
                    cmd.Parameters.AddWithValue("@nusuario", user.Usuario);
                    cmd.Parameters.AddWithValue("@nPasword", user.Pasword);
                    cmd.Parameters.AddWithValue("@nturno", user.Turno);
                    cmd.Parameters.AddWithValue("@nfechaNacimiento", user.FehaNacimiento);
                    cmd.Parameters.AddWithValue("@ndireccion", user.Direccion);
                    cmd.Parameters.AddWithValue("@nmunicipio", user.Municipio);
                    cmd.Parameters.AddWithValue("@nestado", user.Estado);
                    cmd.Parameters.AddWithValue("@nCodigoPostal", user.CodigoPostal);
                    cmd.Parameters.AddWithValue("@npais", user.Pais);
                    cmd.Parameters.AddWithValue("@ntelefono", user.Telefono);
                    cmd.Parameters.AddWithValue("@nemail", user.Mail);
                    cmd.Parameters.AddWithValue("@nFotoEmpleado", user.FotoEmpleado);
                    cmd.Parameters.AddWithValue("@nFechaDeAlta", user.FechaDeAlta);
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
