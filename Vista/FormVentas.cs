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
using static Entidades.Cliente;

namespace Vista
{
    public partial class FormVentas : Form
    {
        private ControladoraVentas controladoraVenta;
        private ControladoraCliente controladoraCliente;
        private ControladoraProducto controladoraProducto;
        private Context context;
        List<ItemCarrito> carritoGlobal;
        Venta ultimaVentaRegistrada = null; //esto es para la factura

        private Cliente cliente;

        public FormVentas()
        {
            InitializeComponent();
            controladoraCliente = new ControladoraCliente();
            controladoraVenta = new ControladoraVentas();
            controladoraProducto = new ControladoraProducto();
            context = new Context();
            carritoGlobal = new List<ItemCarrito>();
            ultimaVentaRegistrada = new Venta();

            cliente = new Cliente();
        }

        private void CargarComboVendedores()
        {
            cmbVendedores.DataSource = null;
            cmbVendedores.DataSource = context.Vendedor.ToList();
            cmbVendedores.DisplayMember = "Nombre";
            cmbVendedores.ValueMember = "Id";
            cmbVendedores.SelectedIndex = -1;
        }
        private void CargarCombos()
        {
            cmbSucursal.DataSource = context.Sucursales.ToList();
            cmbSucursal.DisplayMember = "Nombre"; cmbSucursal.ValueMember = "Id";
            cmbSucursal.SelectedIndex = -1;

            cmbClientes.DataSource = controladoraCliente.ListarClientes();
            cmbClientes.DisplayMember = "Nombre"; cmbClientes.ValueMember = "Id";
            cmbClientes.SelectedIndex = -1;

            CargarComboVendedores();
        }

        private void ActualizarGrilla()
        {
            if (cmbClientes.SelectedValue == null) return;

            int idCliente = (int)cmbClientes.SelectedValue;

            var listaFiltrada = carritoGlobal
                .Where(x => x.ClienteId == idCliente)
                .ToList();

            dgvVentas.DataSource = listaFiltrada
                .Select(x => new
                {
                    x.Producto,
                    x.Cantidad,
                    x.Precio,
                    x.MetodoPago,
                    Total = x.Precio * x.Cantidad
                })
                .ToList();

            if (dgvVentas.Columns["ClienteId"] != null)
                dgvVentas.Columns["ClienteId"].Visible = false;

            if (dgvVentas.Columns["ProductoId"] != null)
                dgvVentas.Columns["ProductoId"].Visible = false;
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            CargarCombos();
            dtpVenta.Value = DateTime.Now;
        }

        private void cmbClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedValue == null) return;

            int idCliente = (int)cmbClientes.SelectedValue;

            var cliente = context.Cliente.Find(idCliente);

            if (cliente != null)
            {
                if (cliente.Tipo == Cliente.TipoCliente.Mayorista)
                {
                    lblTipoCliente.Text = "Mayorista (10% OFF)";
                    lblTipoCliente.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblTipoCliente.Text = "Minorista";
                    lblTipoCliente.ForeColor = System.Drawing.Color.Gray;
                }
            }

            ActualizarGrilla();
        }

        public void LimpiarTodo()
        {
            cmbClientes.SelectedIndex = -1;
            cmbSucursal.SelectedIndex = -1;
            cmbProductos.DataSource = null;
            cmbVendedores.SelectedIndex = -1;
            txtCantidad.Text = "";
        }
        private void btnCarrito_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedValue == null) { MessageBox.Show("Seleccione Cliente"); return; }
            if (cmbSucursal.SelectedValue == null) { MessageBox.Show("Seleccione sucursal"); return; }
            if (cmbProductos.SelectedValue == null) { MessageBox.Show("Seleccione Producto"); return; }

            // --- NUEVA LÓGICA MIXTA PARA EL VENDEDOR ---
            string nombreVendedorFinal = "";

            if (cmbVendedores.SelectedItem != null)
            {
                Vendedor v = (Vendedor)cmbVendedores.SelectedItem;
                nombreVendedorFinal = v.Nombre + " " + v.Apellido;
            }
            else if (!string.IsNullOrWhiteSpace(txtNombreVendedor.Text) && !string.IsNullOrWhiteSpace(txtApellidoVendedor.Text))
            {
                nombreVendedorFinal = txtNombreVendedor.Text + " " + txtApellidoVendedor.Text;
            }
            else
            {
                MessageBox.Show("Seleccione un Vendedor de la lista O ingrese uno nuevo.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida."); return;

            }

            dynamic prodSeleccionado = cmbProductos.SelectedItem;
            dynamic cliSeleccionado = cmbClientes.SelectedItem;
            dynamic sucSeleccionada = cmbSucursal.SelectedItem;

            int stockReal = prodSeleccionado.Stock;
            decimal precioReal = (decimal)prodSeleccionado.Precio;

            if (cantidad > stockReal)
            {
                MessageBox.Show($"Stock insuficiente. Quedan {stockReal}."); return;
                LimpiarTodo();

            }

            string pago = "Efectivo";
            if (rdbTarjeta.Checked) pago = "Tarjeta";
            if (rdbTransferencia.Checked) pago = "Transferencia";
            if (rdbCuentaCorriente.Checked) pago = "Cuenta Corriente";

            ItemCarrito item = new ItemCarrito(
                (int)cmbClientes.SelectedValue,
                cliSeleccionado.Nombre,
                prodSeleccionado,
                nombreVendedorFinal,
                sucSeleccionada.Nombre,
                cantidad,
                pago
            );

            carritoGlobal.Add(item);
            ActualizarGrilla();


            txtCantidad.Text = "";

        }

        private void cmbSucursal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbSucursal.SelectedValue == null) return;
            int idSucursal = (int)cmbSucursal.SelectedValue;

            cmbProductos.DataSource = controladoraProducto.ListarPorSucursal(idSucursal);
            cmbProductos.DisplayMember = "Producto";
            cmbProductos.ValueMember = "IdProducto";
            cmbProductos.SelectedIndex = -1;

        }

        private void btnRegistrarVendedor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreVendedor.Text) || string.IsNullOrWhiteSpace(txtApellidoVendedor.Text))
            {
                MessageBox.Show("Complete Nombre y Apellido."); return;
            }

            try
            {
                Vendedor nuevo = new Vendedor();
                nuevo.Nombre = txtNombreVendedor.Text;
                nuevo.Apellido = txtApellidoVendedor.Text;

                context.Vendedor.Add(nuevo);
                context.SaveChanges();

                MessageBox.Show("Vendedor creado.");

                CargarComboVendedores();
                cmbVendedores.SelectedValue = nuevo.Id;

                txtNombreVendedor.Text = "";
                txtApellidoVendedor.Text = "";
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e) //ACA SE CREA LA VENTA
        {
            if (cmbClientes.SelectedValue == null) return;
            int idCliente = (int)cmbClientes.SelectedValue;

            var itemsCliente = carritoGlobal.Where(x => x.ClienteId == idCliente).ToList();
            if (itemsCliente.Count == 0) { MessageBox.Show("Carrito vacío."); return; }

            if (cmbVendedores.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un Vendedor del desplegable (o cree uno nuevo).");
                return;
            }

            try
            {
                List<DetalleVenta> detallesBD = new List<DetalleVenta>();
                foreach (var item in itemsCliente)
                {
                    detallesBD.Add(new DetalleVenta
                    {
                        ProductoId = item.ProductoId,
                        Cantidad = item.Cantidad,
                        PrecioUnitario = item.Precio
                    });
                }

                Venta venta = new Venta();
                venta.Fecha = dtpVenta.Value;
                venta.ClienteId = idCliente;
                venta.SucursalId = (int)cmbSucursal.SelectedValue;

                venta.VendedorId = (int)cmbVendedores.SelectedValue;

                venta.Detalles = detallesBD;

                if (rdbTarjeta.Checked) 
                    venta.MetodoPago = "Tarjeta";
                else if (rdbTransferencia.Checked) 
                    venta.MetodoPago = "Transferencia";
                else if (rdbCuentaCorriente.Checked) 
                    venta.MetodoPago = "Cuenta Corriente";
                else 
                    venta.MetodoPago = "Efectivo";

                // calculamos descuento
                decimal subtotal = detallesBD.Sum(d => d.Cantidad * d.PrecioUnitario);
                var clienteObj = context.Cliente.Find(idCliente);
                decimal descuento = 0;



                // Si es mayorista, aplica 10%
                if (clienteObj.Tipo == Cliente.TipoCliente.Mayorista)
                {
                    descuento = subtotal * 0.10m;
                }

                // Guardar solo TOTAL final
                venta.Total = subtotal - descuento;
                controladoraVenta.ProcesarVenta(venta);
                ultimaVentaRegistrada = venta;

                MessageBox.Show("Venta Finalizada.");

                //limpia
                carritoGlobal.RemoveAll(x => x.ClienteId == idCliente);
                ActualizarGrilla();

            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                    MessageBox.Show("Error SQL: " + ex.InnerException.Message);
                else
                    MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            if (ultimaVentaRegistrada == null)
            {
                MessageBox.Show("No hay ventas registradas.");
                return;
            }
            else
            {
                FormFactura factura = new FormFactura();
                factura.ShowDialog();
            }
        }
    }
}   



