using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface ICrudService<T>
    {
        string Guardar(T entidad);
        List<T> CargarRegistro();
        string ModificarRegistros(T entidad);
    }
}
