using System;

namespace CapaDatos.Objetos
{
    public class AuditoriaProducto
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

        public string NombreProducto { get; set; }
    }
}
