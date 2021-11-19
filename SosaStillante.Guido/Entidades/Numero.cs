using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        public double valor;

        public Numero(double valor)
        {
            this.valor = valor;
        }

        #region Sobrecarga de operadores
        public static bool operator ==(Numero n1, Numero n2)
        {
            return n1.valor == n2.valor;
        }

        public static bool operator !=(Numero n1, Numero n2)
        {
            return ! (n1.valor == n2.valor);
        }

        public static bool operator ==(Numero n1, Double n2)
        {
            return n1.valor == n2;
        }

        public static bool operator !=(Numero n1, Double n2)
        {
            return !(n1 == n2);
        }


        public static Numero operator +(Numero n1, Numero n2)
        {
            double suma = n1.valor + n2.valor;

            Numero rta = new Numero(suma);

            return rta;
        }

        public static Numero operator -(Numero n1, Numero n2)
        {
            double resta = n1.valor - n2.valor;

            Numero rta = new Numero(resta);

            return rta;
        }


        #endregion
    }
}
