using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public static class Calculadora
    {
        #region Metodos
        private static char ValidarOperador(char operador)
        {
            char rtn = '+';
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return operador;
            }
            return rtn;
        }
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double rtn = 0;
            operador = ValidarOperador(operador);
            if(num1 != null && num2 != null && operador != ' ')
            {
                switch (operador)
                {
                    case '+':
                        rtn = num1 + num2;
                        break;
                    case '-':
                        rtn = num1 - num2;
                        break;
                    case '/':
                        rtn = num1 / num2;
                        break;
                    case '*':
                        rtn = num1 * num2;
                        break;
                    default:
                        rtn = num1 + num2;
                        break;
                }
            }
            return rtn;
        }
        #endregion
    }
}
