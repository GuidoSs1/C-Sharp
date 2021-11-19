using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sobrecargas
{
    class Program
    {
        #region Sobrecarga de Constructores 
        //public int entero;
        //public string cadena;

        //public Program()
        //{
        //    this.entero = 20;
        //    this.cadena = "Guido";
        //}

        //public Program(int p) : this()
        //{
        //    this.entero = p;
        //    //this.cadena = "Guido"; Aplicando el : this() se invoca un constructor para ahorrar espacio de codigo y reutilizar en la definicion de otro constructor
        //}

        //public Program(string p) : this()
        //{
        //    //this.entero = 20;
        //    this.cadena = p;
        //}

        //public Program(int p, string p1)
        //{
        //    this.entero = p;
        //    this.cadena = p1;
        //}

        //public Program(string p, int p1) : this(p1, p)
        //{
        //    //this.entero = p1;
        //    //this.cadena = p;
        //}

        //public string Ver()
        //{
        //    return this.cadena + " - " + this.entero.ToString();
        //}
        #endregion

        #region Sobrecarga de Metodos
        //public static void MiMetodo()
        //{
        //    Console.WriteLine("Sin parametros.");
        //}

        //private static void MiMetodo(string p1)
        //{
        //    Console.WriteLine("Con parametro string {0}", p1);
        //}

        //private static void MiMetodo(int p1)
        //{
        //    Console.WriteLine("Con parametro int {0}", p1);
        //}

        //private static void MiMetodo(int p1, float p2)
        //{
        //    Console.WriteLine("Con parametros int {0} y float {1}", p1, p2);
        //}
        //private static void MiMetodo(float p2, int p1) // Forma de evitar problemas con el orden para un usuario externo
        //{
        //    Console.WriteLine("Con parametros int {0} y float {1}", p1, p2);
        //}

        //private static string MiMetodo(out int p1)
        //{
        //    p1 = 88;

        //    Program.MiMetodo(p1);

        //    return "Retorno del metodo con parametro out";
        //}
        #endregion

        static void Main(string[] args)
        {
            #region Sobrecarga de constructores
            //Program obj1 = new Program();
            //Program obj2 = new Program(3);
            //Program obj3 = new Program("otra cadena");
            //Program obj4 = new Program(32, "hola");
            //Program obj5 = new Program("loco",44);

            //Console.WriteLine(obj1.Ver());
            //Console.WriteLine(obj2.Ver());
            //Console.WriteLine(obj3.Ver());
            //Console.WriteLine(obj4.Ver());
            //Console.WriteLine(obj5.Ver());
            #endregion

            #region Sobrecarga de Metodos
            //Program.MiMetodo();
            //Program.MiMetodo("Hola");
            //Program.MiMetodo(3);
            //Program.MiMetodo(2, 3.2f); // Se debe pasar la letra f despues del ultimo numero para que el compilador no asuma el numero como un double. De otra forma se tendria que castear el numero.
            //Program.MiMetodo(5.2f, 2);

            //int variable;
            //string retorno;

            //retorno = Program.MiMetodo(out variable); // Se debe poner el modificador de parametro en la llamada tambien

            //Console.WriteLine(variable);
            #endregion

            Console.ReadKey();
        }
    }
}
