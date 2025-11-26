using CapaDatos.Consultas;
using CapaDatos.Objetos;
using Punto_De_Venta.ControlesUsuario;
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
        private RepositorioEmpleados repo= new RepositorioEmpleados();
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void CargarControl(List<Empleado> empleados)
        {
            pnlContenedor.SuspendLayout();
            pnlContenedor.Controls.Clear();
            foreach(Empleado emp in empleados)
            {
                ctlEmpleado ctl = new ctlEmpleado();
                ctl.Empleado = emp;
                pnlContenedor.Controls.Add(ctl);
                ctl.BringToFront();
                ctl.btnEditar.Click += BtnEditar_Click;
                ctl.btnEliminar.Click += BtnEliminar_Click;
            }
            pnlContenedor.ResumeLayout();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            using(frm=new frmReEdEmpleados())
            {
                frm.esModEdicion = true;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LlenarEmpleados();
                }
            }
        }

        private void LlenarEmpleados()
        {
            List<Empleado> empleados = repo.ObtenerTodos();
            if(empleados!=null)
                CargarControl(empleados);
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            //frmBackGround = new Form();
            using (frm = new frmReEdEmpleados())
            {


                //.Owner = frmBackGround;
                //frm.EsModoEdicion = false;
                //ConfigurarFormBackground(frmBackGround);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LlenarEmpleados();
                }
                //frmBackGround.Dispose();
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

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            LlenarEmpleados();
        }
    }
}
