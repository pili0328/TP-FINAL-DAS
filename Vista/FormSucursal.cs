using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;
using Entidades;
using Modelo;

namespace Vista
{
    public partial class FormSucursal : Form
    {
        private ControladoraProducto controladora;
        private Context context;
        public FormSucursal()
        {
            InitializeComponent();
            controladora = new ControladoraProducto();
            context = new Context();
        }

        private void lblStock_Click(object sender, EventArgs e)
        {

        }

        private void FormSucursal_Load(object sender, EventArgs e)
        {
            CargarComboSucursales();
            CargarComboProductos();
        }

        private void CargarComboSucursales()
        {
            cmbSucursal.DataSource = null;
            cmbSucursal.DataSource = context.Sucursales.ToList();
            cmbSucursal.DisplayMember = "Nombre";
            cmbSucursal.ValueMember = "Id";
            cmbSucursal.SelectedIndex = -1;
        }

        private void CargarComboProductos()
        {
            cmbProducto.DataSource = null;
            cmbProducto.DataSource = context.Productos.ToList();
            cmbProducto.DisplayMember = "Nombre";
            cmbProducto.ValueMember = "Id";
        }

        private void ActualizarGrilla()
        {
            if (cmbSucursal.SelectedValue != null)
            {
                int idSucursal = (int)cmbSucursal.SelectedValue;

                dgvStock.DataSource = null;
                dgvStock.DataSource = controladora.ListarPorSucursal(idSucursal);
            }
        }
        private void btnSucursal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSucursal.Text)) return;

            try
            {
                Sucursal s = new Sucursal { Nombre = txtSucursal.Text, Direccion = "N/A" };
                context.Sucursales.Add(s);
                context.SaveChanges();

                CargarComboSucursales();
                cmbSucursal.SelectedValue = s.Id;

                txtSucursal.Text = "";
                MessageBox.Show("Sucursal creada.");

                ActualizarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cmbSucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbSucursal.SelectedValue == null || cmbProducto.SelectedValue == null)
            {
                MessageBox.Show("Seleccione Sucursal y Producto."); return;
            }

            if (!int.TryParse(txtStockCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida."); return;
            }

            try
            {
                int idProd = (int)cmbProducto.SelectedValue;
                int idSuc = (int)cmbSucursal.SelectedValue;

                controladora.AsignarStockControlado(idProd, idSuc, cantidad);

                MessageBox.Show("Stock asignado correctamente.");

                txtStockCantidad.Text = "";
                ActualizarGrilla(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DE STOCK: " + ex.Message);
            }
        }
    }
}
