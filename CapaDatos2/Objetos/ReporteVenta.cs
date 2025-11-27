using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos2.Objetos
{
    internal class ReporteVenta
    {
        public int idProducto {  get; set; }
        public string Nombre { get; set; }
        public int Unidades { get; set; }
        public decimal Monto { get; set; }
    }
}
