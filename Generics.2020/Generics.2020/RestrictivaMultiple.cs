using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics._2020
{
    public class RestrictivaMultiple<T> where T : class, new() 
        //El tipo de T debe ser de referencia o de instancia y debe tener un constructor publico y sin parametros
    {
    }
}
