using CapaDatos.Objetos;
using Punto_De_Venta.ControlesUsuario;
using Punto_De_Venta.ObjetosGlobales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_De_Venta
{
    public partial class frmVentas : Form
    {
        
        List<DetalleVenta> listaDetalleVenta= new List<DetalleVenta>();
        public frmVentas()
        {
            InitializeComponent();
        }

        private void CargarControl(List<Producto> listaProductos)
        {
            pnlContenedor.SuspendLayout();
            pnlContenedor.Controls.Clear();
            foreach(Producto p in listaProductos)
            {
                ctlProducto control = new ctlProducto()
                {
                    Producto = p
                };
                pnlContenedor.Controls.Add(control);
                control.BringToFront();
                control.bunifuPanel1.Click += Control_Evento_Click_General;
                control.picturePan.Click += Control_Evento_Click_General;
                control.lblNombre.Click += Control_Evento_Click_General;
                control.lblPrecio.Click += Control_Evento_Click_General;

            }
            pnlContenedor.ResumeLayout();
        }

        private void Control_Evento_Click_General(object sender, EventArgs e)
        {
            pnlProductos.SuspendLayout();
            ctlTicketProducto ctl = new ctlTicketProducto();
            var controlTicketProducto = pnlProductos.Controls.OfType<ctlTicketProducto>().FirstOrDefault(x => x.IdProducto == ProductoGlobal.idProducto);
            if (controlTicketProducto != null)
            {
                controlTicketProducto.Cantidad += 1;
                controlTicketProducto.SubTotal = (ProductoGlobal.PrecioUnitario * controlTicketProducto.Cantidad).ToString("$0.00");
                listaDetalleVenta.Where(x => x.idProducto == ProductoGlobal.idProducto).ToList().ForEach(x =>
                {
                    x.Cantidad = controlTicketProducto.Cantidad;
                    x.SubTotal = ProductoGlobal.PrecioUnitario * x.Cantidad;
                });
                lblTotal.Text = listaDetalleVenta.Sum(x => x.SubTotal).ToString("$0.00");
            }
            else
            {
                ctl.IdProducto = ProductoGlobal.idProducto;
                ctl.NombreProducto = ProductoGlobal.Nombre;
                ctl.Cantidad = 1;
                ctl.SubTotal = (ProductoGlobal.PrecioUnitario * ctl.Cantidad).ToString("$0.00");
                ctl.Dock = DockStyle.Top;
                pnlProductos.Controls.Add(ctl);
                ctl.BringToFront();
                listaDetalleVenta.Add(new DetalleVenta
                {
                    idProducto = ProductoGlobal.idProducto,
                    Cantidad = ctl.Cantidad,
                    PrecioUnitario = ProductoGlobal.PrecioUnitario,
                    Descuento = 0,
                    SubTotal = ProductoGlobal.PrecioUnitario * ctl.Cantidad
                });
                lblTotal.Text = listaDetalleVenta.Sum(x => x.SubTotal).ToString("$0.00");
            }
            
            pnlProductos.ResumeLayout();

        }

        public void LlenarProductos()
        {
            /*var productos = repositorioProducto.ObtenerTodos();
            if (productos != null)
            {
                CargarControl(productos);
            }*/
        }
        private void frmVentas_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "$0.00";
            cboMetodoPago.SelectedIndex = 0;
            LlenarProductos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlProductos.Controls.Clear();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if(listaDetalleVenta.Count == 0)
            {
                MessageBox.Show("No hay productos en el ticket de venta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var detalle in listaDetalleVenta)
            {
                Console.WriteLine($"Producto ID: {detalle.idProducto}, Cantidad: {detalle.Cantidad}, SubTotal: {detalle.SubTotal}");
            }
        }
    }
}
