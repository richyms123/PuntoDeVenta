using CapaDatos2.Consultas;
using CapaDatos2.Objetos;
using Punto_De_Venta.ControlesUsuario;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Punto_De_Venta
{
    public partial class frmReportes : Form
    {
        private RepositorioVenta repositorioVenta = new RepositorioVenta();
        public frmReportes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Se utiliza para cargar el control de reporte dentro del panel contenedor
        /// </summary>
        /// <param name="lista">Una lista de reporte ventas</param>
        private void CargarControl(List<ReporteVenta> lista)
        {
            pnlContenedor.SuspendLayout();
            pnlContenedor.Controls.Clear();
            ctlTituloReporte ctlTitulo = new ctlTituloReporte()
            {
                Dock = DockStyle.Top
            };
            pnlContenedor.Controls.Add(ctlTitulo);
            ctlTitulo.BringToFront();
            foreach (var l in lista)
            {
                ctlReporte ctl = new ctlReporte()
                {
                    ReporteVenta = l,
                    Dock = DockStyle.Top
                };
                pnlContenedor.Controls.Add(ctl);
                ctl.BringToFront();
            }
            pnlContenedor.ResumeLayout();
        }

        /// <summary>
        /// Carga el reporte de la bd en una lista de tipo reporte venta
        /// </summary>
        private void LlenarReporte()
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFin.Value.Date;
            List<ReporteVenta> lista = repositorioVenta.ObtenerReporte(fechaInicio, fechaFin);
            if (lista != null)
                CargarControl(lista);
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Now.AddDays(-7);
            dtpFechaFin.Value = DateTime.Now;
        }

        /// <summary>
        /// Se genera el reporte en base a las fechas seleccionadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Value.Date > dtpFechaFin.Value.Date)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LlenarReporte();
        }
    }
}
