using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Reporte
    {
        public int IdReporte { get; set; }
        public string NombreReporte { get; set; }
        public Usuario Usuario { get; set; }
        public byte[] Documento { get; set; }
        public string Extension { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
