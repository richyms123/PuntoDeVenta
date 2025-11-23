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
    public partial class frmInventario : Form
    {
        private OpenFileDialog abrir;
        public frmInventario()
        {
            InitializeComponent();
        }

        private void pictureProduct_DoubleClick(object sender, EventArgs e)
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
                            pictureProducto.Image = Image.FromStream(mystream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No se pudo leer el archivo. Original error: " + ex.Message);

                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número mayor a 0.", "Precio Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }
            if (!int.TryParse(txtCantidad.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número entero positivo.", "Stock Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return;
            }
            if (cboCategoria.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione una categoría válida.", "Falta Categoría", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCategoria.DroppedDown = true;
                return;
            }

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            bool esNumero = char.IsDigit(e.KeyChar);
            bool esPunto = (e.KeyChar == '.');

            if (!esNumero && !esPunto)
            {
                e.Handled = true;
                return;
            }

            if (esPunto && txtPrecio.Text.Contains("."))
            {
                e.Handled = true;
                return;
            }

            string textoPredicho = txtPrecio.Text.Remove(txtPrecio.SelectionStart, txtPrecio.SelectionLength)
                                                 .Insert(txtPrecio.SelectionStart, e.KeyChar.ToString());
            if (double.TryParse(textoPredicho, out double valor))
            {
                if (valor > 9999.99)
                {
                    e.Handled = true;
                    return;
                }
            }

            e.Handled = false;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            if (char.IsDigit(e.KeyChar))
            {
                if (txtCantidad.Text.Length >= 4 && txtCantidad.SelectionLength == 0)
                {
                    e.Handled = true; 
                    return;
                }

                e.Handled = false; 
                return;
            }

            e.Handled = true;
        }
    }
}
