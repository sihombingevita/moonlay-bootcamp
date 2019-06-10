using LearnCSharp.SpareParts;
using LearnCSharp.Vehicle.Cars;
using System;
using System.Linq;

namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Wheel avanzaWheel = new Wheel("karet", 19);
            Seat avanzaSeat = new Seat("kulit");
            Avanza avanza = new Avanza(4, avanzaWheel, 8, avanzaSeat);

            //avanza.Moving();

            //System.Threading.Thread.Sleep(2000);

            //avanza.Stop();

            Console.WriteLine(avanza.StopTime);

            Console.ReadKey();
        }
    }






}
