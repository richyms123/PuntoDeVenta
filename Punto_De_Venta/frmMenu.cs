using FontAwesome.Sharp.Material;
using Punto_De_Venta.ObjetosGlobales;
using System;
using System.Drawing;
using System.IO;
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

        private void EsconderSubMenu()
        {
            if (pnlSubmenuReportes.Visible)
                pnlSubmenuReportes.Visible = false;


        }

        private void MostrarSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                EsconderSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }


        /// <summary>
        /// Permite abrir un formulario hijo dentro del formulario principal
        /// </summary>
        /// <param name="ChildForm"></param>
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


        /// <summary>
        /// Activa el boton seleccionado para más interacción visual
        /// </summary>
        /// <param name="senderBtn"></param>
        /// <param name="color"></param>
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


        /// <summary>
        /// Desactiva el boton previamente seleccionado
        /// </summary>
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
            EsconderSubMenu();
            ActivarBoton(btnVentas, Color.FromArgb(216, 67, 21));
            AbrirForm(new frmVentas());
        }

        private void btnInvetario_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            ActivarBoton(btnInvetario, Color.FromArgb(216, 67, 21));
            AbrirForm(new frmInventario());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            ActivarBoton(btnEmpleados, Color.FromArgb(216, 67, 21));
            AbrirForm(new frmEmpleados());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Color.FromArgb(216, 67, 21));
            MostrarSubMenu(pnlSubmenuReportes);

        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            ActivarBoton(btnAuditoria, Color.FromArgb(216, 67, 21));
            AbrirForm(new frmAuditoria());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            ActivarBoton(btnInicio, Color.FromArgb(216, 67, 21));
            AbrirForm(new frmInicio());
        }


        /// <summary>
        /// Es donde sucede la configuración inicial del menu, y se cargan los datos del empleado en sesión
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMenu_Load(object sender, EventArgs e)
        {
            pnlSubmenuReportes.Visible = false;

            if (EmpleadoSesion.Rol == 0)
            {
                lblRol.Text = "Empleado";
                btnAuditoria.Visible = false;
                btnEmpleados.Visible = false;
            }
            else
            {
                lblRol.Text = "Administrador";
            }
            lblUsuario.Text = EmpleadoSesion.Usuario;
            if (EmpleadoSesion.FotoEmpleado != null)
                pictureUsuario.Image = ByteAImagen();
            ActivarBoton(btnInicio, Color.FromArgb(216, 67, 21));
            AbrirForm(new frmInicio());
        }


        /// <summary>
        /// Está función convierte el arreglo de bytes de la foto del empleado en sesión a una imagen para mostrarla en el menú
        /// </summary>
        /// <returns>
        /// La imagen convertida
        /// </returns>
        private Image ByteAImagen()
        {
            MemoryStream ms = new MemoryStream(EmpleadoSesion.FotoEmpleado);
            Bitmap bm = null;
            bm = new Bitmap(ms);
            return bm;

        }

        private void btnReporteVentasRango_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmReportes());
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmReporteComparativo());

        }
    }
}
