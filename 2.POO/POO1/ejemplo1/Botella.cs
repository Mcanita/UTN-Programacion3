using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Botella
    {
        //CONSTRUCTOR
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
        }
        //SOBRECARGA DE CONSTRUCTOR
        public Botella() { } //constructor vacío, no recibe parámetros
        
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
        public string Material
        {
            get { return material; }//solo se púede leer no escribir
        }


    }
}
