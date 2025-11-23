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
            AbrirForm(new frmVentas());
        }

        private void btnInvetario_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmInventario());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmEmpleados());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmReportes());
        }
    }
}
