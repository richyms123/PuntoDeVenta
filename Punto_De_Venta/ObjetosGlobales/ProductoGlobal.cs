namespace Punto_De_Venta.ObjetosGlobales
{
    public static class ProductoGlobal
    {
        public static int idProducto { get; set; }
        public static string Nombre { get; set; }
        public static string CantidadPorUnidad { get; set; }
        public static float PrecioUnitario { get; set; }
        public static int Stock { get; set; }
        public static bool Descontinuado { get; set; }
        public static byte[] FotoProducto { get; set; }
        public static int idCategoria { get; set; }
    }
}
