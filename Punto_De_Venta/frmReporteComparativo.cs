using CapaDatos.Objetos;
using CapaDatos2.Consultas;
using CapaDatos2.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Punto_De_Venta
{
    public partial class frmReporteComparativo : Form
    {
        public frmReporteComparativo()
        {
            InitializeComponent();
        }

        private void CargarProductos()
        {
            var lista = new RepositorioProductos().ObtenerTodos();
            if (lista != null)
            {
                chkListProductos.DataSource= lista;
                chkListProductos.DisplayMember = "Nombre";
                chkListProductos.ValueMember = "IdProducto";
            }

        }

        private void frmReporteComparativo_Load(object sender, EventArgs e)
        {
            cboMes1.SelectedIndex=0;
            cboMes2.SelectedIndex=1;
            CargarProductos();
        }

        private void ConfigurarGraficaComparativa(List<ReporteVentaComparativa> lista, string nombreMes1, string nombreMes2)
        {
            chartReporteComparativo.Series.Clear();
            chartReporteComparativo.Titles.Clear();
            chartReporteComparativo.ChartAreas.Clear();
            chartReporteComparativo.Legends.Clear();

            Title titulo = new Title("Comparativo de ventas en dos diferentes meses");
            titulo.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            titulo.ForeColor = Color.FromArgb(64, 64, 64); 
            chartReporteComparativo.Titles.Add(titulo);

            ChartArea area = new ChartArea();
            area.BackColor = Color.White; 

            area.AxisY.LabelStyle.Format = "C0";
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            area.AxisY.LineColor = Color.Transparent; 
            area.AxisY.LabelStyle.ForeColor = Color.DimGray;
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9);

            area.AxisX.MajorGrid.Enabled = false; 
            area.AxisX.LineColor = Color.Gray;
            area.AxisX.LabelStyle.ForeColor = Color.DimGray;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9);
            area.AxisX.LabelStyle.Angle = -90; 
            area.AxisX.Interval = 1; 
            area.AxisX.IsLabelAutoFit = false;

            chartReporteComparativo.ChartAreas.Add(area);

            Legend leyenda = new Legend();
            leyenda.Docking = Docking.Bottom;
            leyenda.Alignment = StringAlignment.Center;
            leyenda.Font = new Font("Segoe UI", 10);
            chartReporteComparativo.Legends.Add(leyenda);

            Series sMes1 = new Series(nombreMes1);
            sMes1.ChartType = SeriesChartType.Column;
            sMes1.Color = Color.FromArgb(237, 125, 49); 
            sMes1.BorderColor = Color.White; 
            sMes1.BorderWidth = 2;
            sMes1.IsValueShownAsLabel = true;
            sMes1.LabelFormat = "C0"; // Formato Moneda ($)
            sMes1.LabelForeColor = Color.DimGray;

            Series sMes2 = new Series(nombreMes2);
            sMes2.ChartType = SeriesChartType.Column;
            sMes2.Color = Color.FromArgb(84, 130, 53);
            sMes2.BorderColor = Color.White;
            sMes2.BorderWidth = 2;
            sMes2.IsValueShownAsLabel = true;
            sMes2.LabelFormat = "C0";
            sMes2.LabelForeColor = Color.DimGray;



            foreach (var i in lista)
            {
                string nombreProducto = i.Nombre;
                string etiquetaEjeX = i.idProducto.ToString();

                float ventaMes1 = i.MontoMes1;
                float ventaMes2 = i.MontoMes2;

                sMes1.Points.AddXY(nombreProducto, ventaMes1);
                sMes2.Points.AddXY(nombreProducto, ventaMes2);
            }

          
            chartReporteComparativo.Series.Add(sMes1);
            chartReporteComparativo.Series.Add(sMes2);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if(cboMes1.SelectedIndex==cboMes2.SelectedIndex)
            {
                MessageBox.Show("Debe seleccionar meses diferentes","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if(chkListProductos.CheckedItems.Count==0)
            {
                MessageBox.Show("Debe seleccionar al menos un producto","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            int mes1 = cboMes1.SelectedIndex + 1;
            int mes2 = cboMes2.SelectedIndex + 1;
            List<int> idsSeleccionados = new List<int>();

            foreach (var item in chkListProductos.CheckedItems)
            {
                Producto prod = (Producto)item;
                idsSeleccionados.Add(prod.idProducto);
            }
            var reporte = new RepositorioVenta().ObtenerReporteComparativo(mes1, mes2, idsSeleccionados);
            if(reporte!=null)
            {
                    string nombreMes1 = new DateTime(1, mes1, 1).ToString("MMMM");
                    string nombreMes2 = new DateTime(1, mes2, 1).ToString("MMMM");
                ConfigurarGraficaComparativa(reporte, nombreMes1, nombreMes2);
            }
        }
    }
}
