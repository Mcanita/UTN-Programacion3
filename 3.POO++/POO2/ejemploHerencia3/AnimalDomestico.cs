using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia3
{
    class AnimalDomestico : Animal
    {
        public string Nombre { get; set; }

        //SOBEERCRIBIR MÉTODO ToString
        public override string ToString()
        {
            return "Animal Doméstico : " + Nombre;
        }
    }
}
