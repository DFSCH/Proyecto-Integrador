using ProyectoFinal.CONTROLADOR;
using ProyectoFinal.DATOS;
using ProyectoFinal.MODELO;
using System;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormUsuario : Form
    {
        private readonly Usuario _usuario;
        private readonly UsuarioControlador _ctrl = new UsuarioControlador();

        public FormUsuario(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            lblBienvenida.Text = $"Hola, {_usuario.Nombre}";
        }

        private void btnCambiarClave_Click(object sender, EventArgs e)
        {
            var cambiarClaveForm = new FormCambiarClave(_usuario);
            cambiarClaveForm.FormClosed += (s, args) => this.Show();
            cambiarClaveForm.Show();
            
        }
    }
}