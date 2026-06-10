using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal.MODELO
{
    public class Usuario
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Cargo { get; set; } 
        public string Contrasena { get; set; }
        public string Telefono { get; set; } 
        public bool Estado { get; set; } 
    }
}
