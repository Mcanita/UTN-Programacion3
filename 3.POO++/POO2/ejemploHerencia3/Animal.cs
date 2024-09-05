using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia3
{
    class Animal
        
    {
        public string Color { get; set; }
        public virtual string comunicarse() //para sobeescribir hay que poner la palabra virtual
        {
            return "ruido... ruido";
        }
    }
}
