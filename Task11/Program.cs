using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание про линейное уравнение\n");

            Console.WriteLine("Введите значение коэффицентов уравнения (0 = kx + b)");
            Console.Write("k = ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Linear l = new Linear(k, b);
            Console.WriteLine($"Решение: {l.Root()}");
            Console.ReadKey();
        }
    }
}
