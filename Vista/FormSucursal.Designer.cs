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
            grbSucursal.BackColor = Color.Pink;
            grbSucursal.Controls.Add(txtSucursal);
            grbSucursal.Controls.Add(lblSucursal);
            grbSucursal.Controls.Add(btnSucursal);
            grbSucursal.Controls.Add(cmbSucursal);
            grbSucursal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            grbSucursal.Location = new Point(60, 150);
            grbSucursal.Margin = new Padding(3, 4, 3, 4);
            grbSucursal.Name = "grbSucursal";
            grbSucursal.Padding = new Padding(3, 4, 3, 4);
            grbSucursal.Size = new Size(452, 200);
            grbSucursal.TabIndex = 19;
            grbSucursal.TabStop = false;
            grbSucursal.Text = "Gestion de sucursales:";
            // 
            // txtSucursal
            // 
            txtSucursal.Location = new Point(232, 50);
            txtSucursal.Margin = new Padding(3, 4, 3, 4);
            txtSucursal.Name = "txtSucursal";
            txtSucursal.Size = new Size(182, 31);
            txtSucursal.TabIndex = 17;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSucursal.Location = new Point(22, 60);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(146, 25);
            lblSucursal.TabIndex = 7;
            lblSucursal.Text = "Ingrese sucursal";
            // 
            // btnSucursal
            // 
            btnSucursal.Location = new Point(22, 120);
            btnSucursal.Margin = new Padding(3, 4, 3, 4);
            btnSucursal.Name = "btnSucursal";
            btnSucursal.Size = new Size(172, 36);
            btnSucursal.TabIndex = 14;
            btnSucursal.Text = "Añadir";
            btnSucursal.UseVisualStyleBackColor = true;
            btnSucursal.Click += btnSucursal_Click;
            // 
            // cmbSucursal
            // 
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(232, 120);
            cmbSucursal.Margin = new Padding(3, 4, 3, 4);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(182, 33);
            cmbSucursal.TabIndex = 11;
            cmbSucursal.SelectionChangeCommitted += cmbSucursal_SelectionChangeCommitted;
            // 
            // lblSucursales
            // 
            lblSucursales.AutoSize = true;
            lblSucursales.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSucursales.ForeColor = Color.DeepPink;
            lblSucursales.Location = new Point(319, 39);
            lblSucursales.Name = "lblSucursales";
            lblSucursales.Size = new Size(624, 48);
            lblSucursales.TabIndex = 20;
            lblSucursales.Text = "GESTION DE STOCK POR SUCURSAL";
            // 
            // grbMercaderia
            // 
            grbMercaderia.BackColor = Color.Pink;
            grbMercaderia.Controls.Add(txtStockCantidad);
            grbMercaderia.Controls.Add(lblSeleccionarProducto);
            grbMercaderia.Controls.Add(lblStockProducto);
            grbMercaderia.Controls.Add(cmbProducto);
            grbMercaderia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            grbMercaderia.Location = new Point(60, 410);
            grbMercaderia.Margin = new Padding(3, 4, 3, 4);
            grbMercaderia.Name = "grbMercaderia";
            grbMercaderia.Padding = new Padding(3, 4, 3, 4);
            grbMercaderia.Size = new Size(452, 194);
            grbMercaderia.TabIndex = 20;
            grbMercaderia.TabStop = false;
            grbMercaderia.Text = "Asignacion de mercaderia";
            // 
            // txtStockCantidad
            // 
            txtStockCantidad.Location = new Point(232, 120);
            txtStockCantidad.Margin = new Padding(3, 4, 3, 4);
            txtStockCantidad.Name = "txtStockCantidad";
            txtStockCantidad.Size = new Size(182, 31);
            txtStockCantidad.TabIndex = 18;
            // 
            // lblSeleccionarProducto
            // 
            lblSeleccionarProducto.AutoSize = true;
            lblSeleccionarProducto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSeleccionarProducto.Location = new Point(22, 70);
            lblSeleccionarProducto.Name = "lblSeleccionarProducto";
            lblSeleccionarProducto.Size = new Size(201, 25);
            lblSeleccionarProducto.TabIndex = 20;
            lblSeleccionarProducto.Text = "Producto seleccionado";
            // 
            // lblStockProducto
            // 
            lblStockProducto.AutoSize = true;
            lblStockProducto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStockProducto.Location = new Point(22, 130);
            lblStockProducto.Name = "lblStockProducto";
            lblStockProducto.Size = new Size(169, 25);
            lblStockProducto.TabIndex = 7;
            lblStockProducto.Text = "Stock del producto";
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(232, 61);
            cmbProducto.Margin = new Padding(3, 4, 3, 4);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(182, 33);
            cmbProducto.TabIndex = 11;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(188, 676);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(172, 36);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar stock";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(589, 135);
            dgvStock.Margin = new Padding(3, 4, 3, 4);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 53;
            dgvStock.Size = new Size(699, 562);
            dgvStock.TabIndex = 21;
            // 
            // FormSucursal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1336, 804);
            Controls.Add(dgvStock);
            Controls.Add(btnGuardar);
            Controls.Add(grbMercaderia);
            Controls.Add(lblSucursales);
            Controls.Add(grbSucursal);
            Margin = new Padding(3, 4, 3, 4);
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