using CapaDatos.Objetos;
using CapaDatos2.Consultas;
using Punto_De_Venta.ControlesUsuario;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Punto_De_Venta
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Carga el control de productos con bajo stock
        /// </summary>
        /// <param name="lista"></param>
        private void CargarControl(List<Producto> lista)
        {
            pnlContenedor.SuspendLayout();
            pnlContenedor.Controls.Clear();
            foreach (var p in lista)
            {
                ctlStockBajo ctl = new ctlStockBajo()
                {
                    NombreProducto = p.Nombre,
                    Stock = p.Stock.ToString(),
                    Dock = DockStyle.Top
                };
                pnlContenedor.Controls.Add(ctl);
                ctl.BringToFront();
            }
            pnlContenedor.ResumeLayout();
        }

        /// <summary>
        /// Obtiene los productos con bajo stock de la bd
        /// </summary>
        private void CargarProductos()
        {
            var lista = new RepositorioProductos().ListarProductosBajoStock();
            if (lista != null)
                CargarControl(lista);

        }

        /// <summary>
        /// En esta funcion se configura toda la estetica de la grafica de top ventas
        /// </summary>
        private void CargarGraficaTopVentas()
        {
            chartTopVentas.Series.Clear();
            chartTopVentas.Titles.Clear();
            chartTopVentas.ChartAreas.Clear();
            chartTopVentas.Legends.Clear();

            ChartArea area = new ChartArea();
            area.BackColor = Color.Transparent;

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(230, 230, 230);
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            area.AxisX.LineWidth = 0;
            area.AxisY.LineWidth = 0;

            area.AxisX.LabelStyle.ForeColor = Color.Gray;
            area.AxisY.LabelStyle.ForeColor = Color.Gray;

            chartTopVentas.ChartAreas.Add(area);

            Series serie = new Series("Ventas");
            serie.ChartType = SeriesChartType.Column;


            serie.IsValueShownAsLabel = true;
            serie.LabelForeColor = Color.FromArgb(93, 64, 55);
            serie.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            var lista = new RepositorioProductos().SeleccionarTop5MasVendidos();

            Color[] paleta = new Color[] {
                Color.FromArgb(216, 67, 21),  // Naranja
                Color.FromArgb(249, 168, 37), // Dorado
                Color.FromArgb(93, 64, 55),   // Café Oscuro
                Color.FromArgb(141, 110, 99), // Café Claro
                Color.FromArgb(255, 204, 188) // Crema
            };
            int contador = 0;
            if (lista != null)
            {
                foreach (var p in lista)
                {
                    string nombre = p.Nombre;
                    int cantidad = p.productosActivos;
                    int puntoIndex = serie.Points.AddXY(nombre, cantidad);
                    serie.Points[puntoIndex].Color = paleta[contador % paleta.Length];

                    contador++;
                }
            }
            serie["PixelPointWidth"] = "30";

            chartTopVentas.Series.Add(serie);
        }

        private void CargarVentasHoy()
        {
            float ventasHoy = new RepositorioVenta().ObtenerVentasHoy();
            lblVentasHoy.Text = "$" + ventasHoy.ToString("N2");
        }

        private void ProductosActivos()
        {
            int productosActivos = new RepositorioProductos().ContarProductosActivos();
            lblProductos.Text = productosActivos.ToString();

        }

        private void ProductosConBajoStock()
        {
            int productosBajoStock = new RepositorioProductos().ContarProductosBajoStock();
            lblTotalStockBajo.Text = productosBajoStock.ToString();

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            ProductosActivos();
            ProductosConBajoStock();
            CargarProductos();
            CargarVentasHoy();
            CargarGraficaTopVentas();
        }
    }
}
