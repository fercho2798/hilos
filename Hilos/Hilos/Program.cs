using System;
using System.Threading;

namespace Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Thread corredor1 = new Thread(Carrera.Corredor);
            Thread corredor2 = new Thread(Carrera.Corredor);
            Thread corredor3 = new Thread(Carrera.Corredor);
            Thread corredor4 = new Thread(Carrera.Corredor);

            corredor1.Start("Anthony");
            corredor2.Start("Tania");
            corredor3.Start("Brayan");
            corredor4.Start("Majo");

            corredor1.Join();
            corredor2.Join();
            corredor3.Join();
            corredor4.Join();


        }
    }
}
