using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdLab
{
    internal class Program
    {
        public static Figure[] figur =
        {
            new Rectangle()
            {
                Name = "Квадрат",
                Color = System.Drawing.Color.DarkRed,
                Position = new System.Drawing.Point(50,200),
                Width = 100, Height = 50
            },

            new Circle()
            {
                Name = "Круг",
                Color = System.Drawing.Color.Green,
                Position = new System.Drawing.Point(70, 100),
                radius = 50
            },

            new Triangle()
            {
                Name = "Треугольник",
                Color = System.Drawing.Color.Blue,
                Position = new System.Drawing.Point (200, 100),
                Height = 50,
                Base = 50
            },
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа #3 - Полиморфизм");
            Console.WriteLine("Выполнил - Сахабутдинов Никита");


            Form form = new Form()
            {
                Text = "Лабораторная работа #3 - Полиморфизм",
                Size = new System.Drawing.Size(800, 600),
                StartPosition = FormStartPosition.CenterScreen
            };

            form.Paint += Frm_Paint;

            Application.Run(form);
        }

        private static void Frm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in figur)
            {
                f.Draw(e.Graphics);
            }
        }
    }
}
