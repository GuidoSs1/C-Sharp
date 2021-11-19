using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics._2020
{
    public class Mensajero<T, U> // Se puede utilizar literalmente cualquier tipo de dato, no tiene limites
    {
        public T miAtr1;
        public U miAtr2;
        private Dictionary<T, U> miDiccionario;

        public Mensajero() //El constructor se define de la misma forma que cualquier tipo de clase
        {
            this.miAtr1 = default; //Al saber que no se puede saber el tipo de dato al que pertenecen los parametros, no se podra hardcodear los datos
            this.miAtr2 = default(U); // La palabra reservada 'default' sabra de que tipo de dato sera en tiempo de ejecucion y le asignara un valor dependiente(0,null,false)
            this.miDiccionario = new Dictionary<T, U>();
        }

        public override string ToString()
        {
            return this.miAtr1.ToString() + " - " + this.miAtr2.ToString() + " - " + this.miDiccionario.Count.ToString();
            //Al utilizar el ToString, se deberia aplicar polimorfismo el la clase a la que pertenezca el parametro, si es que el mismo es un objeto.
        }
    }
}
