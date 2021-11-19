using System;
using tinta_pluma;

namespace bibliotinta
{
    public class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;

        #region Constructores
        public Pluma()
        {
            this.marca = "Sin Marca";
            this.tinta = null;
            this.cantidad = 1;
        }
        public Pluma(string a) : this()
        {
            this.marca = a;
        }
        public Pluma(string a, Tinta b) : this(a)
        {
            this.tinta = b;
        }
        public Pluma(string a, Tinta b, int c) : this(a, b)
        {
            this.cantidad = c;
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            return "Marca: " + this.marca + "\nTinta: " + this.tinta.ToString() + "\nCantidad: " + this.cantidad.ToString();
        }
        #endregion

        #region Operadores
        public static bool operator ==(Pluma p1, Tinta t1)
        {
            return p1.tinta == t1;
        }
        public static bool operator !=(Pluma p1, Tinta t1)
        {
            return ! (p1.tinta == t1);
        }

        public static Pluma operator +(Pluma p1, Tinta t1)
        {
            Pluma rtn;
            if(p1.tinta == t1)
            {
                p1.cantidad++;
                rtn = new Pluma(p1.marca, t1, p1.cantidad);
            }
            else
            {
                return p1;
            }
            return rtn;
        }

        public static Pluma operator -(Pluma p1, Tinta t1)
        {
            Pluma rtn;
            if(p1.tinta == t1)
            {
                p1.cantidad--;
                rtn = new Pluma(p1.marca, t1, p1.cantidad);
            }
            else
            {
                return p1;
            }
            return rtn;
        }

        public static implicit operator string(Pluma p1)
        {
            return p1.Mostrar();
        }
        #endregion
    }
}
