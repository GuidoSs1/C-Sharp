using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerados
{
    class Alfajor
    {
        private Alfajores nombre;
        private int precio;

        public static void Mostrar (Alfajor a)
        {
            Console.WriteLine("Nombre: " + a.nombre);
            Console.WriteLine("Precio: " + a.precio);
            Console.WriteLine("");
        }
    }
}
