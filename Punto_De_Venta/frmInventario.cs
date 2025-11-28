using CapaDatos.Objetos;
using CapaDatos2.Consultas;
using Punto_De_Venta.ControlesUsuario;
using Punto_De_Venta.ObjetosGlobales;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Punto_De_Venta
{
    public partial class frmInventario : Form
    {
        List<Categoria> listaCategorias = new List<Categoria>();
        private bool esModoEdicion = false;
        int idProductoEditar = 0;
        private OpenFileDialog abrir;
        private RepositorioProductos repositorioProductos = new RepositorioProductos();
        public frmInventario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Permite cargar los controles de productos en el panel contenedor
        /// </summary>
        /// <param name="listaProductos">Una lista de productos</param>
        private void CargarControl(List<Producto> listaProductos)
        {
            pnlContenedor.Controls.Clear();
            pnlContenedor.SuspendLayout();
            ctlTituloProductoInventario titulo = new ctlTituloProductoInventario();
            titulo.Dock = DockStyle.Top;
            pnlContenedor.Controls.Add(titulo);
            titulo.BringToFront();
            foreach (Producto p in listaProductos)
            {
                ctlProductoInventario control = new ctlProductoInventario();
                control.Producto = p;
                control.NombreCategoria = listaCategorias.FirstOrDefault(c => c.idCategoria == p.idCategoria)?.Nombre;
                control.Dock = DockStyle.Top;
                pnlContenedor.Controls.Add(control);
                control.BringToFront();
                control.btnEditar.Click += BtnEditar_Click;
                control.btnEliminar.Click += BtnEliminar_Click;
            }
            pnlContenedor.ResumeLayout();
        }

        /// <summary>
        /// Realiza la eliminación de un producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                string mensaje = "";
                int idProductoAEliminar = ProductoGlobal.idProducto;
                int res = repositorioProductos.Eliminar(idProductoAEliminar, EmpleadoSesion.Usuario, out mensaje);
                if (res > 0)
                {
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LlenarProductos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el producto: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Permite configurar los campos para editar un producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditar_Click(object sender, EventArgs e)
        {

            txtNombre.Text = ProductoGlobal.Nombre;
            txtUnidad.Text = ProductoGlobal.CantidadPorUnidad;
            txtPrecio.Text = ProductoGlobal.PrecioUnitario.ToString();
            txtCantidad.Text = ProductoGlobal.Stock.ToString();
            cboCategoria.SelectedValue = ProductoGlobal.idCategoria;
            idProductoEditar = ProductoGlobal.idProducto;
            if (ProductoGlobal.FotoProducto != null)
            {
                MemoryStream ms = new MemoryStream(ProductoGlobal.FotoProducto);
                Bitmap bm = null;
                bm = new Bitmap(ms);
                pictureProducto.Image = bm;
            }
            else if (pictureProducto.Image != null)
            {
                pictureProducto.Image = Properties.Resources.iconoImagen;
            }

        }

        /// <summary>
        /// Obtiene los productos de la base de datos
        /// </summary>
        private void LlenarProductos()
        {
            List<Producto> listaProductos = repositorioProductos.ObtenerTodos();
            if (listaProductos != null)
                CargarControl(listaProductos);
        }


        /// <summary>
        /// Obtiene las categorias de la base de datos y las carga en el combobox
        /// </summary>
        private void CargarCategorias()
        {
            listaCategorias = new RepositorioCategoria().ObtenerTodos();
            cboCategoria.DisplayMember = "Nombre";
            cboCategoria.ValueMember = "idCategoria";
            cboCategoria.DataSource = listaCategorias;
        }

        /// <summary>
        /// Permite que al darle doble click a la foto se abra un dialogo para elegir una foto desde tu computadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Es donde se guardan los productos nuevos o editados y se validan los campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if (cboCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoría válida.", "Falta Categoría", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCategoria.DroppedDown = true;
                return;
            }
            Producto p = new Producto()
            {
                idProducto = idProductoEditar,
                Nombre = txtNombre.Text.Trim(),
                CantidadPorUnidad = txtUnidad.Text.Trim(),
                Stock = Convert.ToInt32(txtCantidad.Text.Trim()),
                PrecioUnitario = Convert.ToSingle(txtPrecio.Text.Trim()),
                idCategoria = ((Categoria)cboCategoria.SelectedItem).idCategoria,
                Descontinuado = false,
                FotoProducto = ConvertirImg()
            };
            if (idProductoEditar > 0)
            {
                string mensaje = "";
                int resultado = repositorioProductos.Editar(p, EmpleadoSesion.Usuario, out mensaje);
                if (resultado > 0)
                {
                    MessageBox.Show("Producto editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al editar el producto: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string mensaje = "";
                int resultado = repositorioProductos.Agregar(p, EmpleadoSesion.Usuario, out mensaje);
                if (resultado > 0)
                {
                    MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al agregar el producto: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Limpiar();
            LlenarProductos();


        }

        private byte[] ConvertirImg()
        {
            ImageConverter img = new ImageConverter();
            byte[] bytes = (byte[])img.ConvertTo(new Bitmap(pictureProducto.Image), typeof(byte[]));
            return bytes;
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

        private void frmInventario_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            LlenarProductos();
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtUnidad.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            cboCategoria.SelectedIndex = 0;
            pictureProducto.Image = Properties.Resources.iconoImagen;
            idProductoEditar = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
