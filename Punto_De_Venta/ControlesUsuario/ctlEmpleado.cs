using CapaDatos.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private Empleado empleado = new Empleado();
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

        public Empleado Empleado
        {
            get { return empleado; }
            set
            {
                empleado = value;
                lblNombre.Text = empleado.Nombre + " " + empleado.Apellidos;
                lblCorreo.Text = empleado.Mail;
                lblRol.Text= empleado.Rol == 1 ? "Administrador" : "Empleado";
                lblTelefono.Text = empleado.Telefono;
                if (empleado.FotoEmpleado!=null)
                {
                    
                    
                        try
                        {
                            pictureEmpleado.Image = ByteAImagen();
                        }
                        catch
                        {
                            
                        }
                    
                }
                
                if (empleado.Rol == 1)
                {
                    pnlContenedorRol.GradientTopLeft = Color.FromArgb(255, 215, 64);  
                    pnlContenedorRol.GradientTopRight = Color.FromArgb(255, 215, 64); 
                    pnlContenedorRol.GradientBottomLeft = Color.FromArgb(255, 160, 0); 
                    pnlContenedorRol.GradientBottomRight = Color.FromArgb(255, 160, 0); 
                }
                else
                {
                    pnlContenedorRol.GradientTopLeft = Color.FromArgb(41, 128, 185);    
                    pnlContenedorRol.GradientTopRight = Color.FromArgb(41, 128, 185);  
                    pnlContenedorRol.GradientBottomLeft = Color.FromArgb(31, 97, 141);  
                    pnlContenedorRol.GradientBottomRight = Color.FromArgb(31, 97, 141); 
                }

            }
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
            this.InvokeOnClick(this, EventArgs.Empty);
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
        private Image ByteAImagen()
        {
            MemoryStream ms = new MemoryStream(Empleado.FotoEmpleado);
            Bitmap bm = null;
            bm = new Bitmap(ms);
            return bm;

        }

        private void LlenarEmpleado()
        {
            EmpleadoGlobal.Nombre = empleado.Nombre;
            EmpleadoGlobal.Apellidos = empleado.Apellidos;
            EmpleadoGlobal.Usuario = empleado.Usuario;
            EmpleadoGlobal.Pasword = empleado.Pasword;
            EmpleadoGlobal.Activo = empleado.Activo;
            EmpleadoGlobal.Rol = empleado.Rol;
            EmpleadoGlobal.Turno = empleado.Turno;
            EmpleadoGlobal.Direccion = empleado.Direccion;
            EmpleadoGlobal.Municipio = empleado.Municipio;
            EmpleadoGlobal.Estado = empleado.Estado;
            EmpleadoGlobal.CodigoPostal = empleado.CodigoPostal;
            EmpleadoGlobal.Pais = empleado.Pais;
            EmpleadoGlobal.Telefono = empleado.Telefono;
            EmpleadoGlobal.Mail = empleado.Mail;
            EmpleadoGlobal.FotoEmpleado = empleado.FotoEmpleado;
            EmpleadoGlobal.FechaDeAlta = empleado.FechaDeAlta;
            EmpleadoGlobal.idEmpleado = empleado.idEmpleado;
            EmpleadoGlobal.FechaNacimiento = empleado.FehaNacimiento;




        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            LlenarEmpleado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            LlenarEmpleado();
        }
    }
}
