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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

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

            serie.Points.AddXY("Bolillo", 1500);
            serie.Points.AddXY("Concha", 1200);
            serie.Points.AddXY("Dona", 900);
            serie.Points.AddXY("Pastel", 600);
            serie.Points.AddXY("Café", 450);

           
            serie.Points[0].Color = Color.FromArgb(216, 67, 21); 
            serie.Points[1].Color = Color.FromArgb(249, 168, 37); 
            serie.Points[2].Color = Color.FromArgb(93, 64, 55);  
            serie.Points[3].Color = Color.FromArgb(141, 110, 99); 
            serie.Points[4].Color = Color.FromArgb(255, 204, 188); 

            serie["PixelPointWidth"] = "30";

            chartTopVentas.Series.Add(serie);
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            CargarGraficaTopVentas();
        }
    }
}
