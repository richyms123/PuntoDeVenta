using CapaDatos2.Objetos;
using System.Windows.Forms;

namespace Punto_De_Venta.ControlesUsuario
{
    public partial class ctlReporte : UserControl
    {
        private ReporteVenta reporteVenta = new ReporteVenta();
        public ctlReporte()
        {
            InitializeComponent();
        }
        public ReporteVenta ReporteVenta
        {
            get { return reporteVenta; }
            set
            {
                reporteVenta = value;
                lblCantidad.Text = reporteVenta.Unidades.ToString();
                lblNombre.Text = reporteVenta.Nombre;
                lblMonto.Text = "$ " + reporteVenta.Monto.ToString("N2");
                lblId.Text = reporteVenta.idProducto.ToString();
            }
        }

    }
}
