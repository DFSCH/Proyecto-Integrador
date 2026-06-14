namespace Sistema_de_Calculo.VISTA
{
    partial class PanelNuevaCotizacion
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
            cmbCliente = new ComboBox();
            txtVolumen = new TextBox();
            cmbMaterial = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblCostoEstimado = new Label();
            SuspendLayout();
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(78, 77);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(209, 28);
            cmbCliente.TabIndex = 0;
            // 
            // txtVolumen
            // 
            txtVolumen.Location = new Point(78, 131);
            txtVolumen.Name = "txtVolumen";
            txtVolumen.Size = new Size(209, 27);
            txtVolumen.TabIndex = 1;
            // 
            // cmbMaterial
            // 
            cmbMaterial.FormattingEnabled = true;
            cmbMaterial.Location = new Point(78, 184);
            cmbMaterial.Name = "cmbMaterial";
            cmbMaterial.Size = new Size(209, 28);
            cmbMaterial.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 54);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 3;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 108);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 4;
            label2.Text = "Volumen (m³) ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 161);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 5;
            label3.Text = "Material";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 19);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 6;
            label4.Text = "Nueva Cotizacion";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(24, 95, 165);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(119, 284);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(80, 35);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(60, 60, 60);
            btnCancelar.Location = new Point(205, 284);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 34);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblCostoEstimado
            // 
            lblCostoEstimado.AutoSize = true;
            lblCostoEstimado.Location = new Point(78, 244);
            lblCostoEstimado.Name = "lblCostoEstimado";
            lblCostoEstimado.Size = new Size(33, 20);
            lblCostoEstimado.TabIndex = 10;
            lblCostoEstimado.Text = "----";
            // 
            // PanelNuevaCotizacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCostoEstimado);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbMaterial);
            Controls.Add(txtVolumen);
            Controls.Add(cmbCliente);
            Name = "PanelNuevaCotizacion";
            Size = new Size(418, 390);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCliente;
        private TextBox txtVolumen;
        private ComboBox cmbMaterial;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblCostoEstimado;
    }
}
