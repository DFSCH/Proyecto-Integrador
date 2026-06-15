namespace Sistema_de_Calculo.VISTA
{
    partial class PanelVolume
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            card4 = new Panel();
            lblCard4 = new Label();
            card2 = new Panel();
            lblCard2 = new Label();
            cmbMetodo = new ComboBox();
            btnCalcular = new Button();
            card3 = new Panel();
            lblCard3 = new Label();
            lblResultado = new Label();
            btnUsarEnCot = new Button();
            card1 = new Panel();
            lblCard1 = new Label();
            lblX = new Label();
            txtX = new TextBox();
            lblY = new Label();
            txtY = new TextBox();
            lblZ = new Label();
            txtZ = new TextBox();
            btnAgregar = new Button();
            dgvPuntos = new DataGridView();
            colX = new DataGridViewTextBoxColumn();
            colY = new DataGridViewTextBoxColumn();
            colZ = new DataGridViewTextBoxColumn();
            btnEliminar = new Button();
            lblTit = new Label();
            card4.SuspendLayout();
            card2.SuspendLayout();
            card3.SuspendLayout();
            card1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuntos).BeginInit();
            SuspendLayout();
            // 
            // card4
            // 
            card4.BackColor = Color.White;
            card4.Controls.Add(lblCard4);
            card4.Location = new Point(438, 68);
            card4.Name = "card4";
            card4.Size = new Size(804, 600);
            card4.TabIndex = 6;
            // 
            // lblCard4
            // 
            lblCard4.AutoSize = true;
            lblCard4.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCard4.ForeColor = Color.FromArgb(50, 50, 50);
            lblCard4.Location = new Point(14, 10);
            lblCard4.Name = "lblCard4";
            lblCard4.Size = new Size(177, 21);
            lblCard4.TabIndex = 0;
            lblCard4.Text = "Gráfica 3D del terreno";
            // 
            // card2
            // 
            card2.BackColor = Color.White;
            card2.Controls.Add(lblCard2);
            card2.Controls.Add(cmbMetodo);
            card2.Controls.Add(btnCalcular);
            card2.Location = new Point(8, 412);
            card2.Name = "card2";
            card2.Size = new Size(410, 141);
            card2.TabIndex = 8;
            // 
            // lblCard2
            // 
            lblCard2.AutoSize = true;
            lblCard2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCard2.ForeColor = Color.FromArgb(50, 50, 50);
            lblCard2.Location = new Point(14, 10);
            lblCard2.Name = "lblCard2";
            lblCard2.Size = new Size(147, 21);
            lblCard2.TabIndex = 2;
            lblCard2.Text = "Método numérico";
            // 
            // cmbMetodo
            // 
            cmbMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodo.Items.AddRange(new object[] { "Simpson 1/3 doble", "Trapezoidal compuesto", "Riemann (suma)" });
            cmbMetodo.Location = new Point(14, 46);
            cmbMetodo.Name = "cmbMetodo";
            cmbMetodo.Size = new Size(220, 28);
            cmbMetodo.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(24, 95, 165);
            btnCalcular.Cursor = Cursors.Hand;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(244, 42);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(150, 34);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular volumen";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // card3
            // 
            card3.BackColor = Color.White;
            card3.Controls.Add(lblCard3);
            card3.Controls.Add(lblResultado);
            card3.Controls.Add(btnUsarEnCot);
            card3.Location = new Point(8, 559);
            card3.Name = "card3";
            card3.Size = new Size(410, 109);
            card3.TabIndex = 9;
            // 
            // lblCard3
            // 
            lblCard3.AutoSize = true;
            lblCard3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCard3.ForeColor = Color.FromArgb(50, 50, 50);
            lblCard3.Location = new Point(14, 10);
            lblCard3.Name = "lblCard3";
            lblCard3.Size = new Size(86, 21);
            lblCard3.TabIndex = 2;
            lblCard3.Text = "Resultado";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblResultado.ForeColor = Color.FromArgb(24, 95, 165);
            lblResultado.Location = new Point(14, 40);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(48, 41);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "—";
            // 
            // btnUsarEnCot
            // 
            btnUsarEnCot.BackColor = Color.FromArgb(24, 95, 165);
            btnUsarEnCot.Cursor = Cursors.Hand;
            btnUsarEnCot.Enabled = false;
            btnUsarEnCot.FlatAppearance.BorderSize = 0;
            btnUsarEnCot.FlatStyle = FlatStyle.Flat;
            btnUsarEnCot.ForeColor = Color.White;
            btnUsarEnCot.Location = new Point(236, 40);
            btnUsarEnCot.Name = "btnUsarEnCot";
            btnUsarEnCot.Size = new Size(158, 37);
            btnUsarEnCot.TabIndex = 1;
            btnUsarEnCot.Text = "Usar en cotización →";
            btnUsarEnCot.UseVisualStyleBackColor = false;
            btnUsarEnCot.Click += btnUsarEnCot_Click;
            // 
            // card1
            // 
            card1.BackColor = Color.White;
            card1.Controls.Add(lblCard1);
            card1.Controls.Add(lblX);
            card1.Controls.Add(txtX);
            card1.Controls.Add(lblY);
            card1.Controls.Add(txtY);
            card1.Controls.Add(lblZ);
            card1.Controls.Add(txtZ);
            card1.Controls.Add(btnAgregar);
            card1.Controls.Add(dgvPuntos);
            card1.Controls.Add(btnEliminar);
            card1.Location = new Point(8, 68);
            card1.Name = "card1";
            card1.Size = new Size(410, 338);
            card1.TabIndex = 7;
            // 
            // lblCard1
            // 
            lblCard1.AutoSize = true;
            lblCard1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCard1.ForeColor = Color.FromArgb(50, 50, 50);
            lblCard1.Location = new Point(14, 10);
            lblCard1.Name = "lblCard1";
            lblCard1.Size = new Size(198, 21);
            lblCard1.TabIndex = 9;
            lblCard1.Text = "Coordenadas del terreno";
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.ForeColor = Color.Gray;
            lblX.Location = new Point(14, 44);
            lblX.Name = "lblX";
            lblX.Size = new Size(45, 20);
            lblX.TabIndex = 0;
            lblX.Text = "X (m)";
            // 
            // txtX
            // 
            txtX.BorderStyle = BorderStyle.FixedSingle;
            txtX.Location = new Point(14, 62);
            txtX.Name = "txtX";
            txtX.Size = new Size(80, 27);
            txtX.TabIndex = 1;
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.ForeColor = Color.Gray;
            lblY.Location = new Point(102, 44);
            lblY.Name = "lblY";
            lblY.Size = new Size(44, 20);
            lblY.TabIndex = 2;
            lblY.Text = "Y (m)";
            // 
            // txtY
            // 
            txtY.BorderStyle = BorderStyle.FixedSingle;
            txtY.Location = new Point(102, 62);
            txtY.Name = "txtY";
            txtY.Size = new Size(80, 27);
            txtY.TabIndex = 3;
            // 
            // lblZ
            // 
            lblZ.AutoSize = true;
            lblZ.ForeColor = Color.Gray;
            lblZ.Location = new Point(190, 44);
            lblZ.Name = "lblZ";
            lblZ.Size = new Size(45, 20);
            lblZ.TabIndex = 4;
            lblZ.Text = "Z (m)";
            // 
            // txtZ
            // 
            txtZ.BorderStyle = BorderStyle.FixedSingle;
            txtZ.Location = new Point(190, 62);
            txtZ.Name = "txtZ";
            txtZ.Size = new Size(80, 27);
            txtZ.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(24, 95, 165);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(280, 60);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(110, 28);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "+ Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvPuntos
            // 
            dgvPuntos.AllowUserToAddRows = false;
            dgvPuntos.BackgroundColor = Color.White;
            dgvPuntos.ColumnHeadersHeight = 26;
            dgvPuntos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPuntos.Columns.AddRange(new DataGridViewColumn[] { colX, colY, colZ });
            dgvPuntos.GridColor = Color.FromArgb(230, 230, 230);
            dgvPuntos.Location = new Point(14, 96);
            dgvPuntos.Name = "dgvPuntos";
            dgvPuntos.ReadOnly = true;
            dgvPuntos.RowHeadersWidth = 51;
            dgvPuntos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPuntos.Size = new Size(376, 190);
            dgvPuntos.TabIndex = 7;
            // 
            // colX
            // 
            colX.HeaderText = "X (m)";
            colX.MinimumWidth = 6;
            colX.Name = "colX";
            colX.ReadOnly = true;
            colX.Width = 90;
            // 
            // colY
            // 
            colY.HeaderText = "Y (m)";
            colY.MinimumWidth = 6;
            colY.Name = "colY";
            colY.ReadOnly = true;
            colY.Width = 90;
            // 
            // colZ
            // 
            colZ.HeaderText = "Z (m)";
            colZ.MinimumWidth = 6;
            colZ.Name = "colZ";
            colZ.ReadOnly = true;
            colZ.Width = 90;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.FromArgb(60, 60, 60);
            btnEliminar.Location = new Point(12, 292);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(170, 28);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar seleccionado";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblTit
            // 
            lblTit.AutoSize = true;
            lblTit.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTit.ForeColor = Color.FromArgb(30, 30, 30);
            lblTit.Location = new Point(8, 23);
            lblTit.Name = "lblTit";
            lblTit.Size = new Size(427, 30);
            lblTit.TabIndex = 10;
            lblTit.Text = "Cálculo de volumen — integrales dobles";
            // 
            // PanelVolumen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTit);
            Controls.Add(card2);
            Controls.Add(card3);
            Controls.Add(card1);
            Controls.Add(card4);
            Name = "PanelVolumen";
            Size = new Size(1273, 711);
            card4.ResumeLayout(false);
            card4.PerformLayout();
            card2.ResumeLayout(false);
            card2.PerformLayout();
            card3.ResumeLayout(false);
            card3.PerformLayout();
            card1.ResumeLayout(false);
            card1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPuntos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel card4;
        private Label lblCard4;
        private Panel card2;
        private Label lblCard2;
        private ComboBox cmbMetodo;
        private Button btnCalcular;
        private Panel card3;
        private Label lblCard3;
        private Label lblResultado;
        private Button btnUsarEnCot;
        private Panel card1;
        private Label lblCard1;
        private Label lblX;
        private TextBox txtX;
        private Label lblY;
        private TextBox txtY;
        private Label lblZ;
        private TextBox txtZ;
        private Button btnAgregar;
        private DataGridView dgvPuntos;
        private DataGridViewTextBoxColumn colX;
        private DataGridViewTextBoxColumn colY;
        private DataGridViewTextBoxColumn colZ;
        private Button btnEliminar;
        private Label lblTit;
    }
}
