using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //PERSONA > LIDER > DEVELOPER > TESTER

           // Persona persona1 = new Persona();    AL ser una clase abstracta no me permite instanciar
            Developer desarrollador1 = new Developer();

          //  persona1.Apellido = "Gonzales";
            desarrollador1.Apellido = "antonio";

            Console.WriteLine(desarrollador1.Apellido);

            Lider.algo(); // se puede usar directamente sin necesidad de instanciar 
            Console.ReadKey();
        }
    }
}
