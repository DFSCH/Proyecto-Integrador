namespace Sistema_de_Calculo.VIEW
{
    partial class FormNewClient
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
            btnEliminar = new Button();
            btnGuardar = new Button();
            txtCorreo = new TextBox();
            lblCorreo = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtId = new TextBox();
            lblIdentificacion = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(151, 282);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(24, 95, 165);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(42, 282);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(42, 218);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(254, 27);
            txtCorreo.TabIndex = 17;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(42, 195);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(54, 20);
            lblCorreo.TabIndex = 16;
            lblCorreo.Text = "Correo";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(42, 168);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(254, 27);
            txtTelefono.TabIndex = 15;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(42, 145);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 14;
            lblTelefono.Text = "Telefono";
            // 
            // txtId
            // 
            txtId.Location = new Point(42, 120);
            txtId.Name = "txtId";
            txtId.Size = new Size(254, 27);
            txtId.TabIndex = 13;
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(42, 97);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(103, 20);
            lblIdentificacion.TabIndex = 12;
            lblIdentificacion.Text = "Identificacion ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(42, 69);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(254, 27);
            txtNombre.TabIndex = 11;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(42, 46);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // FormNewClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 450);
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
            Name = "FormNewClient";
            Text = "FormNewClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnGuardar;
        private TextBox txtCorreo;
        private Label lblCorreo;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtId;
        private Label lblIdentificacion;
        private TextBox txtNombre;
        private Label lblNombre;
    }
}