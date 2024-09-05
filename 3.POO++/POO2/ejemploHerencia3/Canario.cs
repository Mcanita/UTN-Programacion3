using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia3
{
    //INTERFACES
    class Canario : AnimalDomestico, Flyable //la interfaz se agrega con dos puntos al igual que la herencia 
    {
        public string volar()
        {
            return "vuela como un canario ...";
        }
    }
}
