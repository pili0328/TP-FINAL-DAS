namespace Vista
{
    partial class FormSucursal
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
            grbSucursal = new GroupBox();
            txtSucursal = new TextBox();
            lblSucursal = new Label();
            btnSucursal = new Button();
            cmbSucursal = new ComboBox();
            lblSucursales = new Label();
            grbMercaderia = new GroupBox();
            txtStockCantidad = new TextBox();
            lblSeleccionarProducto = new Label();
            lblStockProducto = new Label();
            cmbProducto = new ComboBox();
            btnGuardar = new Button();
            dgvStock = new DataGridView();
            grbSucursal.SuspendLayout();
            grbMercaderia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // grbSucursal
            // 
            grbSucursal.Controls.Add(txtSucursal);
            grbSucursal.Controls.Add(lblSucursal);
            grbSucursal.Controls.Add(btnSucursal);
            grbSucursal.Controls.Add(cmbSucursal);
            grbSucursal.Location = new Point(54, 126);
            grbSucursal.Name = "grbSucursal";
            grbSucursal.Size = new Size(407, 168);
            grbSucursal.TabIndex = 19;
            grbSucursal.TabStop = false;
            grbSucursal.Text = "Gestion de sucursales:";
            // 
            // txtSucursal
            // 
            txtSucursal.Location = new Point(209, 42);
            txtSucursal.Name = "txtSucursal";
            txtSucursal.Size = new Size(164, 29);
            txtSucursal.TabIndex = 17;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSucursal.Location = new Point(20, 50);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(127, 21);
            lblSucursal.TabIndex = 7;
            lblSucursal.Text = "Ingrese sucursal";
            // 
            // btnSucursal
            // 
            btnSucursal.Location = new Point(20, 101);
            btnSucursal.Name = "btnSucursal";
            btnSucursal.Size = new Size(155, 30);
            btnSucursal.TabIndex = 14;
            btnSucursal.Text = "Añadir";
            btnSucursal.UseVisualStyleBackColor = true;
            btnSucursal.Click += btnSucursal_Click;
            // 
            // cmbSucursal
            // 
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(209, 101);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(164, 29);
            cmbSucursal.TabIndex = 11;
            cmbSucursal.SelectionChangeCommitted += cmbSucursal_SelectionChangeCommitted;
            // 
            // lblSucursales
            // 
            lblSucursales.AutoSize = true;
            lblSucursales.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucursales.ForeColor = Color.DeepPink;
            lblSucursales.Location = new Point(287, 33);
            lblSucursales.Name = "lblSucursales";
            lblSucursales.Size = new Size(561, 45);
            lblSucursales.TabIndex = 20;
            lblSucursales.Text = "GESTION DE STOCK POR SUCURSAL";
            // 
            // grbMercaderia
            // 
            grbMercaderia.Controls.Add(txtStockCantidad);
            grbMercaderia.Controls.Add(lblSeleccionarProducto);
            grbMercaderia.Controls.Add(lblStockProducto);
            grbMercaderia.Controls.Add(cmbProducto);
            grbMercaderia.Location = new Point(54, 344);
            grbMercaderia.Name = "grbMercaderia";
            grbMercaderia.Size = new Size(407, 163);
            grbMercaderia.TabIndex = 20;
            grbMercaderia.TabStop = false;
            grbMercaderia.Text = "Asignacion de mercaderia";
            // 
            // txtStockCantidad
            // 
            txtStockCantidad.Location = new Point(209, 101);
            txtStockCantidad.Name = "txtStockCantidad";
            txtStockCantidad.Size = new Size(164, 29);
            txtStockCantidad.TabIndex = 18;
            // 
            // lblSeleccionarProducto
            // 
            lblSeleccionarProducto.AutoSize = true;
            lblSeleccionarProducto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSeleccionarProducto.Location = new Point(20, 59);
            lblSeleccionarProducto.Name = "lblSeleccionarProducto";
            lblSeleccionarProducto.Size = new Size(178, 21);
            lblSeleccionarProducto.TabIndex = 20;
            lblSeleccionarProducto.Text = "Producto seleccionado";
            // 
            // lblStockProducto
            // 
            lblStockProducto.AutoSize = true;
            lblStockProducto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStockProducto.Location = new Point(20, 109);
            lblStockProducto.Name = "lblStockProducto";
            lblStockProducto.Size = new Size(151, 21);
            lblStockProducto.TabIndex = 7;
            lblStockProducto.Text = "Stock del producto";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(209, 51);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(164, 29);
            cmbProducto.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(169, 568);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(155, 30);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar stock";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(530, 113);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 53;
            dgvStock.Size = new Size(629, 472);
            dgvStock.TabIndex = 21;
            // 
            // FormSucursal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 675);
            Controls.Add(dgvStock);
            Controls.Add(btnGuardar);
            Controls.Add(grbMercaderia);
            Controls.Add(lblSucursales);
            Controls.Add(grbSucursal);
            Name = "FormSucursal";
            Text = "FormSucursal";
            Load += FormSucursal_Load;
            grbSucursal.ResumeLayout(false);
            grbSucursal.PerformLayout();
            grbMercaderia.ResumeLayout(false);
            grbMercaderia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbSucursal;
        private TextBox txtStock;
        private Label lblStock;
        private TextBox txtSucursal;
        private Label lblSucursal;
        private Button btnSucursal;
        private ComboBox cmbSucursal;
        private Label lblSucursales;
        private GroupBox grbMercaderia;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label lblStockProducto;
        private Button button1;
        private ComboBox cmbProducto;
        private Label lblSeleccionarProducto;
        private Button btnGuardar;
        private DataGridView dgvStock;
        private TextBox txtStockCantidad;
    }
}