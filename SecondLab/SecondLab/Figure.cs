using System;
using System.Collections.Generic;
using System.Text;

namespace SecondLab
{
    public abstract class Figure
    {
        public string Name { get; set; }

        public abstract double GetArea();
    }
}
