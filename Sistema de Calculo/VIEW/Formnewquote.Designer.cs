namespace Sistema_de_Calculo.VIEW
{
    partial class Formnewquote
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
            lblCostoEstimado = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbMaterial = new ComboBox();
            txtVolumen = new TextBox();
            cmbCliente = new ComboBox();
            SuspendLayout();
            // 
            // lblCostoEstimado
            // 
            lblCostoEstimado.AutoSize = true;
            lblCostoEstimado.Location = new Point(56, 230);
            lblCostoEstimado.Name = "lblCostoEstimado";
            lblCostoEstimado.Size = new Size(33, 20);
            lblCostoEstimado.TabIndex = 19;
            lblCostoEstimado.Text = "----";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(24, 95, 165);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(97, 270);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(80, 35);
            btnGuardar.TabIndex = 17;
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
            btnCancelar.Location = new Point(183, 270);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(80, 34);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 147);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 16;
            label3.Text = "Material";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 94);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 15;
            label2.Text = "Volumen (m³) ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 40);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 14;
            label1.Text = "Cliente";
            // 
            // cmbMaterial
            // 
            cmbMaterial.FormattingEnabled = true;
            cmbMaterial.Location = new Point(56, 170);
            cmbMaterial.Name = "cmbMaterial";
            cmbMaterial.Size = new Size(209, 28);
            cmbMaterial.TabIndex = 13;
            // 
            // txtVolumen
            // 
            txtVolumen.Location = new Point(56, 117);
            txtVolumen.Name = "txtVolumen";
            txtVolumen.Size = new Size(209, 27);
            txtVolumen.TabIndex = 12;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(56, 63);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(209, 28);
            cmbCliente.TabIndex = 11;
            // 
            // Formnewquote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 450);
            Controls.Add(lblCostoEstimado);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbMaterial);
            Controls.Add(txtVolumen);
            Controls.Add(cmbCliente);
            Name = "Formnewquote";
            Text = "Formnewquote";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCostoEstimado;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbMaterial;
        private TextBox txtVolumen;
        private ComboBox cmbCliente;
    }
}