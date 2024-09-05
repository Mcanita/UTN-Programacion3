using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Maria";
            nombre = "Hola como estas " + nombre;
            Console.WriteLine(nombre);

            nombre = Console.ReadLine();// SE LE PUEDE ASIGNAR NOMBRE DIRECTAMENTE 
            Console.WriteLine(nombre);
            nombre = "Hola como estas " + nombre;
            Console.WriteLine(nombre);

            int cantidad = nombre.Length; //ME DICE LA CANTIDAD DE CARACTERES 
            nombre = nombre.ToUpper(); //CONVIERTE TODO A MAYUSCULA
            nombre = nombre.ToLower(); //CONVIERTE TODO A MINUSCULA
            nombre = nombre.Replace('a','e'); //PERMITE CAMBIAR UN CARACTER POR OTRO 
            Console.ReadKey();
        }
    }
}
