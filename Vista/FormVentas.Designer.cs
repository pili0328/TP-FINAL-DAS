namespace Vista
{
    partial class FormVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSucursales = new Label();
            lblNombreVendedor = new Label();
            lblApellidoVendedor = new Label();
            txtApellidoVendedor = new TextBox();
            txtNombreVendedor = new TextBox();
            grbVentas = new GroupBox();
            cmbVendedores = new ComboBox();
            lblVendores = new Label();
            lblData = new Label();
            dtpVenta = new DateTimePicker();
            btnRegistrarVendedor = new Button();
            lblSucursal = new Label();
            cmbSucursal = new ComboBox();
            lblCliente = new Label();
            cmbClientes = new ComboBox();
            lblProducto = new Label();
            cmbProductos = new ComboBox();
            grbMetododePago = new GroupBox();
            rdbCuentaCorriente = new RadioButton();
            rdbTransferencia = new RadioButton();
            rdbTarjeta = new RadioButton();
            rdbEfectivo = new RadioButton();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            grbCompra = new GroupBox();
            lblClienteSeleccionado = new Label();
            btnCarrito = new Button();
            dgvVentas = new DataGridView();
            btnFactura = new Button();
            lblTipo = new Label();
            lblTipoCliente = new Label();
            btnFinalizarVenta = new Button();
            grbVentas.SuspendLayout();
            grbMetododePago.SuspendLayout();
            grbCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // lblSucursales
            // 
            lblSucursales.AutoSize = true;
            lblSucursales.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucursales.ForeColor = Color.DeepPink;
            lblSucursales.Location = new Point(370, 26);
            lblSucursales.Name = "lblSucursales";
            lblSucursales.Size = new Size(372, 48);
            lblSucursales.TabIndex = 21;
            lblSucursales.Text = "GESTION DE VENTAS";
            // 
            // lblNombreVendedor
            // 
            lblNombreVendedor.AutoSize = true;
            lblNombreVendedor.Location = new Point(33, 43);
            lblNombreVendedor.Name = "lblNombreVendedor";
            lblNombreVendedor.Size = new Size(81, 25);
            lblNombreVendedor.TabIndex = 22;
            lblNombreVendedor.Text = "Nombre";
            // 
            // lblApellidoVendedor
            // 
            lblApellidoVendedor.AutoSize = true;
            lblApellidoVendedor.Location = new Point(33, 87);
            lblApellidoVendedor.Name = "lblApellidoVendedor";
            lblApellidoVendedor.Size = new Size(82, 25);
            lblApellidoVendedor.TabIndex = 23;
            lblApellidoVendedor.Text = "Apellido";
            // 
            // txtApellidoVendedor
            // 
            txtApellidoVendedor.Location = new Point(147, 87);
            txtApellidoVendedor.Name = "txtApellidoVendedor";
            txtApellidoVendedor.Size = new Size(158, 31);
            txtApellidoVendedor.TabIndex = 24;
            // 
            // txtNombreVendedor
            // 
            txtNombreVendedor.Location = new Point(147, 40);
            txtNombreVendedor.Name = "txtNombreVendedor";
            txtNombreVendedor.Size = new Size(158, 31);
            txtNombreVendedor.TabIndex = 25;
            // 
            // grbVentas
            // 
            grbVentas.BackColor = Color.Pink;
            grbVentas.Controls.Add(cmbVendedores);
            grbVentas.Controls.Add(lblVendores);
            grbVentas.Controls.Add(lblData);
            grbVentas.Controls.Add(dtpVenta);
            grbVentas.Controls.Add(btnRegistrarVendedor);
            grbVentas.Controls.Add(txtNombreVendedor);
            grbVentas.Controls.Add(lblApellidoVendedor);
            grbVentas.Controls.Add(txtApellidoVendedor);
            grbVentas.Controls.Add(lblNombreVendedor);
            grbVentas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbVentas.Location = new Point(49, 74);
            grbVentas.Name = "grbVentas";
            grbVentas.Size = new Size(697, 220);
            grbVentas.TabIndex = 26;
            grbVentas.TabStop = false;
            grbVentas.Text = "Ingreso de datos del vendedor";
            // 
            // cmbVendedores
            // 
            cmbVendedores.FormattingEnabled = true;
            cmbVendedores.Location = new Point(514, 159);
            cmbVendedores.Name = "cmbVendedores";
            cmbVendedores.Size = new Size(158, 33);
            cmbVendedores.TabIndex = 35;
            // 
            // lblVendores
            // 
            lblVendores.AutoSize = true;
            lblVendores.Font = new Font("Segoe UI Semibold", 9.216F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVendores.Location = new Point(305, 159);
            lblVendores.Name = "lblVendores";
            lblVendores.Size = new Size(217, 25);
            lblVendores.TabIndex = 32;
            lblVendores.Text = "Vendedores registrados:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(335, 40);
            lblData.Name = "lblData";
            lblData.Size = new Size(192, 25);
            lblData.TabIndex = 31;
            lblData.Text = "Venta realizada el dia:";
            // 
            // dtpVenta
            // 
            dtpVenta.Location = new Point(344, 87);
            dtpVenta.Name = "dtpVenta";
            dtpVenta.Size = new Size(279, 31);
            dtpVenta.TabIndex = 30;
            // 
            // btnRegistrarVendedor
            // 
            btnRegistrarVendedor.Location = new Point(81, 151);
            btnRegistrarVendedor.Name = "btnRegistrarVendedor";
            btnRegistrarVendedor.Size = new Size(157, 37);
            btnRegistrarVendedor.TabIndex = 30;
            btnRegistrarVendedor.Text = "Registrar vendedor";
            btnRegistrarVendedor.UseVisualStyleBackColor = true;
            btnRegistrarVendedor.Click += btnRegistrarVendedor_Click;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Location = new Point(33, 46);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(81, 25);
            lblSucursal.TabIndex = 26;
            lblSucursal.Text = "Sucursal";
            // 
            // cmbSucursal
            // 
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(147, 46);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(158, 33);
            cmbSucursal.TabIndex = 27;
            cmbSucursal.SelectionChangeCommitted += cmbSucursal_SelectionChangeCommitted;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(33, 112);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(0, 25);
            lblCliente.TabIndex = 28;
            // 
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(147, 109);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(158, 33);
            cmbClientes.TabIndex = 29;
            cmbClientes.SelectionChangeCommitted += cmbClientes_SelectionChangeCommitted;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(378, 49);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(89, 25);
            lblProducto.TabIndex = 30;
            lblProducto.Text = "Producto";
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(514, 46);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(158, 33);
            cmbProductos.TabIndex = 31;
            // 
            // grbMetododePago
            // 
            grbMetododePago.BackColor = Color.Pink;
            grbMetododePago.Controls.Add(rdbCuentaCorriente);
            grbMetododePago.Controls.Add(rdbTransferencia);
            grbMetododePago.Controls.Add(rdbTarjeta);
            grbMetododePago.Controls.Add(rdbEfectivo);
            grbMetododePago.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbMetododePago.Location = new Point(49, 490);
            grbMetododePago.Name = "grbMetododePago";
            grbMetododePago.Size = new Size(697, 237);
            grbMetododePago.TabIndex = 26;
            grbMetododePago.TabStop = false;
            grbMetododePago.Text = "Metodos de pago";
            // 
            // rdbCuentaCorriente
            // 
            rdbCuentaCorriente.AutoSize = true;
            rdbCuentaCorriente.Location = new Point(16, 187);
            rdbCuentaCorriente.Name = "rdbCuentaCorriente";
            rdbCuentaCorriente.Size = new Size(177, 29);
            rdbCuentaCorriente.TabIndex = 3;
            rdbCuentaCorriente.TabStop = true;
            rdbCuentaCorriente.Text = "Cuenta corriente";
            rdbCuentaCorriente.UseVisualStyleBackColor = true;
            // 
            // rdbTransferencia
            // 
            rdbTransferencia.AutoSize = true;
            rdbTransferencia.Location = new Point(16, 142);
            rdbTransferencia.Name = "rdbTransferencia";
            rdbTransferencia.Size = new Size(147, 29);
            rdbTransferencia.TabIndex = 2;
            rdbTransferencia.TabStop = true;
            rdbTransferencia.Text = "Transferencia";
            rdbTransferencia.UseVisualStyleBackColor = true;
            // 
            // rdbTarjeta
            // 
            rdbTarjeta.AutoSize = true;
            rdbTarjeta.Location = new Point(16, 92);
            rdbTarjeta.Name = "rdbTarjeta";
            rdbTarjeta.Size = new Size(92, 29);
            rdbTarjeta.TabIndex = 1;
            rdbTarjeta.TabStop = true;
            rdbTarjeta.Text = "Tarjeta";
            rdbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rdbEfectivo
            // 
            rdbEfectivo.AutoSize = true;
            rdbEfectivo.Location = new Point(16, 43);
            rdbEfectivo.Name = "rdbEfectivo";
            rdbEfectivo.Size = new Size(102, 29);
            rdbEfectivo.TabIndex = 0;
            rdbEfectivo.TabStop = true;
            rdbEfectivo.Text = "Efectivo";
            rdbEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(378, 112);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(86, 25);
            lblCantidad.TabIndex = 32;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(514, 109);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(158, 31);
            txtCantidad.TabIndex = 33;
            // 
            // grbCompra
            // 
            grbCompra.BackColor = Color.Pink;
            grbCompra.Controls.Add(lblClienteSeleccionado);
            grbCompra.Controls.Add(lblSucursal);
            grbCompra.Controls.Add(txtCantidad);
            grbCompra.Controls.Add(cmbSucursal);
            grbCompra.Controls.Add(lblCantidad);
            grbCompra.Controls.Add(lblCliente);
            grbCompra.Controls.Add(cmbClientes);
            grbCompra.Controls.Add(cmbProductos);
            grbCompra.Controls.Add(lblProducto);
            grbCompra.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbCompra.Location = new Point(49, 300);
            grbCompra.Name = "grbCompra";
            grbCompra.Size = new Size(697, 184);
            grbCompra.TabIndex = 3;
            grbCompra.TabStop = false;
            grbCompra.Text = "Datos de la compra";
            // 
            // lblClienteSeleccionado
            // 
            lblClienteSeleccionado.AutoSize = true;
            lblClienteSeleccionado.Location = new Point(33, 112);
            lblClienteSeleccionado.Name = "lblClienteSeleccionado";
            lblClienteSeleccionado.Size = new Size(71, 25);
            lblClienteSeleccionado.TabIndex = 34;
            lblClienteSeleccionado.Text = "Cliente";
            // 
            // btnCarrito
            // 
            btnCarrito.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCarrito.Location = new Point(229, 775);
            btnCarrito.Name = "btnCarrito";
            btnCarrito.Size = new Size(200, 37);
            btnCarrito.TabIndex = 27;
            btnCarrito.Text = "Añadir al carrito";
            btnCarrito.UseVisualStyleBackColor = true;
            btnCarrito.Click += btnCarrito_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(790, 74);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 53;
            dgvVentas.Size = new Size(784, 617);
            dgvVentas.TabIndex = 28;
            // 
            // btnFactura
            // 
            btnFactura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFactura.Location = new Point(1406, 816);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(157, 37);
            btnFactura.TabIndex = 29;
            btnFactura.Text = "Generar factura";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(790, 728);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(140, 25);
            lblTipo.TabIndex = 32;
            lblTipo.Text = "Tipo de cliente:";
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Font = new Font("Segoe UI", 9.216F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoCliente.Location = new Point(970, 728);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(65, 25);
            lblTipoCliente.TabIndex = 33;
            lblTipoCliente.Text = "label2";
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.Font = new Font("Calisto MT", 12.096F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizarVenta.Location = new Point(1081, 751);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(244, 84);
            btnFinalizarVenta.TabIndex = 34;
            btnFinalizarVenta.Text = "FINALIZAR VENTA";
            btnFinalizarVenta.UseVisualStyleBackColor = true;
            btnFinalizarVenta.Click += btnFinalizarVenta_Click;
            // 
            // FormVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1604, 874);
            Controls.Add(btnFinalizarVenta);
            Controls.Add(lblTipoCliente);
            Controls.Add(lblTipo);
            Controls.Add(btnFactura);
            Controls.Add(dgvVentas);
            Controls.Add(btnCarrito);
            Controls.Add(grbCompra);
            Controls.Add(grbMetododePago);
            Controls.Add(grbVentas);
            Controls.Add(lblSucursales);
            Font = new Font("Segoe UI", 9.216F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormVentas";
            Text = "GestionVentas";
            Load += FormVentas_Load;
            grbVentas.ResumeLayout(false);
            grbVentas.PerformLayout();
            grbMetododePago.ResumeLayout(false);
            grbMetododePago.PerformLayout();
            grbCompra.ResumeLayout(false);
            grbCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSucursales;
        private Label lblNombreVendedor;
        private Label lblApellidoVendedor;
        private TextBox txtApellidoVendedor;
        private TextBox txtNombreVendedor;
        private GroupBox grbVentas;
        private Label lblSucursal;
        private ComboBox cmbSucursal;
        private Label lblCliente;
        private ComboBox cmbClientes;
        private Label lblProducto;
        private ComboBox cmbProductos;
        private GroupBox grbMetododePago;
        private RadioButton rdbTransferencia;
        private RadioButton rdbTarjeta;
        private RadioButton rdbEfectivo;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private GroupBox grbCompra;
        private Button btnCarrito;
        private Label lblClienteSeleccionado;
        private DataGridView dgvVentas;
        private Button btnFactura;
        private Button btnRegistrarVendedor;
        private Label lblData;
        private DateTimePicker dtpVenta;
        private Label lblTipo;
        private Label lblTipoCliente;
        private Button btnFinalizarVenta;
        private ComboBox cmbVendedores;
        private Label lblVendores;
        private RadioButton rdbCuentaCorriente;
    }
}