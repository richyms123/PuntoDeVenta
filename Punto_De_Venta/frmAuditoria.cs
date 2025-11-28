using CapaDatos.Objetos;
using CapaDatos2.Consultas;
using Punto_De_Venta.ControlesUsuario;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Punto_De_Venta
{
    public partial class frmAuditoria : Form
    {
        private RepositorioAuditorias repo = new RepositorioAuditorias();
        public frmAuditoria()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Carga el control de auditorias en el panel contenedor
        /// </summary>
        /// <param name="lista"></param>
        private void CargarControl(List<AuditoriaProducto> lista)
        {
            pnlContenedor.SuspendLayout();
            pnlContenedor.Controls.Clear();
            ctlTituloAuditoria ctlTitulo = new ctlTituloAuditoria()
            {
                Dock = DockStyle.Top
            };
            pnlContenedor.Controls.Add(ctlTitulo);
            ctlTitulo.BringToFront();
            foreach (var a in lista)
            {
                ctlAuditoria ctl = new ctlAuditoria()
                {
                    Auditoria = a,
                    Dock = DockStyle.Top
                };
                pnlContenedor.Controls.Add(ctl);
                ctl.BringToFront();
            }

            pnlContenedor.ResumeLayout();
        }

        /// <summary>
        /// Obtiene todas las auditorias de la bd
        /// </summary>
        private void LlenarAuditorias()
        {
            var lista = repo.ObtenerTodos();
            if (lista != null)
                CargarControl(lista);
        }

        private void frmAuditoria_Load(object sender, System.EventArgs e)
        {
            LlenarAuditorias();
        }
    }
}
