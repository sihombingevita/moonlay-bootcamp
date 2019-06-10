using LearnCSharp.SpareParts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp.Vehicle
{
    public class Vehicle
    {
        public Vehicle()
        {

        }

        public bool IsMoving { get; set; }

        public DateTime StartTime { get; private set; }

        public DateTime StopTime { get; private set; }

        public void Moving()
        {
            StartTime = DateTime.Now;
            IsMoving = true;
        }

        public void Stop()
        {
            StopTime = DateTime.Now;
            IsMoving = false;
        }
    }
}
