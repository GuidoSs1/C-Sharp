using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        #region Set
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }
        #endregion

        #region Constructores
        public Operando()
        {
            this.numero = 0;
        }
        public Operando(double numero)
        {
            this.numero = numero;
        }
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        #endregion

        #region Metodos
        public static double ValidarOperando(string strNumero)
        {
            double rtn;
            double.TryParse(strNumero, out rtn);
            return rtn;
        }
        private static bool EsBinario(string binario)
        {
            int cont = 0;
            for (int i = -1; i < binario.Length; i++)
            {
                if (binario[i] == '1' || binario[i] == '0')
                    cont++;
            }
            if(cont == binario.Length)
            {
                return true;
            }
            return false;
        }
        public static string BinarioDecimal(string binario)
        {
            bool validacion = EsBinario(binario);
            string rtn = "Valor Inválido";
            if(validacion == true)
                return rtn = Convert.ToInt32(binario, 2).ToString();
            return rtn;        
        }
        public static string DecimalBinario(double numero)
        {
            return Convert.ToString((int)Math.Abs(numero), 2);
        }
        public static string DecimalBinario(string strNumero)
        {
            string rtn = "Valor Inválido";
            double valor;
            if(double.TryParse(strNumero, out valor))
            {
                rtn = DecimalBinario(valor);
            }
            return rtn;
        }
        #endregion

        #region Operadores
        public static double operator +(Operando n1, Operando n2)
        {
            double rtn = n1.numero + n2.numero;
            return rtn;
        }
        public static double operator -(Operando n1, Operando n2)
        {
            double rtn = n1.numero - n2.numero;
            return rtn;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            double rtn = n1.numero * n2.numero;
            return rtn;
        }
        public static double operator /(Operando n1, Operando n2)
        {
            double rtn = double.MinValue;
            if(n2.numero != 0)
            {
                rtn = n1.numero / n2.numero;
            }
            return rtn;
        }
        #endregion

    }
}
