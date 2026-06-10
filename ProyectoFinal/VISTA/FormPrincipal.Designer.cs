namespace ProyectoFinal
{
    partial class FormPrincipal
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
            panel1 = new Panel();
            btnGestionUsuarios = new Button();
            btnClientes = new Button();
            btnMateriales = new Button();
            btnCalcularVolumen = new Button();
            button1 = new Button();
            button2 = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(913, 125);
            panel1.TabIndex = 0;
            // 
            // btnGestionUsuarios
            // 
            btnGestionUsuarios.Location = new Point(39, 163);
            btnGestionUsuarios.Name = "btnGestionUsuarios";
            btnGestionUsuarios.Size = new Size(153, 29);
            btnGestionUsuarios.TabIndex = 1;
            btnGestionUsuarios.Text = "Usuarios";
            btnGestionUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(39, 198);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(153, 29);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnMateriales
            // 
            btnMateriales.Location = new Point(39, 233);
            btnMateriales.Name = "btnMateriales";
            btnMateriales.Size = new Size(153, 29);
            btnMateriales.TabIndex = 3;
            btnMateriales.Text = "Materiales";
            btnMateriales.UseVisualStyleBackColor = true;
            // 
            // btnCalcularVolumen
            // 
            btnCalcularVolumen.Location = new Point(39, 268);
            btnCalcularVolumen.Name = "btnCalcularVolumen";
            btnCalcularVolumen.Size = new Size(153, 29);
            btnCalcularVolumen.TabIndex = 4;
            btnCalcularVolumen.Text = "Calcular Volumen";
            btnCalcularVolumen.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(39, 303);
            button1.Name = "button1";
            button1.Size = new Size(153, 29);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(39, 338);
            button2.Name = "button2";
            button2.Size = new Size(153, 29);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(39, 373);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(153, 29);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "ñ";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(913, 564);
            Controls.Add(btnSalir);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCalcularVolumen);
            Controls.Add(btnMateriales);
            Controls.Add(btnClientes);
            Controls.Add(btnGestionUsuarios);
            Controls.Add(panel1);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnGestionUsuarios;
        private Button btnClientes;
        private Button btnMateriales;
        private Button btnCalcularVolumen;
        private Button button1;
        private Button button2;
        private Button btnSalir;
    }
}