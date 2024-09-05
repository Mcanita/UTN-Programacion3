using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia3
{
    class Gato : AnimalDomestico
    {
       public override string comunicarse() //sobreescritura de método
        {
            return"miau... miau...";
        }
    }
}
