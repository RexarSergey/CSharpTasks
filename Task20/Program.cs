using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    internal class Program
    {
        static double Length(double r)
        {
            double D = 2 * Math.PI * r;
            Console.WriteLine($"Длинна окружности: {D:F2}");
            return D;
        }

        static double Square(double r)
        {
            double S = Math.PI * r * r;
            Console.WriteLine($"Длинна окружности: {S:F2}");
            return S;
        }

        static double Volume(double r)
        {
            double V = 4.0 / 3.0 * Math.PI * r * r * r;
            Console.WriteLine($"Длинна окружности: {V:F2}");
            return V;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание про делегаты\n");

            Func<double, double> del = Length;
            del += Square;
            del += Volume;

            Console.Write("Введите значение радиуса окружности: ");
            double r = Convert.ToDouble(Console.ReadLine());
            del(r);

            Console.ReadKey();
        }
    }
}
