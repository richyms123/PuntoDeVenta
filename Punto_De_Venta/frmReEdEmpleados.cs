using CapaDatos.Consultas;
using CapaDatos.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_De_Venta
{
    public partial class frmReEdEmpleados : Form
    {
        private OpenFileDialog abrir;
        public bool esModEdicion { get; set; } = false;
        private RepositorioEmpleados repositorio=new RepositorioEmpleados();
        public frmReEdEmpleados()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                MessageBox.Show("El campo 'Apellidos' es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellidos.Focus();
                return false;
            }

            int edad = DateTime.Today.Year - dtpFechaNacimiento.Value.Year;
            if (dtpFechaNacimiento.Value.Date > DateTime.Today.AddYears(-edad)) edad--;

            if (edad < 18)
            {
                MessageBox.Show("El empleado debe ser mayor de edad (18+).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaNacimiento.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtCalle.Text)) 
            {
                MessageBox.Show("La 'Calle y número' son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCalle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMunicipio.Text) || string.IsNullOrWhiteSpace(txtEstado.Text))
            {
                MessageBox.Show("Municipio y Estado son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMunicipio.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtCp.Text, @"^\d{5}$"))
            {
                MessageBox.Show("El Código Postal debe contener 5 dígitos numéricos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCp.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtTelefono.Text, @"^\d{10}$"))
            {
                MessageBox.Show("El Teléfono debe ser de 10 dígitos numéricos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(txtCorreo.Text, patronEmail))
            {
                MessageBox.Show("Por favor ingresa un Correo Electrónico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return false;
            }


            if (cboTurno.SelectedIndex == -1 || cboTurno.SelectedIndex==0)
            {
                MessageBox.Show("Debes seleccionar un Turno.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTurno.DroppedDown = true; 
                return false;
            }

            if (cboRol.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un Rol (Empleado/Admin).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboRol.DroppedDown = true;
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("El campo 'Usuario' es obligatorio para el login.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Debes asignar una contraseña.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena.Focus();
                return false;
            }

            return true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReEdEmpleados_Load(object sender, EventArgs e)
        {
            cboTurno.SelectedIndex = 0;
            cboRol.SelectedIndex = 0;
            if (esModEdicion)
            {
                txtNombre.Text = EmpleadoGlobal.Nombre;
                txtApellidos.Text = EmpleadoGlobal.Apellidos;
                txtUsuario.Text= EmpleadoGlobal.Usuario;
                txtContrasena.Text = EmpleadoGlobal.Pasword;
                cboRol.SelectedIndex = EmpleadoGlobal.Rol;
                if (EmpleadoGlobal.Turno == "Matutino")
                    cboTurno.SelectedIndex = 1;
                else
                    cboTurno.SelectedIndex = 2;
                txtCalle.Text = EmpleadoGlobal.Direccion;
                txtMunicipio.Text = EmpleadoGlobal.Municipio;
                txtPais.Text = EmpleadoGlobal.Pais;
                txtTelefono.Text = EmpleadoGlobal.Telefono;
                txtEstado.Text = EmpleadoGlobal.Estado;
                txtCp.Text = EmpleadoGlobal.CodigoPostal;
                txtCorreo.Text = EmpleadoGlobal.Mail;
                if(ByteAImagen()!=null)
                    pictureEmpleado.Image = ByteAImagen();
                
                dtpFechaNacimiento.Value=EmpleadoGlobal.FechaNacimiento;
            }

        }

        private Image ByteAImagen()
        {
            try
            {
                using (var ms = new MemoryStream(EmpleadoGlobal.FotoEmpleado))
                using (var tmp = Image.FromStream(ms))
                {
                    return new Bitmap(tmp); // devuelve una copia independiente
                }
            }
            catch
            {
                return null;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            try
            {


                Empleado empleado = new Empleado
                {
                    idEmpleado = EmpleadoGlobal.idEmpleado,
                    Nombre = txtNombre.Text.Trim(),
                    Apellidos = txtApellidos.Text.Trim(),
                    Usuario = txtUsuario.Text.Trim(),
                    Pasword = txtContrasena.Text.Trim(),
                    Rol = cboRol.SelectedIndex + 1,
                    Turno = cboTurno.SelectedItem.ToString(),
                    Direccion = txtCalle.Text.Trim(),
                    Municipio = txtMunicipio.Text.Trim(),
                    Pais = txtPais.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Estado = txtEstado.Text.Trim(),
                    CodigoPostal = txtCp.Text.Trim(),
                    Mail = txtCorreo.Text.Trim(),
                    FotoEmpleado = ConvertirImg(),
                    FechaDeAlta = DateTime.Now,
                    FehaNacimiento = dtpFechaNacimiento.Value

                };
                if (esModEdicion)
                {
                    empleado.Activo = true;
                    int result = repositorio.Editar(empleado);
                    if (result > 0)
                    {
                        MessageBox.Show("Empleado editado correctamente");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Error al editar un empleado");
                    }
                }
                else
                {
                    int result = repositorio.Agregar(empleado);
                    if (result > 0)
                    {
                        MessageBox.Show("Empleado agregado correctamente");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar un empleado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private byte[] ConvertirImg()
        {
            if (pictureEmpleado.Image != null)
            {
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    pictureEmpleado.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }
            return null;
        }

        private void pictureEmpleado_DoubleClick(object sender, EventArgs e)
        {
            abrir = new OpenFileDialog();
            abrir.Filter = "PNG|*.png|JPG|*.jpg|GIF|*.gif|JPEG|*.jpeg";
            System.IO.Stream mystream = null;

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((mystream = abrir.OpenFile()) != null)
                    {
                        using (mystream)
                        {
                            pictureEmpleado.Image = Image.FromStream(mystream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No se pudo leer el archivo. Original error: " + ex.Message);

                }
            }
        }
    }
}
