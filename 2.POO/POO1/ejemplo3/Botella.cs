using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    class Botella
    {
        //capacidad máxima : 100
        //cantidad actual : iniciar en cero
        //método recarga : cargar al 100 y devolver el costo de recarga. 50 cada 100


        //CONSTRUCTOR
        public Botella(string color, string material)
        {
            this.Color = color;
            this.Material = material;
            Capacidad = 100;
            CantidadActual = 0;

        }
        public Botella() { }

        //ATRIBUTOS
        public string Color { get; set; }
        public int Capacidad { get; }
        public string Material { get; set; }
        public int CantidadActual { get; set; }

        //MÉTODO
       public float Recargar()
        {
            if(CantidadActual > 0)
            {
                int diferencia = Capacidad - CantidadActual;
                float monto = diferencia * 50 / 100;
                CantidadActual += diferencia;
                return monto;
            }
            CantidadActual = 100;
            return 50;
           
        }
    }
}