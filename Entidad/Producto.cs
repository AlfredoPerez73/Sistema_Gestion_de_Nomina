using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public Contrato Contrato { get; set; }
        public Cargo Cargo { get; set; }
        public string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
