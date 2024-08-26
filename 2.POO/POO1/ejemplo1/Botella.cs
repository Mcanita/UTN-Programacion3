using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Botella
    {
        //CAPACIDAD, COLOR, MATERIAL
        private int capacidad;
        private string color;
        private string material;

        //acceder a los atributos por propiedad

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
    }
}
