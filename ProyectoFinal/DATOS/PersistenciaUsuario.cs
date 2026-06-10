using ProyectoFinal.MODELO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProyectoFinal.DATOS
{
    public class PersistenciaUsuario
    {
        private string rutaArchivo = "usuarios.csv";

        public PersistenciaUsuario()
        {
            // Si el archivo no existe, lo crea con la cabecera incluyendo Teléfono
            if (!File.Exists(rutaArchivo))
            {
                // Agregamos ';Telefono' antes del estado para mantener orden
                File.WriteAllText(rutaArchivo, "ID;Nombre;Telefono;Correo;Cargo;Contrasena;Estado\n");
            }
        }

        // RF08: Consultar la lista de usuarios registrados
        public List<Usuario> LeerTodos()
        {
            var lista = new List<Usuario>();
            if (!File.Exists(rutaArchivo)) return lista;

            var lineas = File.ReadAllLines(rutaArchivo).Skip(1); // Saltamos la cabecera

            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                var datos = linea.Split(';');

                // Mapeo controlando los índices con la nueva columna agregada
                lista.Add(new Usuario
                {
                    Id = datos[0],
                    Nombre = datos[1],
                    Telefono = datos[2], // ← LEER TELÉFONO
                    Correo = datos[3],
                    Cargo = datos[4],
                    Contrasena = datos[5],
                    Estado = bool.Parse(datos[6])
                });
            }
            return lista;
        }

        // RF01: Registro de usuarios (Con validación de duplicados)
        public bool Guardar(Usuario nuevo)
        {
            var usuarios = LeerTodos();

            // Validación crucial: No duplicar IDs
            if (usuarios.Any(u => u.Id == nuevo.Id))
            {
                return false;
            }

            // ← ESCRIBIR TELÉFONO EN EL CSV
            string nuevaLinea = $"{nuevo.Id};{nuevo.Nombre};{nuevo.Telefono};{nuevo.Correo};{nuevo.Cargo};{nuevo.Contrasena};{nuevo.Estado}";
            File.AppendAllLines(rutaArchivo, new[] { nuevaLinea });
            return true;
        }

        // RF06: Cambiar estado (Activo/Inactivo)
        public void ActualizarEstado(string id, bool nuevoEstado)
        {
            var usuarios = LeerTodos();
            var usuario = usuarios.FirstOrDefault(u => u.Id == id);

            if (usuario != null)
            {
                usuario.Estado = nuevoEstado;
                ReescribirArchivo(usuarios);
            }
        }

        private void ReescribirArchivo(List<Usuario> lista)
        {
            // Mantenemos la cabecera unificada con Teléfono
            var lineas = new List<string> { "ID;Nombre;Telefono;Correo;Cargo;Contrasena;Estado" };
            foreach (var u in lista)
            {
                lineas.Add($"{u.Id};{u.Nombre};{u.Telefono};{u.Correo};{u.Cargo};{u.Contrasena};{u.Estado}");
            }
            File.WriteAllLines(rutaArchivo, lineas);
        }

        public void ActualizarContrasena(string id, string nuevaContrasenaInsegura)
        {
            var usuarios = LeerTodos();
            var usuario = usuarios.FirstOrDefault(u => u.Id == id);

            if (usuario != null)
            {
                // Encriptamos la nueva contraseña antes de salvarla en el CSV
                usuario.Contrasena = BCrypt.Net.BCrypt.HashPassword(nuevaContrasenaInsegura);
                ReescribirArchivo(usuarios);
            }
        }
    }
}