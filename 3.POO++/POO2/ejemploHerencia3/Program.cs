using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal();
            AnimalDomestico domestico1 = new AnimalDomestico();
            Console.WriteLine(animal1.GetHashCode());
            Console.WriteLine("");

            domestico1.Nombre = "PEPE";
            Console.WriteLine(domestico1.ToString());

            Gato gato1 = new Gato();
            gato1.Nombre = "Tomás";
            Console.WriteLine("mi gato se llama : " + gato1.Nombre + " y hace : "+ gato1.comunicarse());
            Console.WriteLine("");

            Tigre tigre1 = new Tigre();
            Console.WriteLine("el tigre hace : " + tigre1.comunicarse());
            Console.WriteLine("");

            List<Animal> listaAnimales = new List<Animal>();
            listaAnimales.Add(domestico1);
            listaAnimales.Add(gato1);
            listaAnimales.Add(tigre1);
            listaAnimales.Add(new Gato()); //estos objetos solo pueden ser accedidos en la lista 

            foreach (Animal item in listaAnimales)
            {
                Console.WriteLine(item.comunicarse()); //POLIMORFISMO
            }

            List<Flyable> listaVoladores = new List<Flyable>(); //Una lista de objetos con la misma interfaz
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());
            listaVoladores.Add(new Canario());

            

            Console.ReadKey();

        }
    }
}
