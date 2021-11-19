using System;
using System.Collections.Generic;
using System.Text;

namespace PaletaTempera
{
    public class Paleta
    {
        private Tempera[] temperas;
        private int cantidadMaximaColores;

        #region Constructores
        private Paleta() : this(5)
        {
        }
        private Paleta(int a)
        {
            this.cantidadMaximaColores = a;
            this.temperas = new Tempera[this.cantidadMaximaColores];
        }
        #endregion

        #region Metodos
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Cantidad Maxima de colores: ");
            sb.AppendLine(this.cantidadMaximaColores.ToString());
            sb.Append("Temperas: ");
            foreach(Tempera item in this.temperas)
            {
                if(item != null)
                {
                    sb.AppendLine(item.Mostrar(item));
                }
            }
            return sb.ToString();
        }

        public int obtenerIndice()
        {
            int rtn = -1;
            for (int i = 0; i < this.cantidadMaximaColores; i++)
            {
                if (this.temperas[i] == null)
                {
                    rtn = i;
                    break;
                }
            }
            return rtn;
        }

        public int obtenerIndice(Tempera t1)
        {
            int rtn = -1;
            for (int i = 0; i < this.cantidadMaximaColores; i++)
            {
                if (this.temperas[i] == t1)
                {
                    rtn = i;
                    break;
                }
            }
            return rtn;
        }
        #endregion

        #region Operadores
        public static implicit operator Paleta(int c)
        {
            Paleta rtn = new Paleta(c);
            return rtn;
        }
        public static explicit operator string(Paleta p1)
        {
            return p1.Mostrar();
        }

        public static bool operator ==(Paleta p1, Tempera t1)
        {
            bool rtn = false;
            foreach(Tempera item in p1.temperas)
            {
                if(item == t1)
                {
                    rtn = true;
                    break;
                }
            }
            return rtn;
        }

        public static bool operator !=(Paleta p1, Tempera t1)
        {
            return !(p1 == t1);
        }
        public static Paleta operator +(Paleta p1, Tempera t1)
        {
            int ind;
            if (p1 == t1)
            {
                ind = p1.obtenerIndice(t1);
                p1.temperas[ind] += t1;
            }else
            {
                ind = p1.obtenerIndice();
                if(ind != -1)
                {
                    p1.temperas[ind] = t1;
                }
            }
            return p1;
        }

        public static Paleta operator -(Paleta p1, Tempera t1)
        {
            int ind;
            if (p1 == t1)
            {
                ind = p1.obtenerIndice(t1);
                p1.temperas[ind] += (-t1);
                if(p1.temperas[ind] <= 0)
                {
                    p1.temperas[ind] = null;
                }
            }
            return p1;
        }

        public static Paleta operator +(Paleta p1, Paleta p2)
        {
            Paleta rtn = null; 
            int ind;
            if ((object)p1 != null && (object)p2 != null) // no  es necesario
            {
                rtn = p1.cantidadMaximaColores + p2.cantidadMaximaColores;
                p1.temperas.CopyTo(rtn.temperas, 0);

                foreach (Tempera item in p2.temperas)
                {
                    if (item != null)
                    {
                        ind = rtn.obtenerIndice(item);
                        if (ind == -1)
                        {
                            rtn.temperas[rtn.obtenerIndice()] = item;
                        }
                        else
                        {
                            rtn.temperas[ind] += item;
                        }

                    }
                }
            }
            return rtn;
        }
        #endregion
    }
}
