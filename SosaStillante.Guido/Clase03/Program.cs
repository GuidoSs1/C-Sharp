using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 6;

            MiClase obj;
            MiClase obj2 = new MiClase(1,2,2);

            obj = new MiClase(3,3,3);

            // Forma de acceder a miembros estaticos o de clase (Se llaman con el nombre de la clase primero)
            MiClase.estatico = 5;
            MiClase.MostrarEstatico();

            // Forma de invocar a miembros no estaticos o de instancia (Se llaman con el nombre del objeto o la instancia de la clase)
            obj.no_estatico = 4;
            obj.MostrarNoEstatico();

            obj2.no_estatico = 9;
            obj2.MostrarNoEstatico();

            obj = obj2; // Apuntan a la misma porcion de memoria por lo tanto al cambiar el valor de la variable no estatica, cambia para los dos objetos

            obj.no_estatico = 3;

            // Haciendo esto ya no se puede acceder a la porcion de memoria a la que pertenecia el no_estatico del obj

        }
    }
}
