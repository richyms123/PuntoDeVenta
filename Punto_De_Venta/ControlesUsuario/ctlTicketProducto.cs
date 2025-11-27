using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_De_Venta.ControlesUsuario
{
    public partial class ctlTicketProducto : UserControl
    {
        public ctlTicketProducto()
        {
            InitializeComponent();
        }
        public string NombreProducto
        {
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }
        }
        public int Cantidad
        {
            get { return int.Parse(lblCantidad.Text); }
            set { lblCantidad.Text = value.ToString(); }
        }
        public string SubTotal
        {
            get { return lblSubTotal.Text; }
            set { lblSubTotal.Text = value; }
        }
        public int IdProducto { get; set; }
    }
}
