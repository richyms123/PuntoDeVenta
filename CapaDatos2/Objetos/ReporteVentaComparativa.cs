using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos2.Objetos
{
    public class ReporteVentaComparativa
    {
        public int idProducto { get; set; }
        public string Nombre { get; set; }
        
        public float PrecioUnitario { get; set; }
        public float MontoMes1 { get; set; }
        public float MontoMes2 { get; set; }

    }

}
