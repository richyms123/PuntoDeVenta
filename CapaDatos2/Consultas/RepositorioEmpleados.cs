using CapaDatos.Objetos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaDatos.Consultas
{
    public class RepositorioEmpleados
    {

        /// <summary>
        /// Muestra todos los empleados.
        /// </summary>
        /// <returns>Devuelve una lista de todos los empleados.</returns>
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

        /// <summary>
        /// Se encarga de hacer el inicio de sesin en la base de datos. En caso de acceder, retorna el usuario ingresado.
        /// </summary>
        /// <param name="usuario">Usuario existente en la base de datos.</param>
        /// <param name="clave">Clase correspondiente al usuario en la base de datos.</param>
        /// <returns>En caso de ingresar usuario y clave correctos, se ingresa al menú y se retorna el usuario ingresado.</returns>
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

        /// Se edita el Empleado.
        /// </summary>
        /// <param name="user">Recibe el empleado a editar.</param>
        /// <returns>Retorna un entero en caso de que se haya editado correctamente el empleado.</returns>
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

        /// <summary>
        /// Agrega empleados a la tabla Empleados.
        /// </summary>
        /// <param name="user">Recibe el empleado que se vaya a agregar en la tabla Empleados.</param>
        /// <returns>Retorna un entero en caso de que se haya agregado correctamente el empleado.</returns>
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

        /// <summary>
        /// Se hace una eliminacion logica del empleado, cambiando su estado a inactivo.
        /// </summary>
        /// <param name="idEmpleado">Recibe el id del emepleado a eliminar.</param>
        /// <returns>Retorna un entero en caso de que se haya eliminado correctamente el empleado.</returns>
        public int Eliminar(int idEmpleado)
        {
            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("delete_user", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nidEmpleado", idEmpleado);
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
