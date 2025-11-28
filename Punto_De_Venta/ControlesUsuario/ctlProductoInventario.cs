using CapaDatos.Objetos;
using Punto_De_Venta.ObjetosGlobales;
using System;
using System.Windows.Forms;

namespace Punto_De_Venta.ControlesUsuario
{
    public partial class ctlProductoInventario : UserControl
    {
        private Producto producto = new Producto();
        public ctlProductoInventario()
        {
            InitializeComponent();
        }

        public Producto Producto
        {
            get { return producto; }
            set
            {
                producto = value;
                lblNombre.Text = producto.Nombre;
                lblId.Text = producto.idProducto.ToString();
                lblPrecio.Text = "$ " + producto.PrecioUnitario.ToString("F2");
                lblStock.Text = producto.Stock.ToString();
                lblUnidad.Text = producto.CantidadPorUnidad;


            }
        }

        public string NombreCategoria
        {
            get { return lblCategoria.Text; }
            set
            {
                lblCategoria.Text = value;
            }
        }

        private void LlenarProductos()
        {
            ProductoGlobal.idProducto = producto.idProducto;
            ProductoGlobal.Nombre = producto.Nombre;
            ProductoGlobal.CantidadPorUnidad = producto.CantidadPorUnidad;
            ProductoGlobal.PrecioUnitario = producto.PrecioUnitario;
            ProductoGlobal.Stock = producto.Stock;
            ProductoGlobal.Descontinuado = producto.Descontinuado;
            ProductoGlobal.FotoProducto = producto.FotoProducto;
            ProductoGlobal.idCategoria = producto.idCategoria;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LlenarProductos();
        }

        private void btnTrash_Click(object sender, EventArgs e)
        {
            LlenarProductos();
        }
    }
}
