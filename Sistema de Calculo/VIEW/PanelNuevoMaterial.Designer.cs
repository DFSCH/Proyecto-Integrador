namespace Sistema_de_Calculo.VISTA
{
    partial class PanelNuevoMaterial
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtCosto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 53);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo Material";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(110, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(256, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(110, 134);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(256, 27);
            txtCosto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 111);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 2;
            label2.Text = "Costo por m³ (COP)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 15);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 4;
            label3.Text = "Nuevo Material";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(24, 95, 165);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(165, 180);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 30);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(290, 180);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 30);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // PanelNuevoMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(txtCosto);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "PanelNuevoMaterial";
            Size = new Size(504, 348);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtCosto;
        private Label label2;
        private Label label3;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}
