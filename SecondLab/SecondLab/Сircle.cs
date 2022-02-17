using System;
using System.Collections.Generic;
using System.Text;

namespace SecondLab
{
    class Сircle : Figure
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            return Math.Pow(3.14,2) * Radius;
        }
    }
}
