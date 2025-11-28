namespace Punto_De_Venta.ObjetosGlobales
{
    public static class EmpleadoSesion
    {
        public static int idEmpleado { get; set; }
        public static string Nombre { get; set; }
        public static string Apellidos { get; set; }
        public static string Usuario { get; set; }

        public static int Rol { get; set; }

        public static byte[] FotoEmpleado { get; set; }
    }
}
