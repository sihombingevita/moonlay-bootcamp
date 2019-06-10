using System;
using System.Collections.Generic;
using System.Text;

namespace LearnCSharp.SpareParts
{
    public class Seat
    {
        public Seat()
        {

        }

        public Seat(string material)
        {
            Material = Material;
        }

        public string Material { get; set; }
    }
}
