namespace Vista
{
    partial class FormProductos
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
            dgvProductos = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lblCodigo = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblCategoria = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            cbCategoria = new ComboBox();
            gbCargarDatos = new GroupBox();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            gbCargaDatosStock = new GroupBox();
            lblStockSucursal = new Label();
            txtStockSucursal = new TextBox();
            cbSucursal = new ComboBox();
            lblSucursal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            gbCargarDatos.SuspendLayout();
            gbCargaDatosStock.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(491, 14);
            dgvProductos.Margin = new Padding(3, 5, 3, 5);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(867, 529);
            dgvProductos.TabIndex = 0;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAgregar.Location = new Point(19, 499);
            btnAgregar.Margin = new Padding(3, 5, 3, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(146, 44);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnModificar.Location = new Point(171, 499);
            btnModificar.Margin = new Padding(3, 5, 3, 5);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(146, 44);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEliminar.Location = new Point(323, 499);
            btnEliminar.Margin = new Padding(3, 5, 3, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(146, 44);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Pink;
            lblCodigo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCodigo.Location = new Point(55, 43);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(82, 25);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "CODIGO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Pink;
            lblNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(55, 90);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(88, 25);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "NOMBRE";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Pink;
            lblPrecio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPrecio.Location = new Point(55, 199);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(73, 25);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "PRECIO";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.Pink;
            lblCategoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCategoria.Location = new Point(55, 252);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(108, 25);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "CATEGORIA";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(237, 37);
            txtCodigo.Margin = new Padding(3, 5, 3, 5);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(182, 31);
            txtCodigo.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(237, 90);
            txtNombre.Margin = new Padding(3, 5, 3, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(182, 31);
            txtNombre.TabIndex = 9;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(237, 196);
            txtPrecio.Margin = new Padding(3, 5, 3, 5);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(182, 31);
            txtPrecio.TabIndex = 10;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(237, 252);
            cbCategoria.Margin = new Padding(3, 5, 3, 5);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(182, 33);
            cbCategoria.TabIndex = 11;
            // 
            // gbCargarDatos
            // 
            gbCargarDatos.BackColor = Color.Pink;
            gbCargarDatos.Controls.Add(txtDescripcion);
            gbCargarDatos.Controls.Add(lblCategoria);
            gbCargarDatos.Controls.Add(txtPrecio);
            gbCargarDatos.Controls.Add(lblPrecio);
            gbCargarDatos.Controls.Add(cbCategoria);
            gbCargarDatos.Controls.Add(txtCodigo);
            gbCargarDatos.Controls.Add(txtNombre);
            gbCargarDatos.Controls.Add(lblNombre);
            gbCargarDatos.Controls.Add(lblDescripcion);
            gbCargarDatos.Controls.Add(lblCodigo);
            gbCargarDatos.Location = new Point(13, 30);
            gbCargarDatos.Margin = new Padding(3, 4, 3, 4);
            gbCargarDatos.Name = "gbCargarDatos";
            gbCargarDatos.Padding = new Padding(3, 4, 3, 4);
            gbCargarDatos.Size = new Size(456, 301);
            gbCargarDatos.TabIndex = 12;
            gbCargarDatos.TabStop = false;
            gbCargarDatos.Text = "Carga de datos:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(237, 143);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(182, 31);
            txtDescripcion.TabIndex = 13;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(52, 143);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(126, 25);
            lblDescripcion.TabIndex = 12;
            lblDescripcion.Text = "DESCRIPCION";
            // 
            // gbCargaDatosStock
            // 
            gbCargaDatosStock.BackColor = Color.Pink;
            gbCargaDatosStock.Controls.Add(lblStockSucursal);
            gbCargaDatosStock.Controls.Add(txtStockSucursal);
            gbCargaDatosStock.Controls.Add(cbSucursal);
            gbCargaDatosStock.Controls.Add(lblSucursal);
            gbCargaDatosStock.Location = new Point(13, 339);
            gbCargaDatosStock.Margin = new Padding(3, 4, 3, 4);
            gbCargaDatosStock.Name = "gbCargaDatosStock";
            gbCargaDatosStock.Padding = new Padding(3, 4, 3, 4);
            gbCargaDatosStock.Size = new Size(456, 136);
            gbCargaDatosStock.TabIndex = 14;
            gbCargaDatosStock.TabStop = false;
            gbCargaDatosStock.Text = "Carga de datos de stock:";
            // 
            // lblStockSucursal
            // 
            lblStockSucursal.AutoSize = true;
            lblStockSucursal.BackColor = Color.Pink;
            lblStockSucursal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblStockSucursal.Location = new Point(55, 90);
            lblStockSucursal.Name = "lblStockSucursal";
            lblStockSucursal.Size = new Size(72, 25);
            lblStockSucursal.TabIndex = 4;
            lblStockSucursal.Text = "STOCK ";
            // 
            // txtStockSucursal
            // 
            txtStockSucursal.Location = new Point(237, 90);
            txtStockSucursal.Margin = new Padding(3, 5, 3, 5);
            txtStockSucursal.Name = "txtStockSucursal";
            txtStockSucursal.Size = new Size(182, 31);
            txtStockSucursal.TabIndex = 8;
            // 
            // cbSucursal
            // 
            cbSucursal.FormattingEnabled = true;
            cbSucursal.Location = new Point(237, 33);
            cbSucursal.Margin = new Padding(3, 5, 3, 5);
            cbSucursal.Name = "cbSucursal";
            cbSucursal.Size = new Size(182, 33);
            cbSucursal.TabIndex = 11;
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.BackColor = Color.Pink;
            lblSucursal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblSucursal.Location = new Point(55, 42);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(101, 25);
            lblSucursal.TabIndex = 7;
            lblSucursal.Text = "SUCURSAL";
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1370, 554);
            Controls.Add(gbCargaDatosStock);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProductos);
            Controls.Add(gbCargarDatos);
            Margin = new Padding(3, 5, 3, 5);
            Name = "FormProductos";
            Text = "FormProductos";
            Load += FormProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            gbCargarDatos.ResumeLayout(false);
            gbCargarDatos.PerformLayout();
            gbCargaDatosStock.ResumeLayout(false);
            gbCargaDatosStock.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvProductos;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label lblCodigo;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblCategoria;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private ComboBox cbCategoria;
        private GroupBox gbCargarDatos;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private GroupBox gbCargaDatosStock;
        private Label lblStockSucursal;
        private TextBox txtStockSucursal;
        private ComboBox cbSucursal;
        private Label lblSucursal;

    }
}