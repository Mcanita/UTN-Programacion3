﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia
{
    // DEVELOPER HEREDA DE PERSONA 
    sealed class Developer : Persona //SEALED NO ME PERMITE HACER HERENCIA 
    {
        public string  Seniority { get; set; }
    }
}
