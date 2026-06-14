namespace Sistema_de_Calculo.VISTA
{
    partial class PanelUsuario
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
            btnNuevo = new Button();
            dgv = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            lblTit = new Label();
            btnToggle = new Button();
            btnReset = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(24, 95, 165);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(713, 43);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(132, 34);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo Usuario";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.ButtonHighlight;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Correo, Cargo, Estado, Fecha });
            dgv.Location = new Point(37, 119);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(960, 546);
            dgv.TabIndex = 19;
            // 
            // Id
            // 
            Id.FillWeight = 5F;
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Nombre
            // 
            Nombre.FillWeight = 25F;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Correo
            // 
            Correo.FillWeight = 30F;
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.Width = 125;
            // 
            // Cargo
            // 
            Cargo.FillWeight = 15F;
            Cargo.HeaderText = "Cargo";
            Cargo.MinimumWidth = 6;
            Cargo.Name = "Cargo";
            Cargo.Width = 125;
            // 
            // Estado
            // 
            Estado.FillWeight = 12F;
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // Fecha
            // 
            Fecha.FillWeight = 13F;
            Fecha.HeaderText = "Creado";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // lblTit
            // 
            lblTit.AutoSize = true;
            lblTit.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTit.ForeColor = Color.FromArgb(30, 30, 30);
            lblTit.Location = new Point(37, 43);
            lblTit.Name = "lblTit";
            lblTit.Size = new Size(211, 30);
            lblTit.TabIndex = 20;
            lblTit.Text = "Gestion De Usuario";
            // 
            // btnToggle
            // 
            btnToggle.BackColor = Color.White;
            btnToggle.Cursor = Cursors.Hand;
            btnToggle.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnToggle.FlatStyle = FlatStyle.Flat;
            btnToggle.ForeColor = Color.FromArgb(60, 60, 60);
            btnToggle.Location = new Point(272, 47);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(175, 30);
            btnToggle.TabIndex = 21;
            btnToggle.Text = "Activar / Desactivar";
            btnToggle.UseVisualStyleBackColor = false;
            btnToggle.Click += btnToggle_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.FromArgb(60, 60, 60);
            btnReset.Location = new Point(470, 47);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(172, 30);
            btnReset.TabIndex = 22;
            btnReset.Text = "Resetear contraseña";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(870, 43);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // PanelUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEliminar);
            Controls.Add(lblTit);
            Controls.Add(btnToggle);
            Controls.Add(btnReset);
            Controls.Add(dgv);
            Controls.Add(btnNuevo);
            Name = "PanelUsuario";
            Size = new Size(1162, 737);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private DataGridView dgv;
        private Label lblTit;
        private Button btnToggle;
        private Button btnReset;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Fecha;
        private Button btnEliminar;
    }
}
