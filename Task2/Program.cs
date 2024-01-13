using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
   
    internal class Program
    {
        static void Circle()
        {
            Console.WriteLine("Задание про круг\n");
            Console.Write("Введите значение длины окружности L: ");
            
            double L = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double R = L / (2 * Math.PI);
            double S = Math.PI * Math.Pow(R, 2);

            Console.WriteLine("Радиус круга: {0:F2}", R);
            Console.WriteLine("Площадь круга: {0:F2}", S);
        }

        static void Rectangle()
        {
            Console.WriteLine("Задание про прямоугольник\n");
            Console.WriteLine("Введите значение координат первой вершины: ");

            double X1 = Convert.ToDouble(Console.ReadLine());
            double Y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nВведите значение координат второй вершины: ");

            double X2 = Convert.ToDouble(Console.ReadLine());
            double Y2 = Convert.ToDouble(Console.ReadLine());

            double a = Math.Abs(X2 - X1);
            double b = Math.Abs(Y2 - Y1);

            Console.WriteLine("\nПериметр прямоугольника равен: {0:F2}", (2 * a + 2 * b));
            Console.WriteLine("Площадь прямоугольника равна: {0:F2}", (a * b));
        }

        static void Triangle()
        {
            Console.WriteLine("Задание про треугольник\n");

            Console.WriteLine("Введите значение координат первой вершины: ");

            double X1 = Convert.ToDouble(Console.ReadLine());
            double Y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nВведите значение координат второй вершины: ");

            double X2 = Convert.ToDouble(Console.ReadLine());
            double Y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nВведите значение координат третьей вершины: ");

            double X3 = Convert.ToDouble(Console.ReadLine());
            double Y3 = Convert.ToDouble(Console.ReadLine());

            double a = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
            double b = Math.Sqrt(Math.Pow(X1 - X3, 2) + Math.Pow(Y1 - Y3, 2));
            double c = Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));

            double P = a + b + c;
            double p = P / 2.0;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - b));

            Console.WriteLine("\nПериметр треугольника равен: {0:F2}", P);
            Console.WriteLine("Площадь треугольника равна: {0:F2}", S);
        }

        static void Main(string[] args)
        {
            Circle();
            Console.WriteLine(new string('-', 100));
            Rectangle();
            Console.WriteLine(new string('-', 100));
            Triangle();
            Console.ReadKey();
        }
    }
}
