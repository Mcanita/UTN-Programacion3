using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Program
    {
        //CLASES, OBJETOS, PROPIEDADES, ENCAPSULAMIENTO
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.setEdad(35);
            persona1.setNombre("Maria");
            persona1.setSueldo(33);

            Console.WriteLine("mi nombre es "+ persona1.getNombre() +" tengo "+ persona1.getEdad() + " anios y mi sueldo es de $ " + persona1.getSueldo());

            Botella botella1 = new Botella();
            botella1.Capacidad = 50;

            Console.WriteLine("la capacidad de la botella es de : " + botella1.Capacidad + " ml");
            Console.ReadKey();
        }
    }
}
