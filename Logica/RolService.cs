using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class RolService : ICrudService<Rol>
    {
        RolRepository rolRepository = new RolRepository();

        public List<Rol> CargarRegistro()
        {
            return rolRepository.CargarRegistro();
        }

        public string Guardar(Rol rol)
        {
            var msg = rolRepository.GuardarRegistros(rol);
            return msg;
        }

        public string ModificarRegistros(Rol rol)
        {
            var msg = rolRepository.ModifcarRegistros(rol);
            return msg;
        }

        public string EliminarRegistro(Rol rol)
        {
            var msg = rolRepository.EliminarRegistros(rol);
            return msg;

        }

        public bool BuscarId(string rol)
        {
            return CargarRegistro().Any(p => p.NRol == rol);
        }

        public List<Rol> BuscarX(string x)
        {
            int idRol;

            List<Rol> roles = CargarRegistro();
            if (int.TryParse(x, out idRol))
            {
                roles = roles
                    .Where(item => item.IdRol == idRol).ToList();
            }
            else
            {
                roles = roles.Where(item => item.NRol.IndexOf(x, StringComparison.OrdinalIgnoreCase) != -1).ToList();
            }
            return roles;
        }
    }
}
