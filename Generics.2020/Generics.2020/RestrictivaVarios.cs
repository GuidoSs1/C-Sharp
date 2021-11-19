using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics._2020
{
    public class RestrictivaVarios<T, U>
        where T : new() // Debe tener un constructor publico y sin parametros 
        where U : T // El tipo de T debe ser de la clase base de U
    {
    }
}
