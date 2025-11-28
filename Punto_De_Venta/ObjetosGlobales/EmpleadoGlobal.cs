using System;

namespace CapaDatos.Objetos
{
    public static class EmpleadoGlobal
    {
        /*
            public int id { get; set; }
            public string   usuario         { get; set; }
            public string   nombre          { get; set; }
            public string   apellido        { get; set; }
            public string   telefono        { get; set; }
            public string   correo          { get; set; }
            public string   contrasena      { get; set; }
            public DateTime fechaNacimiento { get; set; } 
        */
        public static int idEmpleado { get; set; }
        public static string Nombre { get; set; }
        public static string Apellidos { get; set; }
        public static string Usuario { get; set; }
        public static string Pasword { get; set; }
        public static bool Activo { get; set; }
        public static int Rol { get; set; }
        public static string Turno { get; set; }
        public static string Direccion { get; set; }
        public static string Municipio { get; set; }
        public static string Estado { get; set; }
        public static string CodigoPostal { get; set; }
        public static string Pais { get; set; }
        public static string Telefono { get; set; }
        public static string Mail { get; set; }
        public static byte[] FotoEmpleado { get; set; }
        public static DateTime FechaDeAlta { get; set; }
        public static DateTime FechaNacimiento { get; set; }




    }
}