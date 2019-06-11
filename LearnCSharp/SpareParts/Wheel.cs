using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp.SpareParts
{
    public class Wheel
    {
        public Wheel()
        {

        }

        public Wheel(string material, double radius)
        {
            Material = material;
            Radius = radius;

        }

        public Wheel(string material, double radius, int rotation)
        {
            Material = material;
            Radius = radius;
            Rotation = rotation;
            
        }

        public string Material { get; private set; }
        public double Radius { get; private set; }
        public int Rotation { get; private set; }

        public double GetCircumference()
        {
            return 2 * Math.PI * Radius / 2;
        }

    }
}
