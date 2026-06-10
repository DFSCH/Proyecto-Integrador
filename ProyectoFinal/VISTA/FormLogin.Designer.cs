namespace ProyectoFinal
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            label3 = new Label();
            txtContraseña = new TextBox();
            btnIngresar = new Button();
            btnRegistrar = new Button();
            btnVisible = new Button();
            lblOlvidoPass = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.SkyBlue;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 105);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(112, 32);
            label1.Name = "label1";
            label1.Size = new Size(239, 41);
            label1.TabIndex = 0;
            label1.Text = "MULTIVARIABLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 170);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 1;
            label2.Text = "ID :";
            // 
            // txtID
            // 
            txtID.Location = new Point(156, 167);
            txtID.Name = "txtID";
            txtID.Size = new Size(167, 27);
            txtID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 206);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 3;
            label3.Text = "CONTRASEÑA :";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(156, 202);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(167, 27);
            txtContraseña.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.GradientActiveCaption;
            btnIngresar.Cursor = Cursors.Hand;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.ForeColor = Color.DarkBlue;
            btnIngresar.Location = new Point(108, 295);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(103, 29);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.ForeColor = Color.DarkBlue;
            btnRegistrar.Location = new Point(229, 295);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVisible
            // 
            btnVisible.Cursor = Cursors.Hand;
            btnVisible.Location = new Point(329, 200);
            btnVisible.Name = "btnVisible";
            btnVisible.Size = new Size(32, 30);
            btnVisible.TabIndex = 7;
            btnVisible.Text = "👁️";
            btnVisible.UseVisualStyleBackColor = true;
            btnVisible.Click += btnVisible_Click;
            // 
            // lblOlvidoPass
            // 
            lblOlvidoPass.AutoSize = true;
            lblOlvidoPass.BackColor = SystemColors.GradientActiveCaption;
            lblOlvidoPass.Cursor = Cursors.Hand;
            lblOlvidoPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblOlvidoPass.ForeColor = Color.DarkBlue;
            lblOlvidoPass.Location = new Point(138, 232);
            lblOlvidoPass.Name = "lblOlvidoPass";
            lblOlvidoPass.Size = new Size(185, 20);
            lblOlvidoPass.TabIndex = 8;
            lblOlvidoPass.Text = "Olvidaste la contraseña?";
            lblOlvidoPass.Click += this.lblOlvidoPass_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(447, 414);
            Controls.Add(lblOlvidoPass);
            Controls.Add(btnVisible);
            Controls.Add(btnRegistrar);
            Controls.Add(btnIngresar);
            Controls.Add(txtContraseña);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtID;
        private Label label3;
        private TextBox txtContraseña;
        private Button btnIngresar;
        private Button btnRegistrar;
        private Button btnVisible;
        private Label lblOlvidoPass;
    }
}
