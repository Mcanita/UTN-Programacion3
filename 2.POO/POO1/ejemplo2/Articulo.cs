using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    class Articulo
    {
        //otra forma de acceder a los atributos es hacer directamente la propiedad
        //private int codigoArticulo;

        public int CodigoArticulo { get; set; }
        public float Precio { get; set; }
        private int codigoMarca;

        public int CodigoMarca
        {
            get { return codigoMarca; }
            set
            {
                if (value > 0 && value < 11)
                    codigoMarca = value;
                else
                    codigoMarca = -1;
            }


        }  
            
    }
}
