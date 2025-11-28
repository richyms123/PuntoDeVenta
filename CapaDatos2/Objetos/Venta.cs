using System;

namespace CapaDatos.Objetos
{
    public class Venta
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

        //Para la ventana de inicio
        public float TotalVentasHoy { get; set; }

    }
}
