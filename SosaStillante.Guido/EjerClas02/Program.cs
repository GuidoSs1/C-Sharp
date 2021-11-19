using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClas02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "Hola mundo";

            Console.WriteLine(Sello.Imprimir());
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());

            Sello.mensaje = "Hola mundo C#";

            Sello.color = ConsoleColor.Yellow;

            Sello.ImprimirEnColor(); // Este metodo no hace falta ponerlo en un console write line
            Console.WriteLine(Sello.Imprimir());

            Console.ReadKey();
        }
    }
}
