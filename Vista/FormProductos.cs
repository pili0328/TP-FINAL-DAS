using Controladora;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Entidades.Cliente;

namespace Vista
{
    public partial class FormProductos : Form
    {
        private ControladoraProducto controlProductos;
        private int? idProductoSeleccionado = null;

        public FormProductos()
        {
            controlProductos = new ControladoraProducto();
            InitializeComponent();
        }

        private void CargarCombos()
        {
            List<Sucursal> sucursales = new List<Sucursal>();
            cbSucursal.DataSource = sucursales;

            List<Categoria> categorias = new List<Categoria>();
            cbCategoria.DataSource = categorias;
        }

        private void CargarGrilla()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = controlProductos.ListarProductos();
        }

        private void LimpiarFormulario()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            cbCategoria.SelectedItem = null;

            cbSucursal.SelectedItem = null;
            txtStockSucursal.Text = "";

            idProductoSeleccionado = null; // Reseteamos selección
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarGrilla();
            LimpiarFormulario();
        }




        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Por favor complete Nombre y codigo.");
                return;
            }

            try
            {
                Producto producto = new Producto();
                producto.Codigo = txtCodigo.Text;
                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.Precio = decimal.Parse(txtPrecio.Text);
                producto.Categoria = (Categoria)cbCategoria.SelectedItem;

                producto.Sucursal = (Sucursal)cbSucursal.SelectedItem;
                producto.StockSucursales.Add(new StockSucursal
                {
                    SucursalId = int.Parse(cbSucursal.SelectedValue.ToString()),
                    Cantidad = int.Parse(txtStockSucursal.Text),
                    ProductoId = producto.Id
                });

                controlProductos.CrearProducto(producto);

                MessageBox.Show("Producto guardado con éxito.");

                CargarGrilla();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR REAL: " + ex.InnerException?.Message);
                // MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un producto para modificar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Nombre y código son obligatorios.");
                return;
            }

            try
            {
                // 1) Traer el producto real desde la base
                var productoEditado = controlProductos.ObtenerPorId((int)idProductoSeleccionado);

                if (productoEditado == null)
                {
                    MessageBox.Show("No se encontró el producto en la base.");
                    return;
                }

                // 2) Actualizar datos básicos
                productoEditado.Codigo = txtCodigo.Text;
                productoEditado.Nombre = txtNombre.Text;
                productoEditado.Precio = decimal.Parse(txtPrecio.Text);
                productoEditado.Categoria = (Categoria)cbCategoria.SelectedItem;

                // 3) Modificar / agregar stock
                int sucursalId = int.Parse(cbSucursal.SelectedValue.ToString());
                int cantidad = int.Parse(txtStockSucursal.Text);

                var stockExistente = productoEditado.StockSucursales
                    .FirstOrDefault(s => s.SucursalId == sucursalId);

                if (stockExistente != null)
                {
                    // modificar
                    stockExistente.Cantidad = cantidad;
                }
                else
                {
                    // agregar nuevo registro de stock
                    productoEditado.StockSucursales.Add(new StockSucursal
                    {
                        SucursalId = sucursalId,
                        Cantidad = cantidad,
                        ProductoId = productoEditado.Id
                    });
                }

                // 4) Guardar cambios
                controlProductos.ActualizarProducto(productoEditado);

                MessageBox.Show("Producto modificado correctamente.");

                CargarGrilla();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
                return;
            }

            try
            {
                // Traer el producto real para eliminarle los stocks
                var producto = controlProductos.ObtenerPorId((int)idProductoSeleccionado);

                if (producto != null)
                {
                    producto.StockSucursales.Clear(); // quitar stocks antes de eliminar
                    controlProductos.ActualizarProducto(producto);
                }

                controlProductos.EliminarProducto((int)idProductoSeleccionado);

                MessageBox.Show("Producto eliminado.");

                CargarGrilla();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && ex.InnerException.Message.Contains("REFERENCE"))
                {
                    MessageBox.Show("No se puede eliminar este producto.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }

        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
                return;

            var productoRow = (Producto)dgvProductos.CurrentRow.DataBoundItem;
            if (productoRow == null)
                return;

            // 👉 Traer el producto real con Includes
            var productoSeleccionado = controlProductos.ObtenerPorId(productoRow.Id);

            if (productoSeleccionado == null)
                return;

            // --- Datos básicos ---
            txtCodigo.Text = productoSeleccionado.Codigo;
            txtNombre.Text = productoSeleccionado.Nombre;
            txtPrecio.Text = productoSeleccionado.Precio.ToString();
            cbCategoria.SelectedItem = productoSeleccionado.Categoria;

            idProductoSeleccionado = productoSeleccionado.Id;

            // --- STOCK --- (si tenés seleccionada una sucursal en el ComboBox)
            if (cbSucursal.SelectedValue != null)
            {
                int sucursalId = int.Parse(cbSucursal.SelectedValue.ToString());

                var stock = productoSeleccionado.StockSucursales
                    .FirstOrDefault(s => s.SucursalId == sucursalId);

                txtStockSucursal.Text = stock?.Cantidad.ToString() ?? "0";
            }
        }

      
    }
}