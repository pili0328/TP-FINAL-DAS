namespace Vista
{
    partial class FormReportes
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
            btnCargarReporte = new Button();
            btnEstadoCC = new Button();
            btnProductoVendido = new Button();
            dgvCargarReportePorTipo = new DataGridView();
            gbReporteVenta = new GroupBox();
            lblHasta = new Label();
            lblDesde = new Label();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            lblPeriodo = new Label();
            cbTipoReporte = new ComboBox();
            lblTipoReporte = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCargarReportePorTipo).BeginInit();
            gbReporteVenta.SuspendLayout();
            SuspendLayout();
            // 
            // btnCargarReporte
            // 
            btnCargarReporte.Location = new Point(25, 296);
            btnCargarReporte.Name = "btnCargarReporte";
            btnCargarReporte.Size = new Size(192, 43);
            btnCargarReporte.TabIndex = 0;
            btnCargarReporte.Text = "CARGAR REPORTE";
            btnCargarReporte.UseVisualStyleBackColor = true;
            btnCargarReporte.Click += btnCargarReporte_Click;
            // 
            // btnEstadoCC
            // 
            btnEstadoCC.BackColor = Color.LightGray;
            btnEstadoCC.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstadoCC.Location = new Point(45, 435);
            btnEstadoCC.Name = "btnEstadoCC";
            btnEstadoCC.Size = new Size(168, 74);
            btnEstadoCC.TabIndex = 1;
            btnEstadoCC.Text = "ESTADO CUENTA CORRIENTE";
            btnEstadoCC.UseVisualStyleBackColor = false;
            btnEstadoCC.Click += btnEstadoCC_Click;
            // 
            // btnProductoVendido
            // 
            btnProductoVendido.BackColor = Color.LightGray;
            btnProductoVendido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductoVendido.Location = new Point(278, 435);
            btnProductoVendido.Name = "btnProductoVendido";
            btnProductoVendido.Size = new Size(168, 74);
            btnProductoVendido.TabIndex = 2;
            btnProductoVendido.Text = "PRODUCTO MAS VENDIDO";
            btnProductoVendido.UseVisualStyleBackColor = false;
            btnProductoVendido.Click += btnProductoVendido_Click;
            // 
            // dgvCargarReportePorTipo
            // 
            dgvCargarReportePorTipo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCargarReportePorTipo.Location = new Point(573, 40);
            dgvCargarReportePorTipo.Name = "dgvCargarReportePorTipo";
            dgvCargarReportePorTipo.RowHeadersWidth = 62;
            dgvCargarReportePorTipo.Size = new Size(740, 400);
            dgvCargarReportePorTipo.TabIndex = 3;
            // 
            // gbReporteVenta
            // 
            gbReporteVenta.BackColor = Color.Pink;
            gbReporteVenta.Controls.Add(lblHasta);
            gbReporteVenta.Controls.Add(lblDesde);
            gbReporteVenta.Controls.Add(dtpHasta);
            gbReporteVenta.Controls.Add(dtpDesde);
            gbReporteVenta.Controls.Add(lblPeriodo);
            gbReporteVenta.Controls.Add(cbTipoReporte);
            gbReporteVenta.Controls.Add(lblTipoReporte);
            gbReporteVenta.Controls.Add(btnCargarReporte);
            gbReporteVenta.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            gbReporteVenta.Location = new Point(12, 40);
            gbReporteVenta.Name = "gbReporteVenta";
            gbReporteVenta.Size = new Size(539, 366);
            gbReporteVenta.TabIndex = 4;
            gbReporteVenta.TabStop = false;
            gbReporteVenta.Text = "REPORTES DE VENTAS: ";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(75, 245);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(77, 25);
            lblHasta.TabIndex = 10;
            lblHasta.Text = "HASTA: ";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(77, 173);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(75, 25);
            lblDesde.TabIndex = 9;
            lblDesde.Text = "DESDE: ";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(221, 239);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(300, 31);
            dtpHasta.TabIndex = 8;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(221, 173);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(300, 31);
            dtpDesde.TabIndex = 7;
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Location = new Point(25, 114);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(336, 25);
            lblPeriodo.TabIndex = 6;
            lblPeriodo.Text = "SE ELIJE LA FECHA SI ES POR PERIODO: ";
            // 
            // cbTipoReporte
            // 
            cbTipoReporte.FormattingEnabled = true;
            cbTipoReporte.Location = new Point(279, 58);
            cbTipoReporte.Name = "cbTipoReporte";
            cbTipoReporte.Size = new Size(225, 33);
            cbTipoReporte.TabIndex = 5;
            cbTipoReporte.SelectionChangeCommitted += cbTipoReporte_SelectionChangeCommitted;
            // 
            // lblTipoReporte
            // 
            lblTipoReporte.AutoSize = true;
            lblTipoReporte.Location = new Point(16, 58);
            lblTipoReporte.Name = "lblTipoReporte";
            lblTipoReporte.Size = new Size(257, 25);
            lblTipoReporte.TabIndex = 5;
            lblTipoReporte.Text = "TIPO DE REPORTE BUSCADO: ";
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1325, 531);
            Controls.Add(btnProductoVendido);
            Controls.Add(gbReporteVenta);
            Controls.Add(dgvCargarReportePorTipo);
            Controls.Add(btnEstadoCC);
            Name = "FormReportes";
            Text = "FormReportes";
            Load += FormReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCargarReportePorTipo).EndInit();
            gbReporteVenta.ResumeLayout(false);
            gbReporteVenta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCargarReporte;
        private Button btnEstadoCC;
        private Button btnProductoVendido;
        private DataGridView dgvCargarReportePorTipo;
        private GroupBox gbReporteVenta;
        private ComboBox cbTipoReporte;
        private Label lblTipoReporte;
        private Label lblPeriodo;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private Label lblHasta;
        private Label lblDesde;
    }
}