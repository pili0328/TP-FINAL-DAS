using Controladora;
using Entidades;
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

namespace Vista
{
    public partial class FormReportes : Form
    {
        private Context context;
        private ControladoraVentas controladoraVenta;
        private ControladoraProducto controladoraProducto;
        private ControladoraCliente controladoraCliente;

        public FormReportes()
        {
            InitializeComponent();
            context = new Context();
            controladoraVenta = new ControladoraVentas();
            controladoraProducto = new ControladoraProducto();
            controladoraCliente = new ControladoraCliente();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            cbTipoReporte.Items.Add("Por período");
            cbTipoReporte.Items.Add("Por producto");
            cbTipoReporte.Items.Add("Por sucursal");
            cbTipoReporte.Items.Add("Por vendedor");
            cbTipoReporte.SelectedIndex = -1;

            dtpDesde.Enabled = false;
            dtpHasta.Enabled = false;
        }

        private void cbTipoReporte_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbTipoReporte.SelectedItem == null) return;

            string opcion = cbTipoReporte.SelectedItem.ToString();

            if (opcion == "Por período")
            {
                dtpDesde.Enabled = true;
                dtpHasta.Enabled = true;
            }
            else
            {
                dtpDesde.Enabled = false;
                dtpHasta.Enabled = false;
            }
        }

        private void btnCargarReporte_Click(object sender, EventArgs e)
        {
            if (cbTipoReporte.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de reporte.");
                return;
            }

            string tipo = cbTipoReporte.SelectedItem.ToString();

            switch (tipo)
            {
                case "Por período":
                    CargarReportePorPeriodo();
                    break;

                case "Por producto":
                    CargarReportePorProducto();
                    break;

                case "Por sucursal":
                    CargarReportePorSucursal();
                    break;

                case "Por vendedor":
                    CargarReportePorVendedor();
                    break;
            }
        }

        private void CargarReportePorPeriodo()
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;

            var ventas = context.Ventas
                .Where(v => v.Fecha >= desde && v.Fecha <= hasta)
                .Select(v => new
                {
                    v.Id,
                    v.Fecha,
                    Cliente = v.Cliente.Nombre,
                    Sucursal = v.Sucursal.Nombre,
                    Vendedor = v.Vendedor.Nombre,
                    v.MetodoPago,
                    v.Total
                })
                .ToList();

            dgvCargarReportePorTipo.DataSource = ventas;
        }

        private void CargarReportePorProducto()
        {
            var ventas = context.Detalle
                .Select(d => new
                {
                    Producto = d.Producto.Nombre,
                    d.Cantidad,
                    d.PrecioUnitario,
                    Total = d.Cantidad * d.PrecioUnitario
                })
                .ToList();

            dgvCargarReportePorTipo.DataSource = ventas;
        }

        private void CargarReportePorSucursal()
        {
            var ventas = context.Ventas
                .Select(v => new
                {
                    Sucursal = v.Sucursal.Nombre,
                    v.Fecha,
                    Cliente = v.Cliente.Nombre,
                    Total = v.Total
                })
                .ToList();

            dgvCargarReportePorTipo.DataSource = ventas;
        }

        private void CargarReportePorVendedor()
        {
            var ventas = context.Ventas
                .Select(v => new
                {
                    Vendedor = v.Vendedor.Nombre,
                    v.Fecha,
                    Cliente = v.Cliente.Nombre,
                    Total = v.Total
                })
                .ToList();

            dgvCargarReportePorTipo.DataSource = ventas;
        }

        private void btnProductoVendido_Click(object sender, EventArgs e)
        {
            var prod = context.Detalle
            .GroupBy(d => d.Producto.Nombre)
            .Select(g => new
            {
                Producto = g.Key,
                Cantidad = g.Sum(x => x.Cantidad)
            })
            .OrderByDescending(x => x.Cantidad)
            .FirstOrDefault();

            if (prod == null)
            {
                MessageBox.Show("No hay ventas registradas.");
                return;
            }

            MessageBox.Show($"Producto más vendido: {prod.Producto}\nCantidad: {prod.Cantidad}");
        }

        private void btnEstadoCC_Click(object sender, EventArgs e)
        {
            var deuda = context.Ventas
           .Where(v => v.MetodoPago == "Cuenta Corriente")
           .GroupBy(v => v.Cliente.Nombre)
           .Select(g => new
           {
               Cliente = g.Key,
               TotalDeuda = g.Sum(x => x.Total)
           })
           .ToList();

            if (deuda.Count == 0)
            {
                MessageBox.Show("No hay deudas registradas.");
                return;
            }

            string mensaje = "ESTADO DE CUENTA CORRIENTE:\n\n";

            foreach (var d in deuda)
            {
                mensaje += $"{d.Cliente}: ${d.TotalDeuda}\n";
            }

            MessageBox.Show(mensaje);
        }
    }
}
