namespace Vista
{
    partial class FormFactura
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
            lblNombre = new Label();
            lblProducto = new Label();
            lblCantidad = new Label();
            lblTipoDePago = new Label();
            lblPrecio = new Label();
            lblDescuento = new Label();
            gbFactura = new GroupBox();
            lblCargaTDP = new Label();
            lblCargaPr = new Label();
            lblCargaCant = new Label();
            lblCargaProd = new Label();
            gbDescuento = new GroupBox();
            lblCargaDesc = new Label();
            gbCliente = new GroupBox();
            btnCarga = new Button();
            cbCliente = new ComboBox();
            gbFactura.SuspendLayout();
            gbDescuento.SuspendLayout();
            gbCliente.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(6, 56);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(97, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "NOMBRE: ";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblProducto.Location = new Point(17, 56);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(112, 25);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "PRODUCTO:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblCantidad.Location = new Point(17, 106);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(106, 25);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "CANTIDAD:";
            // 
            // lblTipoDePago
            // 
            lblTipoDePago.AutoSize = true;
            lblTipoDePago.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblTipoDePago.Location = new Point(17, 197);
            lblTipoDePago.Name = "lblTipoDePago";
            lblTipoDePago.Size = new Size(142, 25);
            lblTipoDePago.TabIndex = 3;
            lblTipoDePago.Text = "TIPO DE PAGO: ";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(17, 152);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(82, 25);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "PRECIO: ";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescuento.Location = new Point(17, 58);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(123, 25);
            lblDescuento.TabIndex = 5;
            lblDescuento.Text = "DESCUENTO: ";
            // 
            // gbFactura
            // 
            gbFactura.BackColor = Color.Pink;
            gbFactura.Controls.Add(lblCargaTDP);
            gbFactura.Controls.Add(lblCargaPr);
            gbFactura.Controls.Add(lblCargaCant);
            gbFactura.Controls.Add(lblCargaProd);
            gbFactura.Controls.Add(lblProducto);
            gbFactura.Controls.Add(lblTipoDePago);
            gbFactura.Controls.Add(lblPrecio);
            gbFactura.Controls.Add(lblCantidad);
            gbFactura.Location = new Point(466, 219);
            gbFactura.Name = "gbFactura";
            gbFactura.Size = new Size(394, 247);
            gbFactura.TabIndex = 6;
            gbFactura.TabStop = false;
            gbFactura.Text = "FACTURA: ";
            // 
            // lblCargaTDP
            // 
            lblCargaTDP.AutoSize = true;
            lblCargaTDP.Location = new Point(165, 197);
            lblCargaTDP.Name = "lblCargaTDP";
            lblCargaTDP.Size = new Size(59, 25);
            lblCargaTDP.TabIndex = 8;
            lblCargaTDP.Text = "label4";
            // 
            // lblCargaPr
            // 
            lblCargaPr.AutoSize = true;
            lblCargaPr.Location = new Point(165, 152);
            lblCargaPr.Name = "lblCargaPr";
            lblCargaPr.Size = new Size(59, 25);
            lblCargaPr.TabIndex = 7;
            lblCargaPr.Text = "label3";
            // 
            // lblCargaCant
            // 
            lblCargaCant.AutoSize = true;
            lblCargaCant.Location = new Point(165, 106);
            lblCargaCant.Name = "lblCargaCant";
            lblCargaCant.Size = new Size(59, 25);
            lblCargaCant.TabIndex = 6;
            lblCargaCant.Text = "label2";
            // 
            // lblCargaProd
            // 
            lblCargaProd.AutoSize = true;
            lblCargaProd.Location = new Point(165, 59);
            lblCargaProd.Name = "lblCargaProd";
            lblCargaProd.Size = new Size(59, 25);
            lblCargaProd.TabIndex = 5;
            lblCargaProd.Text = "label1";
            // 
            // gbDescuento
            // 
            gbDescuento.BackColor = Color.Pink;
            gbDescuento.Controls.Add(lblCargaDesc);
            gbDescuento.Controls.Add(lblDescuento);
            gbDescuento.Location = new Point(466, 494);
            gbDescuento.Name = "gbDescuento";
            gbDescuento.Size = new Size(394, 116);
            gbDescuento.TabIndex = 7;
            gbDescuento.TabStop = false;
            gbDescuento.Text = "DESCUENTO APLICADO: ";
            // 
            // lblCargaDesc
            // 
            lblCargaDesc.AutoSize = true;
            lblCargaDesc.Location = new Point(146, 58);
            lblCargaDesc.Name = "lblCargaDesc";
            lblCargaDesc.Size = new Size(59, 25);
            lblCargaDesc.TabIndex = 6;
            lblCargaDesc.Text = "label5";
            // 
            // gbCliente
            // 
            gbCliente.BackColor = Color.Pink;
            gbCliente.Controls.Add(btnCarga);
            gbCliente.Controls.Add(cbCliente);
            gbCliente.Controls.Add(lblNombre);
            gbCliente.Location = new Point(466, 23);
            gbCliente.Name = "gbCliente";
            gbCliente.Size = new Size(394, 167);
            gbCliente.TabIndex = 8;
            gbCliente.TabStop = false;
            gbCliente.Text = "BUSCAR CLIENTE: ";
            // 
            // btnCarga
            // 
            btnCarga.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCarga.Location = new Point(19, 106);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(209, 44);
            btnCarga.TabIndex = 9;
            btnCarga.Text = "CARGAR FACTURA";
            btnCarga.UseVisualStyleBackColor = true;
            btnCarga.Click += btnCarga_Click;
            // 
            // cbCliente
            // 
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new Point(132, 56);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new Size(182, 33);
            cbCliente.TabIndex = 9;
            // 
            // FormFactura
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1285, 632);
            Controls.Add(gbCliente);
            Controls.Add(gbDescuento);
            Controls.Add(gbFactura);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormFactura";
            Text = "FormFactura";
            Load += FormFactura_Load;
            gbFactura.ResumeLayout(false);
            gbFactura.PerformLayout();
            gbDescuento.ResumeLayout(false);
            gbDescuento.PerformLayout();
            gbCliente.ResumeLayout(false);
            gbCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private Label lblProducto;
        private Label lblCantidad;
        private Label lblTipoDePago;
        private Label lblPrecio;
        private Label lblDescuento;
        private GroupBox gbFactura;
        private GroupBox gbDescuento;
        private GroupBox gbCliente;
        private Button btnCarga;
        private ComboBox cbCliente;
        private Label lblCargaTDP;
        private Label lblCargaPr;
        private Label lblCargaCant;
        private Label lblCargaProd;
        private Label lblCargaDesc;
    }
}