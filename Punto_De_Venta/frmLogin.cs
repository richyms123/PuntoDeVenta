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
    public partial class frmLogin : Form
    {
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

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Lógica para validaciones e inicio de sesión


            //Si todo esta bien lo deja entrar
            using (var menu = new frmMenu())
            {
                if (menu.ShowDialog() == DialogResult.OK)
                {
                    this.Show(); // Si el menú se cierra con OK, vuelve a mostrar el login
                    txtContrasena.Text = string.Empty; // Limpia la contraseña
                    txtUsuario.Text = string.Empty; // Limpia el usuario
                }
            }
        }
    }
}
