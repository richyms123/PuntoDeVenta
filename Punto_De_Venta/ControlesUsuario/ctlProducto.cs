using CapaDatos.Objetos;
using Punto_De_Venta.ObjetosGlobales;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Punto_De_Venta.ControlesUsuario
{
    public partial class ctlProducto : UserControl
    {
        private Producto producto = new Producto();
        private Color colorSinFoco = Color.Silver;
        // Color cuando el mouse está encima (Naranja)
        private Color colorConFoco = Color.FromArgb(216, 67, 21);
        public ctlProducto()
        {
            InitializeComponent();
            bunifuPanel1.MouseEnter += Efecto_MouseEnter;
            bunifuPanel1.MouseLeave += Efecto_MouseLeave;
            bunifuPanel1.Click += Evento_Click_General;

            foreach (Control control in bunifuPanel1.Controls)
            {
                control.MouseEnter += Efecto_MouseEnter;
                control.MouseLeave += Efecto_MouseLeave;
                control.Click += Evento_Click_General;
            }
        }

        public Producto Producto
        {
            get { return producto; }
            set
            {
                producto = value;
                lblPrecio.Text = "$ " + producto.PrecioUnitario.ToString("N2");
                lblNombre.Text = producto.Nombre;
                lblStock.Text = producto.Stock.ToString();
                if (Producto.FotoProducto != null)
                    picturePan.Image = ByteAImagen();
            }
        }

        private Image ByteAImagen()
        {
            MemoryStream ms = new MemoryStream(Producto.FotoProducto);
            Bitmap bm = null;
            bm = new Bitmap(ms);
            return bm;

        }

        private void Efecto_MouseEnter(object sender, EventArgs e)
        {
            bunifuPanel1.BorderColor = colorConFoco;
            bunifuPanel1.BorderThickness = 1;
            this.Cursor = Cursors.Hand;
        }

        private void Efecto_MouseLeave(object sender, EventArgs e)
        {
            Point puntoMouse = bunifuPanel1.PointToClient(Cursor.Position);

            if (bunifuPanel1.ClientRectangle.Contains(puntoMouse))
            {
                return;
            }

            bunifuPanel1.BorderColor = colorSinFoco;
        }

        public void LlenarProducto()
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
        private void Evento_Click_General(object sender, EventArgs e)
        {
            LlenarProducto();
        }
    }
}
