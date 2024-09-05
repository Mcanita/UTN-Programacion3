using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia3
{
    class Tigre : AnimalSalvaje
    {
        public override string comunicarse()
        {
            return "rruaaa ... (ruido de tigre )";
        }
    }
}
