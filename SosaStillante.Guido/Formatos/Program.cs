using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Formatos de Consola";

            Console.WriteLine("Justificando a derecha (valor positivo) y a izquierda (valor negativo):");
            Console.WriteLine("---------- ----------");
            Console.WriteLine("{0,10} {1,-10} {2}", 10, 15, 23);

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Estableciendo cantidad maxima de decimales:");
            Console.WriteLine("{0:.0} - {1:#.00} - {2:0.000} - {3}", 0.476864, 0.3558742, 0.9214, 96.3352587);

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Mostrando caracteres de puntuación:");
            Console.WriteLine("{0:#,#} - {1:N} - {2} - {3:#,#.00}", 1500, 1223123124, 2312341455, 85666.42);

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Otros Formatos:");
            Console.WriteLine("{0:X} - {1:E} - {2:C} - {3:D10}", 1500, 15355.7806, 12314242, 83723);

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Utilizando todo junto:");
            Console.WriteLine("--------------- ----------");
            Console.WriteLine("{0, 15:#,#} - {1, 10:#,#.00}", 1231415115, 21312,3213);

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Mostrando fechas y hora con formato: ");
            Console.WriteLine("Hoy es: {0:dd-MM-yy}", DateTime.Now);
            Console.WriteLine("Hoy es: {0:dd/MM/yyyy}", DateTime.Now);

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Fecha con mas formatos: ");
            Console.WriteLine("Hoy es: {0:dddd, dd \\de MMMM \\de yyyy}", DateTime.Now);

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Formato para las horas:");
            Console.WriteLine("{0:hh:mm:ss}", DateTime.Now);
            Console.WriteLine("{0:HH:mm:ss.ff}", DateTime.Now);

            Console.ReadKey();
        }
    }
}
