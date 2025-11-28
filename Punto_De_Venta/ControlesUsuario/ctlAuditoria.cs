using CapaDatos.Objetos;
using System.Drawing;
using System.Windows.Forms;

namespace Punto_De_Venta.ControlesUsuario
{
    public partial class ctlAuditoria : UserControl
    {
        private AuditoriaProducto auditoria = new AuditoriaProducto();
        public ctlAuditoria()
        {
            InitializeComponent();
        }
        public AuditoriaProducto Auditoria
        {
            get { return auditoria; }
            set
            {
                auditoria = value;
                lblFecha.Text = auditoria.FechaDeCambio.ToString("g");
                lblId.Text = auditoria.idAuditoria.ToString();
                lblIdProducto.Text = auditoria.NombreProducto;
                lblCambio.Text = auditoria.ValorAnterior.ToString("F2") + "  -->  " + auditoria.ValorNuevo.ToString("F2");
                lblTipo.Text = auditoria.TipoCambio;
                if (auditoria.TipoCambio == "Insert")
                {
                    lblTipo.ForeColor = Color.Green;
                }
                else if (auditoria.TipoCambio == "Delete")
                {
                    lblTipo.ForeColor = Color.Red;
                }
                else
                {
                    lblTipo.ForeColor = Color.Orange;
                }
                lblUsuario.Text = auditoria.Usuario;
            }
        }
    }
}
