using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario : Persona
    {
        public string Contraseña { get; set; }
        public Rol Rol { get; set; }
        public string Correo { get; set; }
    }
}
