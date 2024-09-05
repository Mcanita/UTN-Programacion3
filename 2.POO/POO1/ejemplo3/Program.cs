using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Botella b1 = new Botella("amarillo", "plastico");

            Console.WriteLine("CAPACIDAD DE LA BOTELLA: " + b1.Capacidad);
            Console.WriteLine("LA CANTIDAD ACTUAL ES : "+ b1.CantidadActual);

            b1.Recargar(20);
            Console.WriteLine("LUEGO DE RECARGAR LA CANTIDAD ACTUAL ES : " + b1.CantidadActual);

            b1.Recargar();
            Console.WriteLine("LUEGO DE RECARGAR LA CANTIDAD ACTUAL ES : "+ b1.CantidadActual);
            Console.ReadKey();
        }
    }
}
