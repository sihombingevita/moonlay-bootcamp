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
            Wheel avanzaWheel = new Wheel("karet", 19, 1000);
            Seat avanzaSeat = new Seat("kulit");
            Avanza avanza = new Avanza(4, avanzaWheel, 8, avanzaSeat);

            avanza.Moving();

            System.Threading.Thread.Sleep(2000);

            avanza.Stop();

            int movingTime = avanza.StopTime.Second - avanza.StartTime.Second;

            avanza.Speedometer.Range = avanzaWheel.GetCircumference() * avanzaWheel.Rotation;
            avanza.Speedometer.Speed = avanza.Speedometer.Range / movingTime;

            Console.WriteLine(avanza.Speedometer.Range);
            Console.WriteLine(avanza.Speedometer.Speed);

            Console.ReadKey();
        }
    }






}
