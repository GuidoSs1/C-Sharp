using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 1";

            byte index;
            int min = 0;
            int max = 0;
            int sum = 0;
            int prom;
            int numero;

            for (index = 0; index < 5; index++)
            {
                Console.WriteLine("Ingrese el {0}° numero:", index + 1);
                string nums = Console.ReadLine();
                numero = int.Parse(nums);

                sum = numero + sum;
                if (index == 0)
                min = numero;
                max = numero;

                if (numero < min)
                {
                    min = numero;
                } else if (numero > max) {
                    max = numero;
                }
                
            }

            prom = sum / 5;

            Console.WriteLine("Valor maximo = {0}", max);
            Console.WriteLine("Valor minimo = {0}", min);
            Console.WriteLine("Suma de los valores = {0}", sum);
            Console.WriteLine("Promedio de los valores = {0}", prom);

            Console.ReadKey();
        }
    }
}
