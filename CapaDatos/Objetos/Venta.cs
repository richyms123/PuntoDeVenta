using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Objetos
{
    internal class Venta
    {
        public int idVenta { get; set; }
        public DateTime Fecha { get; set; }
        // ENUM
        public string Estatus { get; set; }
        //ENUM
        public string MetodoPago { get; set; }
        //DECIMAL
        public float Total { get; set; }
        public int idEmpleado { get; set; }

    }
}
