namespace Sistema_de_Calculo
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
            lblTitulo = new Label();
            lblSub = new Label();
            pnlCard = new Panel();
            btnVerClave = new Button();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblPw = new Label();
            txtPw = new TextBox();
            lblError = new Label();
            btnLogin = new Button();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitulo.Location = new Point(211, 79);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(213, 35);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "GeoVolumen Pro";
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.ForeColor = Color.Gray;
            lblSub.Location = new Point(154, 114);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(310, 20);
            lblSub.TabIndex = 5;
            lblSub.Text = "Sistema de Cotización · Movimiento de Tierra";
         
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(btnVerClave);
            pnlCard.Controls.Add(lblCorreo);
            pnlCard.Controls.Add(txtCorreo);
            pnlCard.Controls.Add(lblPw);
            pnlCard.Controls.Add(txtPw);
            pnlCard.Controls.Add(lblError);
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Location = new Point(93, 183);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(437, 337);
            pnlCard.TabIndex = 6;
            // 
            // btnVerClave
            // 
            btnVerClave.Location = new Point(395, 102);
            btnVerClave.Name = "btnVerClave";
            btnVerClave.Size = new Size(26, 29);
            btnVerClave.TabIndex = 6;
            btnVerClave.Text = "👁️";
            btnVerClave.UseVisualStyleBackColor = true;
            btnVerClave.Click += btnVerClave_Click;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.ForeColor = Color.Gray;
            lblCorreo.Location = new Point(20, 22);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(132, 20);
            lblCorreo.TabIndex = 0;
            lblCorreo.Text = "Correo electrónico";
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Location = new Point(20, 42);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(358, 27);
            txtCorreo.TabIndex = 1;
            // 
            // lblPw
            // 
            lblPw.AutoSize = true;
            lblPw.ForeColor = Color.Gray;
            lblPw.Location = new Point(20, 82);
            lblPw.Name = "lblPw";
            lblPw.Size = new Size(83, 20);
            lblPw.TabIndex = 2;
            lblPw.Text = "Contraseña";
            // 
            // txtPw
            // 
            txtPw.BorderStyle = BorderStyle.FixedSingle;
            txtPw.Location = new Point(20, 102);
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(358, 27);
            txtPw.TabIndex = 3;
            txtPw.UseSystemPasswordChar = true;
            // 
            // lblError
            // 
            lblError.BackColor = Color.FromArgb(252, 235, 235);
            lblError.ForeColor = Color.FromArgb(163, 45, 45);
            lblError.Location = new Point(20, 174);
            lblError.Name = "lblError";
            lblError.Padding = new Padding(6, 4, 6, 4);
            lblError.Size = new Size(358, 51);
            lblError.TabIndex = 4;
            lblError.Visible = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(24, 95, 165);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(68, 242);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 36);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 595);
            Controls.Add(lblTitulo);
            Controls.Add(lblSub);
            Controls.Add(pnlCard);
            Name = "FormLogin";
            Text = "Form1";
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblSub;
        private Panel pnlCard;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblPw;
        private TextBox txtPw;
        private Label lblError;
        private Button btnLogin;
        private Button btnVerClave;
    }
}
