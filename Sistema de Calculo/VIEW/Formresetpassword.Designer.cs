namespace Sistema_de_Calculo.VIEW
{
    partial class Formresetpassword
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
            btnVerClave = new Button();
            lblError = new Label();
            txtNuevaContra = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // btnVerClave
            // 
            btnVerClave.Cursor = Cursors.Hand;
            btnVerClave.Location = new Point(322, 98);
            btnVerClave.Name = "btnVerClave";
            btnVerClave.Size = new Size(37, 29);
            btnVerClave.TabIndex = 11;
            btnVerClave.Text = "👁️";
            btnVerClave.UseVisualStyleBackColor = true;
            btnVerClave.Click += btnVerClave_Click_1;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(55, 141);
            lblError.Name = "lblError";
            lblError.Size = new Size(380, 20);
            lblError.TabIndex = 10;
            lblError.Text = "Mín. 8 caracteres, mayúscula, número y carácter especial";
            // 
            // txtNuevaContra
            // 
            txtNuevaContra.Location = new Point(90, 100);
            txtNuevaContra.Name = "txtNuevaContra";
            txtNuevaContra.Size = new Size(214, 27);
            txtNuevaContra.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 77);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 8;
            label1.Text = "Nueva Contraseña";
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.System;
            btnCancelar.Location = new Point(103, 164);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(24, 95, 165);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(210, 164);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Formresetpassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 292);
            Controls.Add(btnVerClave);
            Controls.Add(lblError);
            Controls.Add(txtNuevaContra);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Name = "Formresetpassword";
            Text = "Formresetpassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerClave;
        private Label lblError;
        private TextBox txtNuevaContra;
        private Label label1;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}