using System;
using System.Collections.Generic;
using System.Text;

namespace SecondLab
{
    class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
