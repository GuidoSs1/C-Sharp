using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa ejer = new Cosa();

            ejer.EstablecerValor(20);
            ejer.EstablecerValor("Hola");
            ejer.EstablecerValor(DateTime.Now);

            Console.WriteLine(Cosa.Mostrar(ejer));

            Console.ReadKey();
        }
    }
}
