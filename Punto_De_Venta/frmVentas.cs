using CapaDatos.Objetos;
using CapaDatos2.Consultas;
using Punto_De_Venta.ControlesUsuario;
using Punto_De_Venta.ObjetosGlobales;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Punto_De_Venta
{
    public partial class frmVentas : Form
    {
        RepositorioProductos repositorioProducto = new RepositorioProductos();
        private RepositorioVenta venta = new RepositorioVenta();

        List<DetalleVenta> listaDetalleVenta = new List<DetalleVenta>();
        public frmVentas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Es donde se cargan los controles de productos en el panel contenedor
        /// </summary>
        /// <param name="listaProductos">Una lista con todos los productos</param>
        private void CargarControl(List<Producto> listaProductos)
        {
            pnlContenedor.SuspendLayout();
            pnlContenedor.Controls.Clear();
            foreach (Producto p in listaProductos)
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

        /// <summary>
        /// Permite que al dar click en cualquier parte del control de producto se agregue al ticket de venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Se obtienen los productos de la base de datos
        /// </summary>
        public void LlenarProductos()
        {
            var productos = repositorioProducto.ObtenerTodos();
            if (productos != null)
            {
                CargarControl(productos);
            }
        }
        private void frmVentas_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "$0.00";
            cboMetodoPago.SelectedIndex = 0;
            LlenarProductos();
        }

        /// <summary>
        /// Limpia los controles a su estado inicial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlProductos.Controls.Clear();
            listaDetalleVenta.Clear();
            lblTotal.Text = "$0.00";
        }

        /// <summary>
        /// Se encarga de procesar el cobro de la venta validand que haya productos en el ticket y mostrando mensajes de éxito o error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (listaDetalleVenta.Count == 0)
            {
                MessageBox.Show("No hay productos en el ticket de venta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool resultado = venta.RealizarVenta(listaDetalleVenta, cboMetodoPago.SelectedItem.ToString(), EmpleadoSesion.idEmpleado, EmpleadoSesion.Usuario);
            if (resultado)
            {
                MessageBox.Show("Venta realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlProductos.Controls.Clear();
                listaDetalleVenta.Clear();
                lblTotal.Text = "$0.00";
                LlenarProductos();

            }
            else
            {
                MessageBox.Show("Ocurrió un error al realizar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
