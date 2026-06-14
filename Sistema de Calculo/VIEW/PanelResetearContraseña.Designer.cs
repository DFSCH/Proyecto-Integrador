namespace Sistema_de_Calculo.VISTA
{
    partial class PanelResetearContraseña
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
            btnGuardar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            txtNuevaContra = new TextBox();
            lblError = new Label();
            btnVerClave = new Button();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(24, 95, 165);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(189, 175);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.System;
            btnCancelar.Location = new Point(82, 175);
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
            label1.Location = new Point(47, 88);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 2;
            label1.Text = "Nueva Contraseña";
            // 
            // txtNuevaContra
            // 
            txtNuevaContra.Location = new Point(69, 111);
            txtNuevaContra.Name = "txtNuevaContra";
            txtNuevaContra.PasswordChar = '*';
            txtNuevaContra.Size = new Size(214, 27);
            txtNuevaContra.TabIndex = 3;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(34, 152);
            lblError.Name = "lblError";
            lblError.Size = new Size(380, 20);
            lblError.TabIndex = 4;
            lblError.Text = "Mín. 8 caracteres, mayúscula, número y carácter especial";
            // 
            // btnVerClave
            // 
            btnVerClave.Cursor = Cursors.Hand;
            btnVerClave.Location = new Point(301, 109);
            btnVerClave.Name = "btnVerClave";
            btnVerClave.Size = new Size(37, 29);
            btnVerClave.TabIndex = 5;
            btnVerClave.Text = "👁️";
            btnVerClave.UseVisualStyleBackColor = true;
            btnVerClave.Click += btnVerClave_Click;
            // 
            // PanelResetearContraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnVerClave);
            Controls.Add(lblError);
            Controls.Add(txtNuevaContra);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Name = "PanelResetearContraseña";
            Size = new Size(441, 341);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnCancelar;
        private Label label1;
        private TextBox txtNuevaContra;
        private Label lblError;
        private Button btnVerClave;
    }
}
