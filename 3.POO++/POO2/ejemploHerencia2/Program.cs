using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            //VEHÍCULO > AUTO > AUTODEPORTIVO > AUTOURBANO
            //         >CAMIONETA
            //         >MOTO

            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();

            c1.Color = "amarillo";
            c2.Color = "blanco";
            c3.Color = "negro";


            //COLECCIONES 
            List<Camioneta> listaCamionetas = new List<Camioneta>();
            listaCamionetas.Add(c1); //agrego elementos a la lista 
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);

            Console.WriteLine("la cantidad de camionetas es : " + listaCamionetas.Count); //me cuenta la cantidad de elementos que hay en la lista
            Console.WriteLine("el color de la segunda camioneta es : "+ listaCamionetas[1].Color); //elijo que elemento mostrar
            Console.WriteLine("");

            foreach (Camioneta item in listaCamionetas)// recorre la lista y muestra el color de todos los elementos
            {
                Console.WriteLine("el color de la camionesta es : "+ item.Color);
                Console.WriteLine("");
            }


            listaCamionetas.Remove(c3); //remuevo un objeto puntual de la lista
            Console.WriteLine("la cantidad de camionetas es : " + listaCamionetas.Count);
            listaCamionetas.RemoveAt(1);// remuevo un objeto según el índice de la lista
            Console.WriteLine("la cantidad de camionetas es : " + listaCamionetas.Count);
            

            Auto a1 = new Auto();
            a1.Motor = new Motor(); //AGREGACIÓN
            Console.ReadKey();
        }
    }
}
