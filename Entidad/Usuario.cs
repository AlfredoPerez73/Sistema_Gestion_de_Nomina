using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Documento { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public Rol Rol { get; set; }
        public string Correo { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
