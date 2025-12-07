
namespace Vista
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormClientes frmCliente = new FormClientes();
            frmCliente.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos frmProd = new FormProductos();
            frmProd.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVentas frmVenta = new FormVentas();
            frmVenta.ShowDialog();
        }

        private void btnReportesConsultas_Click(object sender, EventArgs e)
        {
            FormReportes frmReportes = new FormReportes();
            frmReportes.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnGestionStock_Click(object sender, EventArgs e)
        {
            FormSucursal frmSucursal = new FormSucursal();
            frmSucursal.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
