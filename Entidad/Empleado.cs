﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Empleado : Persona
    {
        public Contrato Contrato { get; set; }
        public Cargo Cargo { get; set; }
        public string Estado { get; set; }
    }
}
