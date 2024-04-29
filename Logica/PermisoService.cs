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

    }
}
