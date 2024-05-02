using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PermisoService
    {
        PermisoRepository permisoRepository = new PermisoRepository();

        public List<Permiso> CargarRegistro()
        {
            return permisoRepository.CargarRegistro();
        }

        public List<Permiso> ValidacionPermiso(string IdUsuario)
        {
            return permisoRepository.ValidacionPermiso(IdUsuario);
        }

        public string Guardar(Permiso permiso)
        {
            var msg = permisoRepository.GuardarRegistros(permiso);
            return msg;
        }

        public bool BuscarId(string permiso, string rol)
        {
            return CargarRegistro().Any(p => p.NPermiso == permiso && p.Rol.NRol == rol);
        }

        public List<Permiso> BuscarX(string x)
        {
            int idPermiso;

            List<Permiso> permisos = CargarRegistro();
            if (int.TryParse(x, out idPermiso))
            {
                permisos = permisos
                    .Where(item => item.IdPermiso == idPermiso).ToList();
            }
            else
            {
                permisos = permisos
                    .Where(item => item.NPermiso.IndexOf(x, StringComparison.OrdinalIgnoreCase) != -1 ||
                                   item.Rol.NRol.IndexOf(x, StringComparison.OrdinalIgnoreCase) != -1)
                    .ToList();
            }
            return permisos;
        }

        public List<Permiso> FiltroRol(string nombreRol)
        {
            return CargarRegistro().Where(p => p.Rol.NRol.Equals(nombreRol, StringComparison.OrdinalIgnoreCase)).ToList();
        }



    }
}
