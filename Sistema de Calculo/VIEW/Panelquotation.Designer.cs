namespace Sistema_de_Calculo.VISTA
{
    partial class Panelquotation
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
            lblTit = new Label();
            btnPDF = new Button();
            btnEstado = new Button();
            btnFactura = new Button();
            btnNueva = new Button();
            dgv = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Material = new DataGridViewTextBoxColumn();
            Volumen = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // lblTit
            // 
            lblTit.AutoSize = true;
            lblTit.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTit.ForeColor = Color.FromArgb(30, 30, 30);
            lblTit.Location = new Point(24, 43);
            lblTit.Name = "lblTit";
            lblTit.Size = new Size(143, 30);
            lblTit.TabIndex = 12;
            lblTit.Text = "Cotizaciones";
            // 
            // btnPDF
            // 
            btnPDF.BackColor = Color.White;
            btnPDF.Cursor = Cursors.Hand;
            btnPDF.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnPDF.FlatStyle = FlatStyle.Flat;
            btnPDF.ForeColor = Color.FromArgb(60, 60, 60);
            btnPDF.Location = new Point(174, 43);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(140, 30);
            btnPDF.TabIndex = 13;
            btnPDF.Text = "Imprimir PDF";
            btnPDF.UseVisualStyleBackColor = false;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnEstado
            // 
            btnEstado.BackColor = Color.White;
            btnEstado.Cursor = Cursors.Hand;
            btnEstado.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnEstado.FlatStyle = FlatStyle.Flat;
            btnEstado.ForeColor = Color.FromArgb(60, 60, 60);
            btnEstado.Location = new Point(324, 43);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(130, 30);
            btnEstado.TabIndex = 14;
            btnEstado.Text = "Cambiar estado";
            btnEstado.UseVisualStyleBackColor = false;
            btnEstado.Click += btnEstado_Click;
            // 
            // btnFactura
            // 
            btnFactura.BackColor = Color.White;
            btnFactura.Cursor = Cursors.Hand;
            btnFactura.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnFactura.FlatStyle = FlatStyle.Flat;
            btnFactura.ForeColor = Color.FromArgb(60, 60, 60);
            btnFactura.Location = new Point(464, 43);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(160, 30);
            btnFactura.TabIndex = 15;
            btnFactura.Text = "→ Convertir a factura";
            btnFactura.UseVisualStyleBackColor = false;
            btnFactura.Click += btnFactura_Click;
            // 
            // btnNueva
            // 
            btnNueva.BackColor = Color.FromArgb(24, 95, 165);
            btnNueva.Cursor = Cursors.Hand;
            btnNueva.FlatAppearance.BorderSize = 0;
            btnNueva.FlatStyle = FlatStyle.Flat;
            btnNueva.ForeColor = Color.White;
            btnNueva.Location = new Point(684, 43);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(150, 30);
            btnNueva.TabIndex = 16;
            btnNueva.Text = "+ Nueva cotización";
            btnNueva.UseVisualStyleBackColor = false;
            btnNueva.Click += btnNueva_Click;
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ButtonHighlight;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Id, Numero, Cliente, Material, Volumen, Costo, Estado, Fecha });
            dgv.Location = new Point(24, 97);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(960, 546);
            dgv.TabIndex = 18;
            // 
            // Id
            // 
            Id.FillWeight = 5F;
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Numero
            // 
            Numero.FillWeight = 10F;
            Numero.HeaderText = "Numero";
            Numero.MinimumWidth = 6;
            Numero.Name = "Numero";
            Numero.Width = 125;
            // 
            // Cliente
            // 
            Cliente.FillWeight = 22F;
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.Width = 125;
            // 
            // Material
            // 
            Material.FillWeight = 12F;
            Material.HeaderText = "Material";
            Material.MinimumWidth = 6;
            Material.Name = "Material";
            Material.Width = 125;
            // 
            // Volumen
            // 
            Volumen.FillWeight = 12F;
            Volumen.HeaderText = "Volumen (m³)";
            Volumen.MinimumWidth = 6;
            Volumen.Name = "Volumen";
            Volumen.Width = 125;
            // 
            // Costo
            // 
            Costo.FillWeight = 16F;
            Costo.HeaderText = "Costo Total";
            Costo.MinimumWidth = 6;
            Costo.Name = "Costo";
            Costo.Width = 125;
            // 
            // Estado
            // 
            Estado.FillWeight = 10F;
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
            // PanelCotizacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgv);
            Controls.Add(lblTit);
            Controls.Add(btnPDF);
            Controls.Add(btnEstado);
            Controls.Add(btnFactura);
            Controls.Add(btnNueva);
            Name = "PanelCotizacion";
            Size = new Size(1049, 703);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTit;
        private Button btnPDF;
        private Button btnEstado;
        private Button btnFactura;
        private Button btnNueva;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Material;
        private DataGridViewTextBoxColumn Volumen;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Fecha;
    }
}
