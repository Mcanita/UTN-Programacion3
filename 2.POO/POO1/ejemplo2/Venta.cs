using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    class Venta
    {
        public int CodigoArticulo { get; set; }
        public int Cantidad { get; set; }
        private int codigoCliente;
        
        public int CodigoCliente
        {
            get { return codigoCliente; }
            set
            {
                if (value > 0 && value < 101)
                    codigoCliente = value;
                else
                    codigoCliente = -1;
            }
        }
       
    }
}
