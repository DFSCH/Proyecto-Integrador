namespace Sistema_de_Calculo.VIEW
{
    partial class FormNewUser
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
            btnGuardar = new Button();
            cmbCargo = new ComboBox();
            label4 = new Label();
            txtContraseña = new TextBox();
            label3 = new Label();
            txtCorreo = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnVerClave
            // 
            btnVerClave.Cursor = Cursors.Hand;
            btnVerClave.Location = new Point(347, 194);
            btnVerClave.Name = "btnVerClave";
            btnVerClave.Size = new Size(37, 29);
            btnVerClave.TabIndex = 22;
            btnVerClave.Text = "👁️";
            btnVerClave.UseVisualStyleBackColor = true;
            btnVerClave.Click += btnVerClave_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(24, 95, 165);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(161, 335);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(80, 26);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "Usuario", "Admin" });
            cmbCargo.Location = new Point(69, 253);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(272, 28);
            cmbCargo.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 230);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 19;
            label4.Text = "Cargo";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(69, 194);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(272, 27);
            txtContraseña.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 171);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 17;
            label3.Text = "Contraseña";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(69, 137);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(272, 27);
            txtCorreo.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 114);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 15;
            label2.Text = "Correo Eletronico";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(69, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(272, 27);
            txtNombre.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 59);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 13;
            label1.Text = "Nombre Completo";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(247, 335);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormNewUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 450);
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
            Name = "FormNewUser";
            Text = "FormNewUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerClave;
        private Button btnGuardar;
        private ComboBox cmbCargo;
        private Label label4;
        private TextBox txtContraseña;
        private Label label3;
        private TextBox txtCorreo;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Button btnCancelar;
    }
}