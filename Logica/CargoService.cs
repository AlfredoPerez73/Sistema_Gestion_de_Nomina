using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CargoService : ICrudService<Cargo>
    {
        CargoRepository cargoRepository = new CargoRepository();

        public List<Cargo> CargarRegistro()
        {
            var msg = cargoRepository.CargarRegistro();
            return msg;
        }

        public string EliminarRegistros(Cargo cargo)
        {
            var msg = cargoRepository.EliminarRegistros(cargo);
            return msg;
        }

        public string Guardar(Cargo cargo)
        {
            var msg = cargoRepository.GuardarRegistros(cargo);
            return msg;
        }

        public string ModificarRegistros(Cargo cargo)
        {
            var msg = cargoRepository.ModificarRegistros(cargo);
            return msg;
        }

        public bool BuscarId(string cargo)
        {
            return CargarRegistro().Any(p => p.CargoDesempeñado == cargo);
        }

        public List<Cargo> BuscarX(string x)
        {
            int idCargo;

            List<Cargo> permisos = CargarRegistro();
            if (int.TryParse(x, out idCargo))
            {
                permisos = permisos
                    .Where(item => item.IdCargo == idCargo).ToList();
            }
            else
            { 
                permisos = permisos.Where(item => item.CargoDesempeñado.IndexOf(x, StringComparison.OrdinalIgnoreCase) != -1).ToList();
            }
            return permisos;
        }
    }
}
