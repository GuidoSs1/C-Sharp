using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class MiClase
    {
        #region Atributos
        public static int estatico;
        public static string nombre;
        public int a;
        public int b;
        public int no_estatico;
        
        #endregion

        #region Metodos
        public static void MostrarEstatico()
        {
            Console.WriteLine(MiClase.estatico);
            //Console.WriteLine(estatico);
        }

        public void MostrarNoEstatico()
        {
            Console.WriteLine(this.no_estatico);
            //Console.WriteLine(no_estatico);
        }
        #endregion

        #region Constructores de Instancia
        /* public MiClase() Constructor por default
        {
            this.no_estatico = 5;               Esto es lo que hace la palabra new al momento de incializar un objeto
            this.a = 2;
            this.b = 0;
        } */

        public MiClase(int a, int b, int c) // Constructor por defecto
        {
            this.a = a;
            this.b = b;                     // Con esta def, al momento de inicializar el objeto se debe pasar los valores que queremos por parametros
            this.no_estatico = c;
        }
        #endregion

        #region Constructores Estaticos
        static MiClase() // A diferencia de los contructores de instancia, estos no pueden llevar parametros ni formato de acceso(public).
        {
            MiClase.estatico = 2;
            MiClase.nombre = "Valor Inicial";
        }
        #endregion

    }
}
