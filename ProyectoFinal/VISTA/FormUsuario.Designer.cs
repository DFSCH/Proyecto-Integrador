namespace ProyectoFinal
{
    partial class FormUsuario
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
            label1 = new Label();
            btnCambiarClave = new Button();
            lblBienvenida = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 39);
            label1.Name = "label1";
            label1.Size = new Size(146, 41);
            label1.TabIndex = 0;
            label1.Text = "USUARIO";
            // 
            // btnCambiarClave
            // 
            btnCambiarClave.Location = new Point(576, 400);
            btnCambiarClave.Name = "btnCambiarClave";
            btnCambiarClave.Size = new Size(159, 29);
            btnCambiarClave.TabIndex = 1;
            btnCambiarClave.Text = "Cambiar Clave";
            btnCambiarClave.UseVisualStyleBackColor = true;
            btnCambiarClave.Click += btnCambiarClave_Click;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(343, 147);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(55, 20);
            lblBienvenida.TabIndex = 2;
            lblBienvenida.Text = "llegate";
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBienvenida);
            Controls.Add(btnCambiarClave);
            Controls.Add(panel1);
            Name = "FormUsuario";
            Text = "FormUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnCambiarClave;
        private Label lblBienvenida;
    }
}