using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Objetos
{
    internal class Producto
    {
        public int idProducto { get; set; }
        public string Nombre { get; set; }
        public string CantidadPorUnidad { get; set; }
        //DECIMAL
        public float PrecioUnitario { get; set; }
        public int Stock { get; set; }
        public bool Descontinuado { get; set; }
        public string FotoProducto { get; set; }
        public int idCategoria { get; set; }

    }
}
