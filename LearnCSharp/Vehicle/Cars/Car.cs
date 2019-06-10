using LearnCSharp.SpareParts;
using System.Collections.Generic;

namespace LearnCSharp.Vehicle.Cars
{
    public class Car : Vehicle
    {
        public Car()
        {
            Wheels = new List<Wheel>();
            Seats = new List<Seat>();
        }

        public List<Wheel> Wheels { get; set; }

        public void SetWheels(Wheel wheel, int wheelNumber)
        {
            for (int i = 0; i < wheelNumber; i++)
            {
                Wheels.Add(wheel);
            }
        }

        public List<Seat> Seats { get; set; }

        public void SetSeats(Seat seat, int seatNumber)
        {
            for (int i = 0; i < seatNumber; i++)
            {
                Seats.Add(seat);
            }
        }
    }
}
