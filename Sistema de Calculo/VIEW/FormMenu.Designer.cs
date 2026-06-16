namespace Sistema_de_Calculo.VISTA
{
    partial class FormMenu
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
            splitContainer1 = new SplitContainer();
            pnlSidebar = new Panel();
            btnMateriales = new Button();
            btnUsuario = new Button();
            btnFactura = new Button();
            btnCliente = new Button();
            btnCotizacion = new Button();
            btnCalcularVolumen = new Button();
            lblLogo = new Label();
            lblSubApp = new Label();
            sep1 = new Panel();
            sep2 = new Panel();
            pnlPie = new Panel();
            lblUsuario = new Label();
            lblRol = new Label();
            btnCambiarPw = new Button();
            btnLogout = new Button();
            pnlContent = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlPie.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pnlSidebar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pnlContent);
            splitContainer1.Size = new Size(1627, 708);
            splitContainer1.SplitterDistance = 255;
            splitContainer1.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Controls.Add(btnMateriales);
            pnlSidebar.Controls.Add(btnUsuario);
            pnlSidebar.Controls.Add(btnFactura);
            pnlSidebar.Controls.Add(btnCliente);
            pnlSidebar.Controls.Add(btnCotizacion);
            pnlSidebar.Controls.Add(btnCalcularVolumen);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Controls.Add(lblSubApp);
            pnlSidebar.Controls.Add(sep1);
            pnlSidebar.Controls.Add(sep2);
            pnlSidebar.Controls.Add(pnlPie);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Padding = new Padding(0, 8, 0, 8);
            pnlSidebar.Size = new Size(249, 708);
            pnlSidebar.TabIndex = 1;
            // 
            // btnMateriales
            // 
            btnMateriales.Location = new Point(0, 249);
            btnMateriales.Name = "btnMateriales";
            btnMateriales.Size = new Size(249, 39);
            btnMateriales.TabIndex = 10;
            btnMateriales.Text = "\U0001f9f1Materiales";
            btnMateriales.UseVisualStyleBackColor = true;
            btnMateriales.Click += btnMateriales_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.Location = new Point(0, 294);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(249, 39);
            btnUsuario.TabIndex = 9;
            btnUsuario.Text = "🚹Usuario";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnFactura
            // 
            btnFactura.Location = new Point(0, 159);
            btnFactura.Name = "btnFactura";
            btnFactura.Size = new Size(249, 39);
            btnFactura.TabIndex = 8;
            btnFactura.Text = "📜Factura";
            btnFactura.UseVisualStyleBackColor = true;
            btnFactura.Click += btnFactura_Click;
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(0, 204);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(249, 39);
            btnCliente.TabIndex = 7;
            btnCliente.Text = "🙍‍♂️Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnCotizacion
            // 
            btnCotizacion.Location = new Point(0, 114);
            btnCotizacion.Name = "btnCotizacion";
            btnCotizacion.Size = new Size(249, 39);
            btnCotizacion.TabIndex = 6;
            btnCotizacion.Text = "📄Cotizaciones";
            btnCotizacion.UseVisualStyleBackColor = true;
            btnCotizacion.Click += btnCotizacion_Click;
            // 
            // btnCalcularVolumen
            // 
            btnCalcularVolumen.Location = new Point(0, 69);
            btnCalcularVolumen.Name = "btnCalcularVolumen";
            btnCalcularVolumen.Size = new Size(249, 39);
            btnCalcularVolumen.TabIndex = 5;
            btnCalcularVolumen.Text = "📐Calcular Volumen";
            btnCalcularVolumen.UseVisualStyleBackColor = true;
            btnCalcularVolumen.Click += btnCalcularVolumen_Click;
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(30, 30, 30);
            lblLogo.Location = new Point(3, 9);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(210, 28);
            lblLogo.TabIndex = 2;
            lblLogo.Text = "GeoVolumen Pro";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubApp
            // 
            lblSubApp.Font = new Font("Segoe UI", 8F);
            lblSubApp.ForeColor = Color.Gray;
            lblSubApp.Location = new Point(3, 37);
            lblSubApp.Name = "lblSubApp";
            lblSubApp.Size = new Size(210, 18);
            lblSubApp.TabIndex = 3;
            lblSubApp.Text = "Movimiento de Tierra 2026";
            lblSubApp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sep1
            // 
            sep1.BackColor = Color.FromArgb(230, 230, 230);
            sep1.Location = new Point(10, 62);
            sep1.Name = "sep1";
            sep1.Size = new Size(190, 1);
            sep1.TabIndex = 4;
            // 
            // sep2
            // 
            sep2.BackColor = Color.FromArgb(230, 230, 230);
            sep2.Dock = DockStyle.Bottom;
            sep2.Location = new Point(0, 535);
            sep2.Name = "sep2";
            sep2.Size = new Size(249, 1);
            sep2.TabIndex = 1;
            // 
            // pnlPie
            // 
            pnlPie.BackColor = Color.White;
            pnlPie.Controls.Add(lblUsuario);
            pnlPie.Controls.Add(lblRol);
            pnlPie.Controls.Add(btnCambiarPw);
            pnlPie.Controls.Add(btnLogout);
            pnlPie.Dock = DockStyle.Bottom;
            pnlPie.Location = new Point(0, 536);
            pnlPie.Name = "pnlPie";
            pnlPie.Padding = new Padding(10, 8, 10, 8);
            pnlPie.Size = new Size(249, 164);
            pnlPie.TabIndex = 0;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUsuario.Location = new Point(20, 16);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(79, 21);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "(usuario)";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 8.5F);
            lblRol.ForeColor = Color.Gray;
            lblRol.Location = new Point(20, 34);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(59, 20);
            lblRol.TabIndex = 1;
            lblRol.Text = "Usuario";
            // 
            // btnCambiarPw
            // 
            btnCambiarPw.BackColor = Color.FromArgb(245, 247, 250);
            btnCambiarPw.Cursor = Cursors.Hand;
            btnCambiarPw.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnCambiarPw.FlatStyle = FlatStyle.Flat;
            btnCambiarPw.Font = new Font("Segoe UI", 8.5F);
            btnCambiarPw.Location = new Point(20, 57);
            btnCambiarPw.Name = "btnCambiarPw";
            btnCambiarPw.Size = new Size(185, 37);
            btnCambiarPw.TabIndex = 2;
            btnCambiarPw.Text = "🔒 Cambiar contraseña";
            btnCambiarPw.UseVisualStyleBackColor = false;
            btnCambiarPw.Click += btnCambiarPw_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(245, 247, 250);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(20, 100);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(185, 34);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Cerrar sesión";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(245, 247, 250);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(20);
            pnlContent.Size = new Size(1368, 708);
            pnlContent.TabIndex = 2;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1627, 708);
            Controls.Add(splitContainer1);
            Name = "FormMenu";
            Text = "FormMenu";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            pnlPie.ResumeLayout(false);
            pnlPie.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel pnlSidebar;
        private Label lblLogo;
        private Label lblSubApp;
        private Panel sep1;
        private Panel sep2;
        private Panel pnlPie;
        private Label lblUsuario;
        private Label lblRol;
        private Button btnCambiarPw;
        private Button btnLogout;
        private Panel pnlContent;
        private Button btnMateriales;
        private Button btnUsuario;
        private Button btnFactura;
        private Button btnCliente;
        private Button btnCotizacion;
        private Button btnCalcularVolumen;
    }
}