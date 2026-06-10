namespace ProyectoFinal
{
    partial class FormRegistrar
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            txtID = new TextBox();
            txtCorreo = new TextBox();
            cmbCargo = new ComboBox();
            txtContraseña = new TextBox();
            txtConfirmarContraseña = new TextBox();
            groupBox1 = new GroupBox();
            txtTelefono = new TextBox();
            label8 = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            groupBox2 = new GroupBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(125, 41);
            label1.Name = "label1";
            label1.Size = new Size(306, 41);
            label1.TabIndex = 0;
            label1.Text = "REGISTRAR USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 78);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 1;
            label2.Text = "ID: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 44);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 25);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 58);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 4;
            label5.Text = "Cargo: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(96, 92);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 5;
            label6.Text = "Contraseña:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 125);
            label7.Name = "label7";
            label7.Size = new Size(156, 20);
            label7.TabIndex = 6;
            label7.Text = "Confirmar Contraseña:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(205, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(205, 75);
            txtID.Name = "txtID";
            txtID.Size = new Size(151, 27);
            txtID.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(211, 22);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(151, 27);
            txtCorreo.TabIndex = 9;
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "Usuario", "Cliente" });
            cmbCargo.Location = new Point(211, 55);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(151, 28);
            cmbCargo.TabIndex = 10;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(211, 89);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(151, 27);
            txtContraseña.TabIndex = 11;
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.Location = new Point(211, 122);
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.Size = new Size(151, 27);
            txtConfirmarContraseña.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ScrollBar;
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtID);
            groupBox1.Location = new Point(77, 146);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 159);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuario";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(205, 110);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(151, 27);
            txtTelefono.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(96, 113);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 9;
            label8.Text = "Telefono:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.GradientActiveCaption;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.DarkBlue;
            btnGuardar.Location = new Point(124, 502);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(103, 29);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.GradientActiveCaption;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.DarkBlue;
            btnCancelar.Location = new Point(336, 502);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 29);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ScrollBar;
            groupBox2.Controls.Add(txtConfirmarContraseña);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtCorreo);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtContraseña);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cmbCargo);
            groupBox2.Location = new Point(77, 311);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(406, 164);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Correo y Cargo";
            // 
            // FormRegistrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(536, 581);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FormRegistrar";
            Text = "Registrar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNombre;
        private TextBox txtID;
        private TextBox txtCorreo;
        private ComboBox cmbCargo;
        private TextBox txtContraseña;
        private TextBox txtConfirmarContraseña;
        private GroupBox groupBox1;
        private Button btnGuardar;
        private Button btnCancelar;
        private GroupBox groupBox2;
        private TextBox txtTelefono;
        private Label label8;
    }
}