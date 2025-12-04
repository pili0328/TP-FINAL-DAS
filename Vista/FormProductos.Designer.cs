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
            lblCodigo = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblCategoria = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            cmbCategoria = new ComboBox();
            lblProductos = new Label();
            btnCategoria = new Button();
            grbIngresoDatos = new GroupBox();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            grbCategoria = new GroupBox();
            txtCategoria = new TextBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dgvProductos = new DataGridView();
            grbIngresoDatos.SuspendLayout();
            grbCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCodigo.Location = new Point(23, 46);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(64, 21);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "Codigo";
            lblCodigo.Click += lblCodigo_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(23, 88);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPrecio.Location = new Point(23, 179);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(56, 21);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCategoria.Location = new Point(20, 50);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(138, 21);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Ingrese categoria";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(212, 43);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(164, 29);
            txtCodigo.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(212, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(164, 29);
            txtNombre.TabIndex = 9;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(212, 176);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(164, 29);
            txtPrecio.TabIndex = 10;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(209, 101);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(164, 29);
            cmbCategoria.TabIndex = 11;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductos.ForeColor = Color.DeepPink;
            lblProductos.Location = new Point(25, 23);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(407, 45);
            lblProductos.TabIndex = 12;
            lblProductos.Text = "GESTION DE PRODUCTOS";
            // 
            // btnCategoria
            // 
            btnCategoria.Location = new Point(20, 101);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(155, 30);
            btnCategoria.TabIndex = 14;
            btnCategoria.Text = "Añadir";
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // grbIngresoDatos
            // 
            grbIngresoDatos.Controls.Add(txtCantidad);
            grbIngresoDatos.Controls.Add(lblCantidad);
            grbIngresoDatos.Controls.Add(txtDescripcion);
            grbIngresoDatos.Controls.Add(lblDescripcion);
            grbIngresoDatos.Controls.Add(lblCodigo);
            grbIngresoDatos.Controls.Add(txtCodigo);
            grbIngresoDatos.Controls.Add(lblNombre);
            grbIngresoDatos.Controls.Add(txtPrecio);
            grbIngresoDatos.Controls.Add(txtNombre);
            grbIngresoDatos.Controls.Add(lblPrecio);
            grbIngresoDatos.Location = new Point(25, 96);
            grbIngresoDatos.Name = "grbIngresoDatos";
            grbIngresoDatos.Size = new Size(407, 276);
            grbIngresoDatos.TabIndex = 15;
            grbIngresoDatos.TabStop = false;
            grbIngresoDatos.Text = "Ingreso de datos del producto:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(212, 221);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(164, 29);
            txtCantidad.TabIndex = 18;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCantidad.Location = new Point(23, 229);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(75, 21);
            lblCantidad.TabIndex = 17;
            lblCantidad.Text = "Cantidad";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(212, 131);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(164, 29);
            txtDescripcion.TabIndex = 16;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblDescripcion.Location = new Point(23, 131);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(96, 21);
            lblDescripcion.TabIndex = 10;
            lblDescripcion.Text = "Descripcion";
            // 
            // grbCategoria
            // 
            grbCategoria.Controls.Add(txtCategoria);
            grbCategoria.Controls.Add(lblCategoria);
            grbCategoria.Controls.Add(btnCategoria);
            grbCategoria.Controls.Add(cmbCategoria);
            grbCategoria.Location = new Point(25, 389);
            grbCategoria.Name = "grbCategoria";
            grbCategoria.Size = new Size(404, 154);
            grbCategoria.TabIndex = 17;
            grbCategoria.TabStop = false;
            grbCategoria.Text = "Seleccion de categoria:";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(209, 42);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(164, 29);
            txtCategoria.TabIndex = 17;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(25, 610);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 30);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(164, 610);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(105, 30);
            btnModificar.TabIndex = 21;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(323, 610);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 30);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(523, 85);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(730, 555);
            dgvProductos.TabIndex = 24;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1280, 715);
            Controls.Add(dgvProductos);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(grbCategoria);
            Controls.Add(grbIngresoDatos);
            Controls.Add(lblProductos);
            Name = "FormProductos";
            Text = "FormProductos";
            Load += FormProductos_Load;
            grbIngresoDatos.ResumeLayout(false);
            grbIngresoDatos.PerformLayout();
            grbCategoria.ResumeLayout(false);
            grbCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCodigo;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblCategoria;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private ComboBox cmbCategoria;
        private Label lblProductos;
        private Button btnCategoria;
        private GroupBox grbIngresoDatos;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private GroupBox grbCategoria;
        private TextBox txtCategoria;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dgvProductos;
    }
}