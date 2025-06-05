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
            var usuarioEncontrado = SuperLaEsperanzaDbContex.Usuarios
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
            SuperLaEsperanzaDbContex.Usuarios.Add(nuevoUsuario);
            SuperLaEsperanzaDbContex.SaveChanges();
            MessageBox.Show("Usuario correctamente agregado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


