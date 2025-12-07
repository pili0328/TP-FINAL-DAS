using Controladora;
using Modelo;
using static Entidades.Producto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FormProductos : Form
    {
        private ControladoraProducto controladora;
        private int? idProductoSeleccionado = null;
        private Context context;

        public FormProductos()
        {
            InitializeComponent();
            controladora = new ControladoraProducto();
            context = new Context();
        }

        private void CargarComboCategorias()
        {
            cmbCategoria.DataSource = null;
            cmbCategoria.DataSource = context.Categorias.ToList();
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "Id";
        }

        private void CargarGrilla()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = controladora.ListarProductos();
            if (dgvProductos.Columns["CategoriaId"] != null)
            {
                dgvProductos.Columns["CategoriaId"].Visible = false;
            }

        }



        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            CargarComboCategorias();
            CargarGrilla();
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtCategoria.Text = "";

            if (cmbCategoria.Items.Count > 0) cmbCategoria.SelectedIndex = 0;

            idProductoSeleccionado = null;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoria.Text)) return;

            try
            {
                Categoria nuevaCat = new Categoria { Nombre = txtCategoria.Text };

                context.Categorias.Add(nuevaCat);
                context.SaveChanges();

                CargarComboCategorias();
                cmbCategoria.SelectedValue = nuevaCat.Id;

                txtCategoria.Text = "";
                MessageBox.Show("Categoría añadida.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir categoría: " + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Complete los campos obligatorios.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Precio inválido."); return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Cantidad inválida."); return;
            }

            try
            {
                Producto prod = new Producto();
                prod.Codigo = txtCodigo.Text;
                prod.Nombre = txtNombre.Text;
                prod.Descripcion = txtDescripcion.Text;
                prod.Precio = precio;
                prod.Cantidad = cantidad;

                prod.CategoriaId = (int)cmbCategoria.SelectedValue;
  


                controladora.CrearProducto(prod);

                MessageBox.Show("Producto agregado.");
                CargarGrilla();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un producto de la grilla.");
                return;
            }

            try
            {
                Producto prod = new Producto();
                prod.Id = (int)idProductoSeleccionado;
                prod.Codigo = txtCodigo.Text;
                prod.Nombre = txtNombre.Text;
                prod.Descripcion = txtDescripcion.Text;
                prod.Precio = decimal.Parse(txtPrecio.Text);
                prod.CategoriaId = (int)cmbCategoria.SelectedValue;
                prod.Cantidad = int.Parse(txtCantidad.Text);

                controladora.ActualizarProducto(prod);

                MessageBox.Show("Producto modificado.");
                CargarGrilla();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            var respuesta = MessageBox.Show("¿Seguro de eliminar?", "Confirmar", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    controladora.EliminarProducto((int)idProductoSeleccionado);

                    MessageBox.Show("Eliminado.");
                    CargarGrilla();
                    LimpiarFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null) return;

            var prod = (Producto)dgvProductos.CurrentRow.DataBoundItem;

            if (prod == null) return;

            txtCodigo.Text = prod.Codigo;
            txtNombre.Text = prod.Nombre;
            txtDescripcion.Text = prod.Descripcion;
            txtPrecio.Text = prod.Precio.ToString();
            txtCantidad.Text = prod.Cantidad.ToString(); 

            cmbCategoria.SelectedValue = prod.CategoriaId;

            idProductoSeleccionado = prod.Id;
        }
    }
}

