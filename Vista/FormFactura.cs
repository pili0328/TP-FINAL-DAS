using Controladora;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Vista.FormVentas;


namespace Vista
{
    public partial class FormFactura : Form
    {
        private Context context;
        private ControladoraVentas controladoraVenta;
        private ControladoraCliente controladoraCliente;

        public FormFactura()
        {
            InitializeComponent();
            context = new Context();
            controladoraCliente = new ControladoraCliente();
            controladoraVenta = new ControladoraVentas();
        }

        public void CargarClientes()
        {
            cbCliente.DataSource = context.Cliente.ToList();
            cbCliente.DisplayMember = "Nombre";
            cbCliente.ValueMember = "Id";
            cbCliente.SelectedIndex = -1;
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            if (cbCliente.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            int idCliente = (int)cbCliente.SelectedValue;

            var venta = context.Ventas
                .Include(v => v.Detalles)
                .ThenInclude(d => d.Producto)
                .Where(v => v.ClienteId == idCliente)
                .OrderByDescending(v => v.Fecha)
                .FirstOrDefault();

            if (venta == null)
            {
                MessageBox.Show("El cliente no tiene ventas registradas.");
                return;
            }

            var detalle = venta.Detalles.FirstOrDefault();
            if (detalle == null)
            {
                MessageBox.Show("La venta no tiene productos cargados.");
                return;
            }

            lblCargaProd.Text = detalle.Producto.Nombre;
            lblCargaCant.Text = detalle.Cantidad.ToString();
            lblCargaPr.Text = detalle.PrecioUnitario.ToString("0.00");
            lblCargaTDP.Text = venta.MetodoPago;

            decimal subtotal = venta.Detalles.Sum(d => d.Cantidad * d.PrecioUnitario);
            var clienteObj = context.Cliente.Find(venta.ClienteId);

            // CALCULO DEL DESCUENTO (solo si es mayorista)
            decimal descuento = 0;

            if (clienteObj.Tipo == Cliente.TipoCliente.Mayorista)
            {
                descuento = subtotal * 0.10m;  // 10% solo mayorista
            }

            lblCargaDesc.Text = descuento.ToString("0.00");

            // Total con descuento aplicado
            decimal total = subtotal - descuento;

            // Si el método de pago es Cuenta Corriente,aplica el recargo
            if (venta.MetodoPago == "CuentaCorriente")
            {
                total += total * 0.10m; // recargo del 10%
            }

            // Muestra el orecio final, con el descuento o con el recargo de cuenta corriente
            lblCargaPr.Text = total.ToString(); 


        }

    }
}
