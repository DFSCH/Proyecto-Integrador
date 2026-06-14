namespace Sistema_de_Calculo.VIEW
{
    partial class FormNewMaterial // <-- Corregido a Mayúsculas
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
            txtCosto = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();

            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(234, 202);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 30);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(24, 95, 165);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(110, 202);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 30);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(72, 156);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(256, 27);
            txtCosto.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 133);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 9;
            label2.Text = "Costo por m³ (COP)";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(72, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(256, 27);
            txtNombre.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 75);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 7;
            label1.Text = "Tipo Material";
            // 
            // FormNewMaterial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 337);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtCosto);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FormNewMaterial"; // <-- Corregido
            Text = "FormNewMaterial"; // <-- Corregido
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnGuardar;
        private TextBox txtCosto;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
    }
} // <-- Agregada la llave de cierre que faltaba para el namespace