using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos.Objetos
{
    internal class AuditoriaProducto
    {
        public int idAuditoria { get; set; }
        public DateTime FechaDeCambio { get; set; }
        // ENUM
        public string TipoCambio { get; set; }
        public string Usuario { get; set; }
        // DECIMAL
        public float ValorAnterior { get; set; }
        // DECIMAL
        public float ValorNuevo { get; set; }
        public int idProducto { get; set; }
    }
}
