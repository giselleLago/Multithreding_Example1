

using System;
using System.Threading;

namespace Multitrading_Example1
{
    class Program
    {
        //Main representa el hilo principal
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Un solo hilo");
        //    Console.ReadKey();
        //}
        static void Main(string[] args)
        {
            ////Instanciamos el obj thread y colocams el delegado que corresponde
            //Thread miHilo = new Thread(Saludos);

            ////Ahora lo inicializamos ya que n arranca al momento de instanciarse
            //miHilo.Start();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Saludos desde main");

            //Forma que pasa datos al hilo
            Thread miHilo = new Thread(MiMensaje);

            //Al iniciar el hilo mandamos el mensaje
            miHilo.Start(5);
            Console.ReadKey();
        }

        //Creamos un metodo que se ejecutara en el segundo hilo
        //Debe coincidir con el delegado
        //public delegate void ThreadStart();

        static void Saludos()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saludos desde el hilo");
        }

        //Este metodo se ejecuta en el segundo hilo y recibe un 
        //parametro del exterior

        static void MiMensaje(object o)
        {
            int m = Convert.ToInt32(o);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Saludos desde el mensaje {0}, {1}", m, m * 2);
        }
    }
}
