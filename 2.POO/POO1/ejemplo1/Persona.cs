using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Persona
    {
        //EDAD, SUELDO, NOMBRE

        private int edad;
        private float sueldo;
        private string nombre;

        //acceder a los atributos por medio de una función 
        public void setEdad (int e)
        {
            edad = e;
        }
        public void setNombre(string n)
        {
            nombre = n;
        }
        public void setSueldo( float s)
        {
            sueldo = s;
        }

        //función que devuelve el valor del atributo
        public int getEdad()
        {
            return edad;
        }
        public string getNombre()
        {
            return nombre;
        }
        public float getSueldo()
        {
            return sueldo;
        }

        //MÉTODOS
        public string Saludar()
        {
            return "HOLA SOY ... " + nombre;
        }
    }
}
