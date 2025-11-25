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

       


    }

}
