using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bibliotinta;

namespace tinta_pluma
{
    public class Tinta
    {
        private ConsoleColor color;
        private ElTipoTinta tipo;

        #region Constructores
        public Tinta()
        {
            this.color = ConsoleColor.Black;
            this.tipo = ElTipoTinta.Comun;
        }

        public Tinta(ElTipoTinta a) : this()
        {
            this.tipo = a;
        }

        public Tinta(ConsoleColor a, ElTipoTinta b) : this(b)
        {
            this.color = a;
        }
        #endregion
        #region Metodos
        string Mostrar()
        {
            return "Tinta : " + this.tipo.ToString() + "\nColor : " + this.color.ToString();
        }

        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }
        #endregion

        #region Operadores
        public static bool operator ==(Tinta n1, Tinta n2)
        {
            return (n1.color == n2.color && n1.tipo == n2.tipo);
        }

        public static bool operator !=(Tinta n1, Tinta n2)
        {
            return !(n1 == n2);
        }

        public static explicit operator string(Tinta tinta)
        {
            return tinta.Mostrar();
        }
        #endregion
    }
}
