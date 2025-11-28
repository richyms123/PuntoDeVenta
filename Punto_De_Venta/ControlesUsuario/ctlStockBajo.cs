using System.Windows.Forms;

namespace Punto_De_Venta.ControlesUsuario
{
    public partial class ctlStockBajo : UserControl
    {
        public ctlStockBajo()
        {
            InitializeComponent();
        }
        public string NombreProducto
        {
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }
        }

        public string Stock
        {
            get { return lblCantidad.Text; }
            set { lblCantidad.Text = value; }
        }
    }
}
