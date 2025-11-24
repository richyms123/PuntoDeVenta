using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Objetos
{
    internal class DetalleVenta
    {
        public int idProducto { get; set; }
        public int idVenta { get; set; }
        // DECIMAL
        public float PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public float Descuento { get; set; }
        //DECIMAL
        public float SubTotal { get; set; }

    }
}
