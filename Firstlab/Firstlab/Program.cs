using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstlab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная №1 - Инкапсуляция");
            Console.WriteLine("Выполнил - Сахабутдинов Никита aka Авраам Линкольн");

            Complex a = new Complex() { Real = 3, Imag = 0.5 };
            Complex b = new Complex() { Real = 2, Imag = 0.8 };

            a.Add(b);

            b.Substract(a);

            Console.WriteLine("a = {0} + {1}i", a.Real, a.Imag);
            Console.WriteLine("b = {0} + {1}i", b.Real, b.Imag);

        }
    }
}
