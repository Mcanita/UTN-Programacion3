using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploDateTime1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(); //date time es un struct de fecha y hora
            DateTime fecha2 = new DateTime(2004, 4, 2); //llamo al constructor y paso parámetros
            DateTime fecha3 = DateTime.Now; //llamo a la fecha actual que saca de mi máquina

            Console.WriteLine("la fecha es : " + fecha.ToString());
            Console.WriteLine("la fecha por parámetros es : " + fecha2);
            Console.WriteLine("la fecha actual es : " + fecha3);
            Console.WriteLine("la fecha es : " + fecha3.AddDays(10)); //le agrega 10 días a la fecha 
            Console.WriteLine("la fecha es : " + fecha3.ToShortDateString());//me muestra la fecha pero no la hora
            Console.WriteLine("la fecha es : " + fecha3.ToShortTimeString());//me muestra solo la hora
            Console.WriteLine("la fecha es : " + fecha3.ToString("dd/mm/yyyy")); // le puedo poner un formato a la fecha 
            Console.WriteLine("la fecha es : " + fecha3.ToString("dddd")); //muestra el nombre del día completo
            Console.ReadKey();
        }
    }
}
