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
            if(txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtPrecio.Text.Trim() == "")
            {
                MessageBox.Show("El precio del producto es obligatorio.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboCategoria.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione una categoría válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 1. Permitir teclas de control
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return;
            }

            // 2. Validar que sea dígito o punto
            bool esNumero = char.IsDigit(e.KeyChar);
            bool esPunto = (e.KeyChar == '.');

            if (!esNumero && !esPunto)
            {
                e.Handled = true;
                return;
            }

            // 3. Validar que no haya doble punto
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
