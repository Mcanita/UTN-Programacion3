using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia
{
    static class Lider // : Persona   UNA CLASE ESTÁTICA NO PUEDE HEREDAR
    {
        public static string algo () // si la clase es estática los métodos también tienen que serlo
        {
            return "ya cobramos ? ";
        }
    }
}
