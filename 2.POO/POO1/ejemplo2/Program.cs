using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primer lote con 10 registros de productos, cada producto tiene:
            //-Código Artículo (3 dígitos no correlativos)
            //-Precio
            //-Código de marca (1 a 10)
            //Segundo lote con las ventas de la semana. Cada venta tiene :
            //-Código Artículo
            //-Cantidad
            //-Código Cliente (1 a 100)
            //Este lote corta con Código de Cliente cero.

            Articulo [] articulos = new Articulo[5];


            Console.WriteLine("INGRESE LOS DATOS DEL PRODUCTO ");
            Console.WriteLine("");
            for (int x = 0; x < 5; x++)
            {
                articulos[x] = new Articulo();

                Console.WriteLine("ingrese el codigo del articulo : ");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el precio : ");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el codigo de marca : ");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            } //terminamos de cargar el vector completo

            Venta venta = new Venta();
            Console.WriteLine("INGRESE LA VENTA :");
            Console.WriteLine("");
            Console.WriteLine("codigo de cliente : ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while(venta.CodigoCliente != 0)
            {
                Console.WriteLine("codigo del articulo : ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("cantidad : ");
                venta.Cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                //ingresamos cliente nuevamente
                Console.WriteLine("codigo de cliente : ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());

            }

         
           



        }
    }
}
