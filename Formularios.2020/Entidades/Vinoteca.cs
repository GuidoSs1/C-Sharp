using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    class Vinoteca
    {
        private int capacidad;
        private Vino[] vinos;

        #region Constructor
        public Vinoteca(int capacidad)
        {
            this.capacidad = capacidad;
            this.vinos = new Vino[this.capacidad]; //Inicializacion de un array
        }
        #endregion

        #region Metodos
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Capacidad: ");
            sb.AppendLine(this.capacidad.ToString());
            sb.AppendLine("Listado de vinos: ");

            foreach(Vino item in this.vinos)
            {
                sb.AppendLine(item.Mostrar());
            }

            return sb.ToString();
        }

        private int ObtenerLugar()
        {
            int indice = -1;

            for(int i = 0; i < this.vinos.Length; i++)
            {
                if(this.vinos[i] == null)  // Busca un lugar vacio dentro del array asignandole un indice, si el indice se mantine en su valor inicial, no obtuvo ningun indice disponible
                {
                    indice = i;
                    break;
                }
            }
            return indice;
        }
        #endregion

        #region Sobrecarga de operadores
        public static Vinoteca operator +(Vinoteca vt, Vino v)
        {
            int i = vt.ObtenerLugar();
            
            if(i > -1)
            {
                vt.vinos[i] = v;
            }

            return vt;
        }
        #endregion
    }
}
