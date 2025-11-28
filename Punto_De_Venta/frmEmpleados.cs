using CapaDatos.Consultas;
using CapaDatos.Objetos;
using Punto_De_Venta.ControlesUsuario;
using Punto_De_Venta.ObjetosGlobales;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Punto_De_Venta
{
    public partial class frmEmpleados : Form
    {
        Form frmBackGround = new Form();
        frmReEdEmpleados frm;
        private RepositorioEmpleados repo = new RepositorioEmpleados();
        public frmEmpleados()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga el control de empleados en el panel contenedor.
        /// </summary>
        /// <param name="empleados"></param>
        private void CargarControl(List<Empleado> empleados)
        {
            pnlContenedor.SuspendLayout();
            pnlContenedor.Controls.Clear();
            foreach (Empleado emp in empleados)
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

        /// <summary>
        /// Elimina un empleado después de confirmar la acción con el usuario.
        /// Si el empleado a eliminar es el mismo que el de la sesión actual, muestra un mensaje de error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (EmpleadoSesion.idEmpleado == EmpleadoGlobal.idEmpleado)
            {
                MessageBox.Show("No puede eliminar el empleado que ha iniciado sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var resultado = MessageBox.Show("¿Está seguro de que desea eliminar este empleado?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                string mensaje = "";
                int idEmpleado = EmpleadoGlobal.idEmpleado;
                int res = repo.Eliminar(idEmpleado);
                if (res > 0)
                {
                    MessageBox.Show("Empleado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarEmpleados();
                }
                else
                {
                    MessageBox.Show("Error al eliminar al empleado: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        /// <summary>
        /// Permite abrir el formulario de edición de empleados en modo edición.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            using (frm = new frmReEdEmpleados())
            {
                frm.esModEdicion = true;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LlenarEmpleados();
                }
            }
        }

        /// <summary>
        /// Carga la lista de empleados desde el repositorio 
        /// </summary>
        private void LlenarEmpleados()
        {
            List<Empleado> empleados = repo.ObtenerTodos();
            if (empleados != null)
                CargarControl(empleados);
        }


        /// <summary>
        /// Permite abrir un formulario para agregar un nuevo empleado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
