using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_De_Venta.ControlesUsuario
{
    public partial class ctlEmpleado : UserControl
    {
        private Color colorSinFoco = Color.WhiteSmoke;
        private Color colorConFoco = Color.FromArgb(216, 67, 21);
        public ctlEmpleado()
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

            toolTip.SetToolTip(btnEditar, "Editar Empleado");
            toolTip.SetToolTip(btnEliminar, "Eliminar Empleado");
        }

        private void Efecto_MouseEnter(object sender, EventArgs e)
        {
            bunifuPanel1.BorderColor = colorConFoco;
            bunifuPanel1.BorderThickness = 2;
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
        private void Evento_Click_General(object sender, EventArgs e)
        {
            MessageBox.Show("¡Diste clic en el producto!");


            this.InvokeOnClick(this, EventArgs.Empty);
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
