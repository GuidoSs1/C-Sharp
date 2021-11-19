using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase4
{
    class Cosa
    {
        int entero;
        string cadena;
        DateTime fecha;

        #region Sobrecarga de Constructores
        public Cosa()
        {
            this.entero = 10;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
        }
        public Cosa(string a) : this()
        {
            this.cadena = a;
        }
        public Cosa(int a, string b) : this(b)
        {
            this.entero = a;
        }
        public Cosa(DateTime a, int b, string c) : this(b,c)
        {
            this.fecha = a;
        }
        #endregion

        #region Sobrecarga de Metodos
        public void EstablecerValor(int a)
        {
            this.entero = a;
        }

        public void EstablecerValor(string a)
        {
            this.cadena = a;
        }

        public void EstablecerValor(DateTime a)
        {
            this.fecha = a;
        }
        #endregion

        string Mostrar()
        {
            return this.entero.ToString() + " " + this.cadena + " " + this.fecha.ToShortDateString();
        }

        public static string Mostrar(Cosa a)
        {
            return a.Mostrar();
        }
    }
}
