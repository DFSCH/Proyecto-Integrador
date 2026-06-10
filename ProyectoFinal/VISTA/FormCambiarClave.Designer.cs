namespace ProyectoFinal
{
    partial class FormCambiarClave
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
            lblTitulo = new Label();
            lblActual = new Label();
            txtActual = new TextBox();
            label3 = new Label();
            txtNueva = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtConfirmar = new TextBox();
            label4 = new Label();
            chkMostrar = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(487, 125);
            panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(145, 48);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(105, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cambiar Clave";
            // 
            // lblActual
            // 
            lblActual.AutoSize = true;
            lblActual.Location = new Point(34, 157);
            lblActual.Name = "lblActual";
            lblActual.Size = new Size(129, 20);
            lblActual.TabIndex = 1;
            lblActual.Text = "Contraseña Actual";
            // 
            // txtActual
            // 
            txtActual.Location = new Point(206, 157);
            txtActual.Name = "txtActual";
            txtActual.Size = new Size(125, 27);
            txtActual.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 198);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 3;
            label3.Text = "Nueva Contraseña";
            // 
            // txtNueva
            // 
            txtNueva.Location = new Point(206, 195);
            txtNueva.Name = "txtNueva";
            txtNueva.Size = new Size(125, 27);
            txtNueva.TabIndex = 4;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(51, 336);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(220, 336);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(206, 232);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.Size = new Size(125, 27);
            txtConfirmar.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 235);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 7;
            label4.Text = "Confirmar Contraseña";
            // 
            // chkMostrar
            // 
            chkMostrar.AutoSize = true;
            chkMostrar.Location = new Point(337, 201);
            chkMostrar.Name = "chkMostrar";
            chkMostrar.Size = new Size(18, 17);
            chkMostrar.TabIndex = 9;
            chkMostrar.UseVisualStyleBackColor = true;
            // 
            // FormCambiarClave
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(430, 400);
            Controls.Add(chkMostrar);
            Controls.Add(txtConfirmar);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtNueva);
            Controls.Add(label3);
            Controls.Add(txtActual);
            Controls.Add(lblActual);
            Controls.Add(panel1);
            Name = "FormCambiarClave";
            Text = "FormCambiarClave";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private Label lblActual;
        private TextBox txtActual;
        private Label label3;
        private TextBox txtNueva;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtConfirmar;
        private Label label4;
        private CheckBox chkMostrar;
    }
}