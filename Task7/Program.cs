using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {

        static void Triangles()
        {
            Console.WriteLine("Задача про два трегуольника\n");

            Console.WriteLine("Введите стороны первого треугольника");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double S1 = GetTiangleS(a1, b1, c1);

            Console.WriteLine("Введите стороны второго треугольника");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double S2 = GetTiangleS(a2, b2, c2);

            Console.WriteLine("\nS1 = {0:F2}; S2 = {1:F2}", S1, S2);
            if (S1 > S2)
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            else if (S1 < S2)
            {
                Console.WriteLine("Площадь второго треугольника больше");
            }
            else
            {
                Console.WriteLine("Площади треугольников равны");
            }
        }

        static void Cube()
        {
            Console.WriteLine("Задача про два трегуольника\n");
            Console.Write("Введите длину ребра куба: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double V, S;
            GetCubeParams(x, out V, out S);
            Console.WriteLine("\nОбъем куба равен {0:F2}\nПлощадь поверхности куба равна {1:F2}", V, S);
        }

        static void Main(string[] args)
        {
            //Triangles();
            Console.WriteLine(new string('-', 100));
            Cube();
            Console.ReadKey();
        }

        static double GetTiangleS(double a, double b, double c)
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static void GetCubeParams(double l, out double V, out double S)
        {
            V = l * l * l;
            S = 6 * l * l;
        }
    }
}
