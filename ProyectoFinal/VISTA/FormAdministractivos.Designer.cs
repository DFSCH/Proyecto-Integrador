namespace ProyectoFinal
{
    partial class FormAdministractivos
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
            dgvUsuarios = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NOMBRE = new DataGridViewTextBoxColumn();
            TELEFONO = new DataGridViewTextBoxColumn();
            CORREO = new DataGridViewTextBoxColumn();
            CARGO = new DataGridViewTextBoxColumn();
            ESTADO = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnRestablecerClave = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            btnActualizar = new Button();
            btnCambiarestado = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
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
            panel1.Size = new Size(952, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 44);
            label1.Name = "label1";
            label1.Size = new Size(633, 41);
            label1.TabIndex = 0;
            label1.Text = "GESTION DE USUARIOS - ADMINISTRACTIVO";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { ID, NOMBRE, TELEFONO, CORREO, CARGO, ESTADO });
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(3, 23);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(757, 236);
            dgvUsuarios.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE";
            NOMBRE.MinimumWidth = 6;
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Width = 125;
            // 
            // TELEFONO
            // 
            TELEFONO.HeaderText = "TELEFONO";
            TELEFONO.MinimumWidth = 6;
            TELEFONO.Name = "TELEFONO";
            TELEFONO.Width = 125;
            // 
            // CORREO
            // 
            CORREO.HeaderText = "CORREO";
            CORREO.MinimumWidth = 6;
            CORREO.Name = "CORREO";
            CORREO.Width = 125;
            // 
            // CARGO
            // 
            CARGO.HeaderText = "CARGO";
            CARGO.MinimumWidth = 6;
            CARGO.Name = "CARGO";
            CARGO.Width = 125;
            // 
            // ESTADO
            // 
            ESTADO.HeaderText = "ESTADO";
            ESTADO.MinimumWidth = 6;
            ESTADO.Name = "ESTADO";
            ESTADO.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvUsuarios);
            groupBox1.Location = new Point(12, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(763, 262);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btnRestablecerClave);
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(txtBuscar);
            groupBox2.Controls.Add(btnActualizar);
            groupBox2.Controls.Add(btnCambiarestado);
            groupBox2.Location = new Point(801, 166);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(268, 226);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // btnRestablecerClave
            // 
            btnRestablecerClave.Location = new Point(25, 101);
            btnRestablecerClave.Name = "btnRestablecerClave";
            btnRestablecerClave.Size = new Size(198, 29);
            btnRestablecerClave.TabIndex = 4;
            btnRestablecerClave.Text = "Restablecer Clave";
            btnRestablecerClave.UseVisualStyleBackColor = true;
            btnRestablecerClave.Click += btnRestablecerClave_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(223, 178);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(39, 29);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "🔍";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(25, 180);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(196, 27);
            txtBuscar.TabIndex = 2;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(25, 66);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(198, 29);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "🔄️ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCambiarestado
            // 
            btnCambiarestado.Location = new Point(25, 31);
            btnCambiarestado.Name = "btnCambiarestado";
            btnCambiarestado.Size = new Size(198, 29);
            btnCambiarestado.TabIndex = 0;
            btnCambiarestado.Text = "CAMBIAR ESTADO A/I";
            btnCambiarestado.UseVisualStyleBackColor = true;
            btnCambiarestado.Click += btnCambiarestado_Click;
            // 
            // button1
            // 
            button1.Location = new Point(25, 136);
            button1.Name = "button1";
            button1.Size = new Size(198, 29);
            button1.TabIndex = 5;
            button1.Text = "Cambiar Rol";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormAdministractivos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1069, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FormAdministractivos";
            Text = "Administractivos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dgvUsuarios;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnActualizar;
        private Button btnCambiarestado;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn TELEFONO;
        private DataGridViewTextBoxColumn CORREO;
        private DataGridViewTextBoxColumn CARGO;
        private DataGridViewTextBoxColumn ESTADO;
        private Button btnRestablecerClave;
        private Button button1;
    }
}