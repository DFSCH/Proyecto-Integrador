namespace Sistema_de_Calculo.VISTA
{
    partial class PanelFacturas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pnlFiltros = new Panel();
            txtFiltroCliente = new TextBox();
            cmbFiltroEstado = new ComboBox();
            btnFiltrar = new Button();
            btnLimpiar = new Button();
            lblTit = new Label();
            btnEstado = new Button();
            btnPDF = new Button();
            dgv = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            Cotizacion = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // pnlFiltros
            // 
            pnlFiltros.BackColor = Color.White;
            pnlFiltros.Controls.Add(txtFiltroCliente);
            pnlFiltros.Controls.Add(cmbFiltroEstado);
            pnlFiltros.Controls.Add(btnFiltrar);
            pnlFiltros.Controls.Add(btnLimpiar);
            pnlFiltros.Location = new Point(27, 34);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(960, 44);
            pnlFiltros.TabIndex = 2;
            // 
            // txtFiltroCliente
            // 
            txtFiltroCliente.BorderStyle = BorderStyle.FixedSingle;
            txtFiltroCliente.Location = new Point(8, 9);
            txtFiltroCliente.Name = "txtFiltroCliente";
            txtFiltroCliente.PlaceholderText = "Cliente…";
            txtFiltroCliente.Size = new Size(180, 27);
            txtFiltroCliente.TabIndex = 0;
            // 
            // cmbFiltroEstado
            // 
            cmbFiltroEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroEstado.Items.AddRange(new object[] { "Todos", "activa", "inactiva" });
            cmbFiltroEstado.Location = new Point(196, 9);
            cmbFiltroEstado.Name = "cmbFiltroEstado";
            cmbFiltroEstado.Size = new Size(110, 28);
            cmbFiltroEstado.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.FromArgb(24, 95, 165);
            btnFiltrar.Cursor = Cursors.Hand;
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.Location = new Point(747, 9);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(80, 26);
            btnFiltrar.TabIndex = 6;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.FromArgb(60, 60, 60);
            btnLimpiar.Location = new Point(833, 8);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(80, 29);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblTit
            // 
            lblTit.AutoSize = true;
            lblTit.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTit.ForeColor = Color.FromArgb(30, 30, 30);
            lblTit.Location = new Point(27, -5);
            lblTit.Name = "lblTit";
            lblTit.Size = new Size(99, 30);
            lblTit.TabIndex = 5;
            lblTit.Text = "Facturas";
            // 
            // btnEstado
            // 
            btnEstado.BackColor = Color.White;
            btnEstado.Cursor = Cursors.Hand;
            btnEstado.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnEstado.FlatStyle = FlatStyle.Flat;
            btnEstado.ForeColor = Color.FromArgb(60, 60, 60);
            btnEstado.Location = new Point(27, 83);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(140, 28);
            btnEstado.TabIndex = 6;
            btnEstado.Text = "Cambiar estado";
            btnEstado.UseVisualStyleBackColor = false;
            btnEstado.Click += btnEstado_Click;
            // 
            // btnPDF
            // 
            btnPDF.BackColor = Color.White;
            btnPDF.Cursor = Cursors.Hand;
            btnPDF.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnPDF.FlatStyle = FlatStyle.Flat;
            btnPDF.ForeColor = Color.FromArgb(60, 60, 60);
            btnPDF.Location = new Point(175, 83);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(130, 28);
            btnPDF.TabIndex = 7;
            btnPDF.Text = "Imprimir PDF";
            btnPDF.UseVisualStyleBackColor = false;
            btnPDF.Click += btnPDF_Click;
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ButtonHighlight;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Id, Numero, Cotizacion, Cliente, Total, Estado, Fecha });
            dgv.Location = new Point(27, 117);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(960, 546);
            dgv.TabIndex = 19;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Numero
            // 
            Numero.FillWeight = 12F;
            Numero.HeaderText = "N° Factura";
            Numero.MinimumWidth = 6;
            Numero.Name = "Numero";
            Numero.Width = 125;
            // 
            // Cotizacion
            // 
            Cotizacion.FillWeight = 12F;
            Cotizacion.HeaderText = "Cotizacion";
            Cotizacion.MinimumWidth = 6;
            Cotizacion.Name = "Cotizacion";
            Cotizacion.Width = 125;
            // 
            // Cliente
            // 
            Cliente.FillWeight = 25F;
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.Width = 125;
            // 
            // Total
            // 
            Total.FillWeight = 16F;
            Total.HeaderText = "Total (IVA inc.)";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.Width = 125;
            // 
            // Estado
            // 
            Estado.FillWeight = 12F;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // Fecha
            // 
            Fecha.FillWeight = 14F;
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // PanelFacturas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgv);
            Controls.Add(lblTit);
            Controls.Add(btnEstado);
            Controls.Add(btnPDF);
            Controls.Add(pnlFiltros);
            Name = "PanelFacturas";
            Size = new Size(1028, 689);
            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlFiltros;
        private TextBox txtFiltroCliente;
        private ComboBox cmbFiltroEstado;
        private Button btnFiltrar;
        private Button btnLimpiar;
        private Label lblTit;
        private Button btnEstado;
        private Button btnPDF;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Cotizacion;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Fecha;
    }
}
