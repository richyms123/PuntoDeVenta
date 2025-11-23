using FontAwesome.Sharp.Material;
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
    public partial class frmMenu : Form
    {
        private Form ActiveForm = null;
        private FontAwesome.Sharp.Material.MaterialButton botonActual = null;
        public frmMenu()
        {
            InitializeComponent();
        }

        public void AbrirForm(Form ChildForm)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(ChildForm);
            pnlContenedor.Tag = ChildForm;
            ChildForm.BringToFront();

            ChildForm.Show();
        }

        private void ActivarBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                if (botonActual != senderBtn)
                {
                    DesactivarBoton();
                    botonActual = (MaterialButton)senderBtn;
                    botonActual.BackColor = color;
                    botonActual.IconColor = Color.White;
                    botonActual.ForeColor = Color.White;
                }

            }
        }

        private void DesactivarBoton()
        {
            if (botonActual != null)
            {
                botonActual.IconColor = Color.White;
                botonActual.ForeColor = Color.White;
                botonActual.BackColor = Color.FromArgb(62, 39, 35);
            }
        }



        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnVentas, Color.FromArgb(216, 67, 21));
            AbrirForm(new frmVentas());
        }

        private void btnInvetario_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnInvetario, Color.FromArgb(216, 67, 21));
            AbrirForm(new frmInventario());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnEmpleados, Color.FromArgb(216, 67, 21));
            AbrirForm(new frmEmpleados());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Color.FromArgb(216, 67, 21));
            AbrirForm(new frmReportes());
        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnAuditoria, Color.FromArgb(216, 67, 21));
            AbrirForm(new frmAuditoria());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ActivarBoton(btnInicio, Color.FromArgb(216, 67, 21));
            AbrirForm(new frmInicio());
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            ActivarBoton(btnInicio, Color.FromArgb(216, 67, 21));
            AbrirForm(new frmInicio());
        }
    }
}
