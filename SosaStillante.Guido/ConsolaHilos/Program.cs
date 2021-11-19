using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsolaHilos
{
    // Un programa se cierra o finaliza al momento que todos los hilos se cierran, ya que un proceso completo es un conjunto de hilos
    // La clase que se utiliza para la creacion de hilos es la clase 'Task'(anteriormente se utilizaba Threads)
    // los namespace System.Threading y System.Threading.Task
    // El hilo secundaria nace y muere en el ciclo de vida del hilo principal
    // 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Task t = new Task(MiMetodo); // Se instancia el Hilo (Recibe un delegado como parametro obligatorio)

            t.Start(); // Inicia el Hilo

            
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("");
            }


            t.Wait(); // Si fuera necesario, este metodo freezea el hilo hasta que finalice la tarea

            Console.ReadKey();
        }

        public static void MiMetodo()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("");
            }
        }
    }
}
