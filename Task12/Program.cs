using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание про окружность\n");

            Console.WriteLine("Введите параметры окружности");
            Console.Write("Значение радиуса окружности: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Координаты центра окружности: ");
            double x0 = Convert.ToDouble(Console.ReadLine());
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Координаты точки: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Длина окружности: {Circle.CircleLength(r)}");
            Console.WriteLine($"Площадь окружности: {Circle.CircleS(r)}");
            Console.WriteLine($"Точка лежит в окружности: {Circle.PointInCircle(r, x0, y0, x, y)}");
            Console.ReadKey();
        }
    }
}
