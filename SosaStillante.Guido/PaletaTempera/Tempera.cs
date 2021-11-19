using System;
using System.Collections.Generic;
using System.Text;

namespace PaletaTempera
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        #region Constructor
        public Tempera(ConsoleColor a, string b, int c)
        {
            this.color = a;
            this.marca = b;
            this.cantidad = c;
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            //return ("Color: " + this.color.ToString() + "Marca: " + this.marca + "Cantidad: " + this.cantidad.ToString());
            StringBuilder sb = new StringBuilder();
            sb.Append("Color: ");
            sb.AppendLine(this.color.ToString());
            sb.Append("Marca: ");
            sb.AppendLine(this.marca);
            sb.Append("Cantidad: ");
            sb.AppendLine(this.cantidad.ToString());

            return sb.ToString();
        }

        public string Mostrar(Tempera a)
        {
            return a.Mostrar();
        }
        
        #endregion

        #region Sobrecargas
        public static bool operator ==(Tempera t1, Tempera t2)
        {
            bool rtn = false;
            if((object)t1 == null && (object)t2 == null)
            {
                rtn = true;
            }
            else
            {
                if((object)t1 != null && (object)t2 != null)
                {
                    if(t1.marca == t2.marca && t1.color == t2.color)
                    {
                        rtn = true;
                    }
                }
            }
            return rtn;
        }
        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }

        public static implicit operator int(Tempera t1)
        {
            return t1.cantidad;
        }
        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            Tempera rtn = null;
            if(t1 == t2)
            {
                int sumaCantidad = t1.cantidad + t2.cantidad;
                rtn = new Tempera(t1.color, t1.marca, sumaCantidad);
            }
            return rtn;
        }
        public static Tempera operator +(Tempera t1, int c)
        {
            if(t1 != null)
            {
                int sumaCantidad = t1.cantidad + c;
                t1 = new Tempera(t1.color, t1.marca, sumaCantidad);
            }
            return t1;
        }
        #endregion
    }
}
