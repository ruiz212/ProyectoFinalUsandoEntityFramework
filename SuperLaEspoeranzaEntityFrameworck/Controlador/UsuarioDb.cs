using SuperLaEspoeranzaEntityFrameworck.Data;
using SuperLaEspoeranzaEntityFrameworck.DOTs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperLaEspoeranzaEntityFrameworck.Controlador
{
    public class UsuarioDb
    {
        SuperLaEsperanzaDbContex SuperLaEsperanzaDbContex = new SuperLaEsperanzaDbContex();


        public string VerificarUsuario(string usuario, string contrasena)
        {
            var usuarioEncontrado = SuperLaEsperanzaDbContex.Usuario
                .FirstOrDefault(u => u.UsuarioNombre == usuario && u.Clave == contrasena);
            if (usuarioEncontrado != null)
            {
                return usuarioEncontrado.Rol;
            }
            else
            {
                return null;
            }

        }


        public void AgregarUsuario(UsuarioDOT usuarioDto)
        {
            var nuevoUsuario = new Models.Usuario
            {
                IdUsuario = usuarioDto.IdUsuario,
                NombreCompleto = usuarioDto.NombreCompleto,
                UsuarioNombre = usuarioDto.UsuarioNombre,
                Clave = usuarioDto.Clave,
                Rol = usuarioDto.Rol,
                Estado = usuarioDto.Estado
            };

            SuperLaEsperanzaDbContex.Usuario.Add(nuevoUsuario);
            // Guardar cambios de forma asíncrona para evitar bloqueos en la interfaz
            SuperLaEsperanzaDbContex.SaveChanges();
            // Si usas WinForms, asegúrate de tener las referencias correctas
            MessageBox.Show("Usuario correctamente agregado", "Exito", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
        public List<UsuarioDOT> ObtenerUsuarios()
        {
            var usuarios = SuperLaEsperanzaDbContex.Usuario.Where(u => u.Estado == true)
                .Select(u => new UsuarioDOT
                {
                    IdUsuario = u.IdUsuario,
                    NombreCompleto = u.NombreCompleto,
                    UsuarioNombre = u.UsuarioNombre,
                    Clave = u.Clave,
                    Rol = u.Rol,
                    Estado = u.Estado
                })
                .ToList();

            return usuarios;
        }

        public List<UsuarioDOT> ObtenerUsuariosPorRol(string rol)
        {
            var usuariosActivos = SuperLaEsperanzaDbContex.Usuario
                .Where(u => u.Rol == rol && u.Estado == true)
                .Select(u => new UsuarioDOT
                {
                    IdUsuario = u.IdUsuario,
                    NombreCompleto = u.NombreCompleto,
                    UsuarioNombre = u.UsuarioNombre,
                    Clave = u.Clave,
                    Rol = u.Rol,
                    Estado = u.Estado
                })
                .ToList();
            return usuariosActivos;


        }

        public List<UsuarioDOT> ObtenerUsuarPorEstado(bool estado)
        {
            var usuariosActivos = SuperLaEsperanzaDbContex.Usuario
                .Where(u => u.Estado == estado)
                .Select(u => new UsuarioDOT
                {
                    IdUsuario = u.IdUsuario,
                    NombreCompleto = u.NombreCompleto,
                    UsuarioNombre = u.UsuarioNombre,
                    Clave = u.Clave,
                    Rol = u.Rol,
                    Estado = u.Estado
                })
                .ToList();
            return usuariosActivos;
        }

        public void DesactivarOActivar(bool estado, string idUsuario)
        {
            var usuario = SuperLaEsperanzaDbContex.Usuario.FirstOrDefault(u => u.IdUsuario == idUsuario);
            if (usuario != null)
            {
                if(usuario.Estado == estado)
                {
                    MessageBox.Show($"El usuario ya se encuentra {(estado ? "activado" : "desactivado")}", "Información", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                    return;
                }
                usuario.Estado = estado;
                SuperLaEsperanzaDbContex.SaveChanges();
                MessageBox.Show($"El usuario ha sido {(estado ? "activado" : "desactivado")}", "Éxito", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario no encontrado", "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }

}


