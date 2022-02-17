using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLab
{
    internal class Circle : Figure
    {
        public double radius { get; set; }

        public override double GetArea()
        {
            return radius * radius * 3.14;
        }

        public override void Draw(Graphics graph)
        {
            graph.DrawEllipse(new Pen(Color), (int)Position.X - (int)radius, (int)Position.Y - (int)radius,
                      (int)radius + (int)radius, (int)radius + (int)radius);
            graph.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X + radius / 2), (int)(Position.Y + radius / 2));
        }
    }
}