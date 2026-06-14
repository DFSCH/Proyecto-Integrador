namespace Sistema_de_Calculo.VISTA
{
    partial class PanelNuevoCliente
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtId = new TextBox();
            lblIdentificacion = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(81, 43);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(81, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(254, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(81, 117);
            txtId.Name = "txtId";
            txtId.Size = new Size(254, 27);
            txtId.TabIndex = 3;
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(81, 94);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(103, 20);
            lblIdentificacion.TabIndex = 2;
            lblIdentificacion.Text = "Identificacion ";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(81, 165);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(254, 27);
            txtTelefono.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(81, 142);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Telefono";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(81, 215);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(254, 27);
            txtCorreo.TabIndex = 7;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(81, 192);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(54, 20);
            lblCorreo.TabIndex = 6;
            lblCorreo.Text = "Correo";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(24, 95, 165);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(81, 279);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(190, 279);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 6);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 10;
            label1.Text = "Registrar Cliente";
            // 
            // PanelNuevoCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtId);
            Controls.Add(lblIdentificacion);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "PanelNuevoCliente";
            Size = new Size(428, 384);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label lblIdentificacion;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private Button btnGuardar;
        private Button btnEliminar;
        private Label label1;
    }
}
