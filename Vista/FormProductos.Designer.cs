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
            lblProductos = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(447, 39);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(775, 508);
            dgvProductos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAgregar.Location = new Point(123, 327);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(177, 67);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnModificar.Location = new Point(123, 399);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(177, 67);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEliminar.Location = new Point(123, 471);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(177, 67);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCodigo.Location = new Point(61, 104);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(71, 21);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "CODIGO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(61, 155);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 21);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "NOMBRE";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblPrecio.Location = new Point(61, 205);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(64, 21);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "PRECIO";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCategoria.Location = new Point(61, 252);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(96, 21);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "CATEGORIA";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(225, 104);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(164, 29);
            txtCodigo.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(225, 150);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(164, 29);
            txtNombre.TabIndex = 9;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(225, 200);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(164, 29);
            txtPrecio.TabIndex = 10;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(225, 249);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(164, 29);
            cbCategoria.TabIndex = 11;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductos.ForeColor = Color.DeepPink;
            lblProductos.Location = new Point(22, 29);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(407, 45);
            lblProductos.TabIndex = 12;
            lblProductos.Text = "GESTION DE PRODCUTOS";

            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1233, 558);
            Controls.Add(lblProductos);
            Controls.Add(cbCategoria);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblCategoria);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProductos);
            Name = "FormProductos";
            Text = "FormProductos";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblProductos;
    }
}