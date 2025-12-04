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
using static Entidades.Cliente;
using Controladora;

namespace Vista
{
    public partial class FormClientes : Form
    {
        private ControladoraCliente controlClientes;
        private int? idClienteSeleccionado = null;
        public FormClientes()
        {
            controlClientes = new ControladoraCliente();
            InitializeComponent();
        }

        private void CargarComboTipo()
        {
            cbTipoCliente.DataSource = Enum.GetValues(typeof(TipoCliente));
        }

        private void CargarGrilla()
        {
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = controlClientes.ListarClientes();

            if (dgvCliente.Columns["Compras"] != null) //esto no entiendo
            {
                dgvCliente.Columns["Compras"].Visible = false;
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            cbTipoCliente.SelectedIndex = 0;
            idClienteSeleccionado = null; // Reseteamos selección
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Por favor complete Nombre y DNI.");
                return;
            }

            try
            {
                // 2. Crear el objeto
                Cliente cliente = new Cliente();
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Dni = txtDNI.Text;

                // Casteamos (convertimos) lo seleccionado en el combo al Enum
                cliente.Tipo = (TipoCliente)cbTipoCliente.SelectedItem;

                // 3. Guardar
                // Si tuviéramos lógica de editar, chequearíamos _idClienteSeleccionado aquí

                controlClientes.AgregarCliente(cliente);

                MessageBox.Show("Cliente guardado con éxito.");

                // 4. Refrescar pantalla
                CargarGrilla();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista para modificar.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Nombre y DNI son obligatorios.");
                return;
            }

            try
            {
                Cliente clienteEditado = new Cliente();

                clienteEditado.Id = (int)idClienteSeleccionado;

                clienteEditado.Nombre = txtNombre.Text;
                clienteEditado.Apellido = txtApellido.Text;
                clienteEditado.Dni = txtDNI.Text;
                clienteEditado.Tipo = (TipoCliente)cbTipoCliente.SelectedItem;

                controlClientes.ActualizarCliente(clienteEditado);

                MessageBox.Show("Cliente modificado correctamente.");

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
            if (idClienteSeleccionado == null)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
                return;
            }


            try
            {
                controlClientes.EliminarCliente((int)idClienteSeleccionado);

                MessageBox.Show("Cliente eliminado.");

                CargarGrilla();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {

                if (ex.InnerException != null && ex.InnerException.Message.Contains("REFERENCE"))
                {
                    MessageBox.Show("No se puede eliminar este cliente porque ya tiene compras registradas.");
                }
                else
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            CargarComboTipo();
            CargarGrilla();
            LimpiarFormulario();
        }

        private void dgvCliente_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvCliente.CurrentRow == null)
            {
                return;
            }

            var clienteSeleccionado = (Cliente)dgvCliente.CurrentRow.DataBoundItem;

            if (clienteSeleccionado == null) return;

            txtNombre.Text = clienteSeleccionado.Nombre;
            txtApellido.Text = clienteSeleccionado.Apellido;
            txtDNI.Text = clienteSeleccionado.Dni;
            cbTipoCliente.SelectedItem = clienteSeleccionado.Tipo;


            idClienteSeleccionado = clienteSeleccionado.Id;
        }

        private void lblDNI_Click(object sender, EventArgs e)
        {

        }
    }
}
