using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia2
{
    class Auto : Vehiculo
    {
        public Auto() //Constructor
        {
            Chasis = new Chasis();
        }
        public int Anio { get; set; }
        public string Modelo { get; set; }


        //COMPOSICIÓN
        public Chasis Chasis { get; set; } //el auto no puede nacer sin el chasis

        //AGREGACIÓN
        public Motor Motor { get; set; } //Un auto puede nacer sin motor y agregarselo después
    }
}
