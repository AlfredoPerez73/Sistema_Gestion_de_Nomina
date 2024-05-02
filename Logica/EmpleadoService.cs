using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Logica
{
    public class EmpleadoService : ICrudService<Empleado>
    {
        private EmpleadoRepository empleadoRepository = new EmpleadoRepository();

        public List<Empleado> CargarRegistro()
        {
            var msg = empleadoRepository.CargarRegistro();
            return msg;
        }

        public string Guardar(Empleado producto)
        {
            var msg = empleadoRepository.GuardarRegistros(producto);
            return msg;
        }

        public string ModificarRegistros(Empleado producto)
        {
            var msg = empleadoRepository.ModificarRegistros(producto);
            return msg;
        }

        public bool BuscarId(string id)
        {
            return CargarRegistro().Any(e => e.Documento == id);
        }

        public List<Empleado> BuscarX(string x)
        {
            int idProducto;

            List<Empleado> productos = CargarRegistro();
            if (int.TryParse(x, out idProducto))
            {
                productos = productos
                    .Where(item => item.IdPersona == idProducto).ToList();
            }
            else
            {
                productos = productos
                    .Where(item => item.Documento.IndexOf(x, StringComparison.OrdinalIgnoreCase) != -1 ||
                                   item.Nombre.IndexOf(x, StringComparison.OrdinalIgnoreCase) != -1 ||
                                   item.Cargo.CargoDesempeñado.IndexOf(x, StringComparison.OrdinalIgnoreCase) != -1 ||
                                   item.Estado.IndexOf(x, StringComparison.OrdinalIgnoreCase) != -1).ToList();
            }
            return productos;
        }

        public List<Empleado> FiltroEstadoConParametro(string estado)
        {
            return CargarRegistro().Where(e => e.Estado == estado).ToList();
        }

        public List<Empleado> FiltroEstado()
        {
            return CargarRegistro().Where(e => e.Estado == "ACTIVO").ToList();
        }

    }
}
