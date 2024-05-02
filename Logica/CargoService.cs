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
            throw new NotImplementedException();
        }

        public string Guardar(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public string ModificarRegistros(Cargo cargo)
        {
            throw new NotImplementedException();
        }
    }
}
