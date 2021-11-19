using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerados
{
    class Program
    {
        static void Main(string[] args)
        {
            #region PruebaEnum
            //miEnum enum1 = miEnum.valor2;

            //Console.WriteLine(enum1); Muestra el valor de la variable 
            //Console.WriteLine((int)enum1); Muestra el orden de la variable dentro del enumerado en forma de entero
            #endregion

            /*Alfajor a1 = new Alfajor(Alfajores.CapitanDelEspacio, (int)Alfajores.CapitanDelEspacio);
            Alfajor a2 = new Alfajor(Alfajores.Fulbito, (int)Alfajores.Fulbito);
            Alfajor a3 = new Alfajor(Alfajores.Jorgito, (int)Alfajores.Jorgito);

            Alfajor.Mostrar(a1);
            Alfajor.Mostrar(a2);
            Alfajor.Mostrar(a3);*/

            // Recorrer el enumerado
            foreach (Alfajores item in Enum.GetValues(typeof(Alfajores))) // El typeof define el tipo de dato del enumerado. Se necesita el Enum.GetValues para obtener cada item en el enumerado porque se puede recorer con un foreache solo

            {
                Console.WriteLine("Nombre: " + item);
                Console.WriteLine("Precio: " + (int)item);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        #region DefPrueba
        //enum miEnum { valor1, valor2, valor3 };
        #endregion
    }
}
