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
    public partial class frmEmpleados : Form
    {
        Form frmBackGround = new Form();
        frmReEdEmpleados frm;
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            frmBackGround = new Form();
            using (frm = new frmReEdEmpleados())
            {


                frm.Owner = frmBackGround;
                //frm.EsModoEdicion = false;
                ConfigurarFormBackground(frmBackGround);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                }
                frmBackGround.Dispose();
            }
        }
        private void ConfigurarFormBackground(Form frmBackGround)
        {
            frmBackGround.StartPosition = FormStartPosition.Manual;
            frmBackGround.FormBorderStyle = FormBorderStyle.None;
            frmBackGround.Opacity = .50d;
            frmBackGround.BackColor = Color.Black;
            frmBackGround.WindowState = FormWindowState.Maximized;
            frmBackGround.Location = this.Location;
            frmBackGround.TopMost = true;
            frmBackGround.ShowInTaskbar = false;
            frmBackGround.Show();
        }
    }
}
