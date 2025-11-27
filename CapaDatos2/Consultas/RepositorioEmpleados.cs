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
                    cmd.Parameters.AddWithValue("@ncontrasena", user.Pasword);
                    cmd.Parameters.AddWithValue("@nturno", user.Turno);
                    cmd.Parameters.AddWithValue("@nfechaNacimiento", user.FehaNacimiento);
                    cmd.Parameters.AddWithValue("@ndireccion", user.Direccion);
                    cmd.Parameters.AddWithValue("@nmunicipio", user.Municipio);
                    cmd.Parameters.AddWithValue("@nestado", user.Estado);
                    cmd.Parameters.AddWithValue("@ncodigo_postal", user.CodigoPostal);
                    cmd.Parameters.AddWithValue("@npais", user.Pais);
                    cmd.Parameters.AddWithValue("@ntelefono", user.Telefono);
                    cmd.Parameters.AddWithValue("@nemail", user.Mail);
                    cmd.Parameters.AddWithValue("@nfoto", user.FotoEmpleado);
                    cmd.Parameters.AddWithValue("@nfechaAlta", user.FechaDeAlta);
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
        /// <param name="user">Recibe el empleado a eliminar.</param>
        /// <returns>Retorna un entero en caso de que se haya eliminado correctamente el empleado.</returns>
        public int Eliminar(Empleado user)
        {
            using (MySqlConnection conexion = new Conexion().ObtenerConexion())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("delete_user", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nidEmpleado", user.idEmpleado);
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
