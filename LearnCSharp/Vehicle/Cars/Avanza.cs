using LearnCSharp.SpareParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp.Vehicle.Cars
{
    public class Avanza : Car
    {
        public Avanza()
        {

        }

        public Avanza(int wheelNumber, Wheel wheel, int seatNumber, Seat seat)
        {
            SetSeats(seat, seatNumber);
            SetWheels(wheel, wheelNumber);
        }

        public const int DoorNumber = 5;
    }
}
