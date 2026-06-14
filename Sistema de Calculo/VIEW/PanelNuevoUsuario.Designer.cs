namespace Sistema_de_Calculo.VISTA
{
    partial class PanelNuevoUsuario
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
            btnCancelar = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            label2 = new Label();
            txtContraseña = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cmbCargo = new ComboBox();
            btnGuardar = new Button();
            btnVerClave = new Button();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(234, 314);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 38);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre Completo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(56, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(272, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(56, 116);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(272, 27);
            txtCorreo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 93);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 4;
            label2.Text = "Correo Eletronico";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(56, 173);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(272, 27);
            txtContraseña.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 150);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 6;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 209);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 8;
            label4.Text = "Cargo";
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "Usuario", "Admin" });
            cmbCargo.Location = new Point(56, 232);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(272, 28);
            cmbCargo.TabIndex = 9;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(24, 95, 165);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(148, 314);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(80, 26);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnVerClave
            // 
            btnVerClave.Cursor = Cursors.Hand;
            btnVerClave.Location = new Point(334, 173);
            btnVerClave.Name = "btnVerClave";
            btnVerClave.Size = new Size(37, 29);
            btnVerClave.TabIndex = 11;
            btnVerClave.Text = "👁️";
            btnVerClave.UseVisualStyleBackColor = true;
            btnVerClave.Click += btnVerClave_Click;
            // 
            // PanelNuevoUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnVerClave);
            Controls.Add(btnGuardar);
            Controls.Add(cmbCargo);
            Controls.Add(label4);
            Controls.Add(txtContraseña);
            Controls.Add(label3);
            Controls.Add(txtCorreo);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Name = "PanelNuevoUsuario";
            Size = new Size(428, 412);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnCancelar;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private Label label2;
        private TextBox txtContraseña;
        private Label label3;
        private Label label4;
        private ComboBox cmbCargo;
        private Button btnGuardar;
        private Button btnVerClave;
    }
}
