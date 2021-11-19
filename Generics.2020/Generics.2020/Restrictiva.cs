using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics._2020
{
    public class Restrictiva<T> where T : MiClase 
        //Esta restriccion('where') solo permite que el dato que sea pasado por parametro sea de tipo MiClase, si el dato no es de ese tipo se producira un error en compilacion
        //Los parametros(T) son llamados comodines
        //Clases derivadas tambien seran aceptadas, por polimorfismo
    {
        public List<T> miLista;

        public Restrictiva()
        {
            this.miLista = new List<T>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in this.miLista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
