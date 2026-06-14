namespace Sistema_de_Calculo.VISTA
{
    partial class PanelCliente
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
            pnlTop = new Panel();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnNuevo = new Button();
            dgv = new DataGridView();
            lblTit = new Label();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Identificacion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            FechaRegistro = new DataGridViewTextBoxColumn();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(txtBuscar);
            pnlTop.Controls.Add(btnBuscar);
            pnlTop.Controls.Add(btnNuevo);
            pnlTop.Location = new Point(31, 53);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(860, 36);
            pnlTop.TabIndex = 5;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(0, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por nombre o identificación…";
            txtBuscar.Size = new Size(300, 27);
            txtBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.FromArgb(60, 60, 60);
            btnBuscar.Location = new Point(308, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 28);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(24, 95, 165);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(680, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(130, 28);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "+ Nuevo cliente";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.ColumnHeadersHeight = 30;
            dgv.GridColor = Color.FromArgb(230, 230, 230);
            dgv.Location = new Point(31, 97);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 28;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(860, 480);
            dgv.TabIndex = 6;
            // 
            // lblTit
            // 
            lblTit.AutoSize = true;
            lblTit.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTit.ForeColor = Color.FromArgb(30, 30, 30);
            lblTit.Location = new Point(3, 7);
            lblTit.Name = "lblTit";
            lblTit.Size = new Size(95, 30);
            lblTit.TabIndex = 7;
            lblTit.Text = "Clientes";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Identificacion, Telefono, Correo, FechaRegistro });
            dataGridView1.Location = new Point(31, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(860, 405);
            dataGridView1.TabIndex = 8;
            // 
            // Id
            // 
            Id.FillWeight = 5F;
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Nombre
            // 
            Nombre.FillWeight = 28F;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Identificacion
            // 
            Identificacion.FillWeight = 18F;
            Identificacion.HeaderText = "Identificacion";
            Identificacion.MinimumWidth = 6;
            Identificacion.Name = "Identificacion";
            Identificacion.Width = 125;
            // 
            // Telefono
            // 
            Telefono.FillWeight = 16F;
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Width = 125;
            // 
            // Correo
            // 
            Correo.FillWeight = 22F;
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.Width = 125;
            // 
            // FechaRegistro
            // 
            FechaRegistro.FillWeight = 13F;
            FechaRegistro.HeaderText = "Fecha Registro";
            FechaRegistro.MinimumWidth = 6;
            FechaRegistro.Name = "FechaRegistro";
            FechaRegistro.Width = 125;
            // 
            // PanelCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(lblTit);
            Controls.Add(pnlTop);
            Controls.Add(dgv);
            Name = "PanelCliente";
            Size = new Size(1206, 673);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTop;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnNuevo;
        private DataGridView dgv;
        private Label lblTit;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Identificacion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn FechaRegistro;
    }
}
