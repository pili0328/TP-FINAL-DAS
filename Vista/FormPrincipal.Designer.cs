namespace Vista
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            btnClientes = new Button();
            btnProductos = new Button();
            btnVentas = new Button();
            btnReportesConsultas = new Button();
            btnGestionStock = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.DeepPink;
            lblTitulo.Location = new Point(372, 51);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(204, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "TechStore S.A.";
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.Location = new Point(372, 146);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(184, 46);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "GESTION CLIENTES";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.Location = new Point(372, 223);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(184, 46);
            btnProductos.TabIndex = 2;
            btnProductos.Text = "GESTION PRODUCTOS";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnVentas
            // 
            btnVentas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.Location = new Point(372, 371);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(184, 46);
            btnVentas.TabIndex = 3;
            btnVentas.Text = "GESTION DE VENTAS";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnReportesConsultas
            // 
            btnReportesConsultas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportesConsultas.Location = new Point(372, 452);
            btnReportesConsultas.Name = "btnReportesConsultas";
            btnReportesConsultas.Size = new Size(184, 46);
            btnReportesConsultas.TabIndex = 4;
            btnReportesConsultas.Text = "Reportes y Consultas";
            btnReportesConsultas.UseVisualStyleBackColor = true;
            btnReportesConsultas.Click += btnReportesConsultas_Click;
            // 
            // btnGestionStock
            // 
            btnGestionStock.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionStock.Location = new Point(372, 294);
            btnGestionStock.Name = "btnGestionStock";
            btnGestionStock.Size = new Size(184, 46);
            btnGestionStock.TabIndex = 5;
            btnGestionStock.Text = "GESTION DE STOCK";
            btnGestionStock.UseVisualStyleBackColor = true;
            btnGestionStock.Click += btnGestionStock_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(877, 470);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(104, 28);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1036, 533);
            Controls.Add(btnSalir);
            Controls.Add(btnGestionStock);
            Controls.Add(btnReportesConsultas);
            Controls.Add(btnVentas);
            Controls.Add(btnProductos);
            Controls.Add(btnClientes);
            Controls.Add(lblTitulo);
            ForeColor = Color.Black;
            Name = "FormPrincipal";
            Text = "Form1";
            TransparencyKey = Color.White;
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnClientes;
        private Button btnProductos;
        private Button btnVentas;
        private Button btnReportesConsultas;
        private Button btnGestionStock;
        private Button btnSalir;
    }
}
