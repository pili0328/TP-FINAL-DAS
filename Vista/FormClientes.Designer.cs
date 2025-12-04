namespace Vista
{
    partial class FormClientes
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
            btnGuardarCliente = new Button();
            btnModificar = new Button();
            dgvCliente = new DataGridView();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDNI = new Label();
            lblTipoCliente = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            cbTipoCliente = new ComboBox();
            btnEliminar = new Button();
            gbIngresoDatos = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            gbIngresoDatos.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardarCliente
            // 
            btnGuardarCliente.BackColor = Color.Snow;
            btnGuardarCliente.ForeColor = SystemColors.ControlText;
            btnGuardarCliente.Location = new Point(31, 548);
            btnGuardarCliente.Name = "btnGuardarCliente";
            btnGuardarCliente.Size = new Size(104, 29);
            btnGuardarCliente.TabIndex = 0;
            btnGuardarCliente.Text = "GUARDAR";
            btnGuardarCliente.UseVisualStyleBackColor = false;
            btnGuardarCliente.Click += btnGuardarCliente_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Snow;
            btnModificar.Location = new Point(191, 548);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(104, 29);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // dgvCliente
            // 
            dgvCliente.BackgroundColor = Color.White;
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Location = new Point(590, 29);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowHeadersWidth = 62;
            dgvCliente.Size = new Size(642, 548);
            dgvCliente.TabIndex = 2;
            dgvCliente.SelectionChanged += dgvCliente_SelectionChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(65, 85);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(75, 21);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "NOMBRE";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(65, 162);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(80, 21);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "APELLIDO";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(65, 253);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(37, 21);
            lblDNI.TabIndex = 5;
            lblDNI.Text = "DNI";
            lblDNI.Click += lblDNI_Click;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.BackColor = Color.AntiqueWhite;
            lblTipoCliente.Location = new Point(65, 346);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(128, 21);
            lblTipoCliente.TabIndex = 6;
            lblTipoCliente.Text = "TIPO DE CLIENTE";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(244, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(135, 29);
            txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(244, 159);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(135, 29);
            txtApellido.TabIndex = 8;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(244, 245);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(135, 29);
            txtDNI.TabIndex = 9;
            // 
            // cbTipoCliente
            // 
            cbTipoCliente.FormattingEnabled = true;
            cbTipoCliente.Location = new Point(244, 343);
            cbTipoCliente.Name = "cbTipoCliente";
            cbTipoCliente.Size = new Size(135, 29);
            cbTipoCliente.TabIndex = 10;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Snow;
            btnEliminar.Location = new Point(366, 548);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(104, 29);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // gbIngresoDatos
            // 
            gbIngresoDatos.BackColor = Color.AntiqueWhite;
            gbIngresoDatos.Controls.Add(lblNombre);
            gbIngresoDatos.Controls.Add(txtNombre);
            gbIngresoDatos.Controls.Add(cbTipoCliente);
            gbIngresoDatos.Controls.Add(lblApellido);
            gbIngresoDatos.Controls.Add(lblTipoCliente);
            gbIngresoDatos.Controls.Add(txtDNI);
            gbIngresoDatos.Controls.Add(txtApellido);
            gbIngresoDatos.Controls.Add(lblDNI);
            gbIngresoDatos.Location = new Point(31, 41);
            gbIngresoDatos.Name = "gbIngresoDatos";
            gbIngresoDatos.Size = new Size(439, 444);
            gbIngresoDatos.TabIndex = 12;
            gbIngresoDatos.TabStop = false;
            gbIngresoDatos.Text = "Ingreso datos";
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1311, 638);
            Controls.Add(gbIngresoDatos);
            Controls.Add(btnEliminar);
            Controls.Add(dgvCliente);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardarCliente);
            Name = "FormClientes";
            Text = "FormClientes";
            Load += FormClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            gbIngresoDatos.ResumeLayout(false);
            gbIngresoDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardarCliente;
        private Button btnModificar;
        private DataGridView dgvCliente;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDNI;
        private Label lblTipoCliente;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private ComboBox cbTipoCliente;
        private Button btnEliminar;
        private GroupBox gbIngresoDatos;
    }
}