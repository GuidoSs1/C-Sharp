using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Otro titulo";
            //printf(); Se reemplaza por un metodo que se encuentra dentro de una clase(todas las funciones estan dentro de clases)
            //Console.Write("Hola mundo!"); // Me dejara el cursor titilando en el ultimo caracter
            Console.WriteLine("Ingrese su nombre: "); // Provoca un salto de linea automaticamente

           
            //scanf("mascara", &var); o gets();
            string nombre = Console.ReadLine(); // Retorna un string pero no recibe parametros

            Console.WriteLine(nombre);


            Console.WriteLine("Ingrese su edad:");
            string edad_cadena = Console.ReadLine();

            // Ningun valor de tipo cadena se puede transformar a un tipo entero pero si hay metodos que hacen este casteo('int.Parse()')
            int edad = int.Parse(edad_cadena);// O Int32 que seria lo mismo que int

            // edad = int.Parse(Console.ReadLine());


            Console.WriteLine(edad);

            //printf("texto %s texto", variable) Para mostrar una variable dentro de un texto en C
            Console.WriteLine("Su nombre es {0} y su edad es {1}", nombre, edad); // el orden no importa, SOLO EL INDICE SEGUN EL ORDEN DEFINIDO DE LAS VARIABLES, DENTRO DE LAS LLAVES






            //getch() Detiene la ejecucion de la consola para que no se cierre la consola en C
            Console.ReadKey(); // Obtiene la tecla que se pulso
        }
    }
}
