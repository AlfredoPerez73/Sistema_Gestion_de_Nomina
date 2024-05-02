using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;

namespace Logica
{
    public class ProductoService : ICrudService<Producto>
    {
        private ProductoRepository productoRepository = new ProductoRepository();

        public List<Producto> CargarRegistro()
        {
            var msg = productoRepository.CargarRegistro();
            return msg;
        }

        public string Guardar(Producto producto)
        {
            var msg = productoRepository.GuardarRegistros(producto);
            return msg;
        }

        public string ModificarRegistros(Producto producto)
        {
            var msg = productoRepository.ModificarRegistros(producto);
            return msg;
        }

        public bool BuscarId(string id)
        {
            return CargarRegistro().Any(e => e.Documento == id);
        }

        public List<Producto> FiltroEstado(string estado)
        {
            return CargarRegistro().Where(e => e.Estado == estado).ToList();
        }

        public List<Producto> BuscarX(string valor)
        {
            return CargarRegistro().Where(e => e.Documento == valor ||
            e.Nombre == valor.ToUpper()).ToList();
        }
    }
}
