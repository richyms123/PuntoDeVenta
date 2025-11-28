using CapaDatos.Consultas;
using CapaDatos.Objetos;
using Punto_De_Venta.ObjetosGlobales;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Punto_De_Venta
{
    public partial class frmLogin : Form
    {

        private RepositorioEmpleados empleado = new RepositorioEmpleados();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            bunifuPanel2.BorderColor = Color.FromArgb(216, 67, 21);
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            bunifuPanel2.BorderColor = Color.Silver;
        }

        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            bunifuPanel3.BorderColor = Color.FromArgb(216, 67, 21);
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            bunifuPanel3.BorderColor = Color.Silver;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Es donde se realiza la validacion del usuario y la contraseña para iniciar sesión
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor ingresa tu nombre de usuario.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Por favor ingresa tu contraseña.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return;
            }
            Empleado emp = empleado.Login(txtUsuario.Text, txtContrasena.Text);
            if (emp == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContrasena.Focus();
                return;
            }
            EmpleadoSesion.idEmpleado = emp.idEmpleado;
            EmpleadoSesion.Nombre = emp.Nombre;
            EmpleadoSesion.Apellidos = emp.Apellidos;
            EmpleadoSesion.Rol = emp.Rol;
            EmpleadoSesion.Usuario = emp.Usuario;
            EmpleadoSesion.FotoEmpleado = emp.FotoEmpleado;



            using (var menu = new frmMenu())
            {
                if (menu.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                    txtContrasena.Text = string.Empty;
                    txtUsuario.Text = string.Empty;
                }
            }
        }
    }
}
