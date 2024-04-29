using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class UsuarioService
    {
        private UsuarioRepository usuarioRepository = new UsuarioRepository();

        public bool BuscarId(string id)
        {
            return CargarRegistro().Any(u => u.Documento == id);
        }

        public string Guardar(Usuario usuario)
        {
            var msg = usuarioRepository.GuardarRegistros(usuario);
            return msg;
        }

        public List<Usuario> LoginUser(string user, string password)
        {
            return CargarRegistro().Where(u => u.NombreUsuario == user && u.Contraseña == password).ToList();
        }

        public List<Usuario> CargarRegistro()
        {
            var msg = usuarioRepository.CargarRegistro();
            return msg;
        }

        public List<Usuario> BuscarX(string x)
        {
            int idUsuario;

            List<Usuario> usuarios = CargarRegistro();
            if (int.TryParse(x, out idUsuario))
            {
                usuarios = usuarios
                    .Where(item => item.IdUsuario == idUsuario).ToList();
            }
            else
            {
                usuarios = usuarios
                    .Where(item => item.Documento.Contains(x.ToUpper()) || item.NombreUsuario.Contains(x.ToUpper())
                    || item.Rol.NRol.Contains(x.ToUpper())).ToList();
            }
            return usuarios;
        }

        public List<Usuario> FiltroRol(string rol)
        {
            return CargarRegistro().Where(u => u.Rol.NRol == rol).ToList();
        }

        public string EliminarRegistros(Usuario usuario)
        {
            var msg = usuarioRepository.EliminarRegistros(usuario);
            return msg;
        }
    }
}
