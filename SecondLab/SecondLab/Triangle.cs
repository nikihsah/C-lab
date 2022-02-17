using System;
using System.Collections.Generic;
using System.Text;

namespace SecondLab
{
    class Triangle : Figure
    {
        public double Side { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return 1/2  * (Side * Height);
        }
    
    }
}
