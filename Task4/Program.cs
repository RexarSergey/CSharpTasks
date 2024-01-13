using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Pow2()
        {
            Console.WriteLine("Задание на нахождение квадрата числа\n");
            Console.Write("Введите целое число N: ");

            int N = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nКвадраты чисел от 1 до {0}:", N);
            int Sum = 0;
            int Num = 1;
            for (int i = 1; i <= (2 * N - 1); i += 2)
            {
                Sum += i;
                Console.WriteLine(">>{0}^2 = {1}", Num, Sum);
                ++Num;
            }
        }

        static void EvenOdd()
        {
            Console.WriteLine("Задание на сравнение чет. и нечет. чисел\n");
            Console.WriteLine("Введите последовательность чисел, оканчивающаяся на 0");

            int EvenCount = 0;
            int OddCount = 0;
            int Num;

            do
            {
                Console.Write("Введите число: ");
                Num = Convert.ToInt16(Console.ReadLine());
                if (Num == 0)
                {
                    continue;
                }

                if (Num % 2 == 0)
                {
                    ++EvenCount;
                }
                else
                {
                    ++OddCount;
                }

            } while (Num != 0);

            if (EvenCount > OddCount) 
            {
                Console.WriteLine("В последовательности чисел четных было больше");
            }
            else if (OddCount > EvenCount) 
            {
                Console.WriteLine("В последовательности чисел нечетных было больше");
            }
            else
            {
                Console.WriteLine("В последовательности чисел четных и нечетных было поровну");
            }
        }

        static void FillWithCubes()
        {
            Console.WriteLine("Задание на заполнение кубами\n");
            
            Console.WriteLine("Введите размерность прямоугольного поля");
            Console.Write("A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("B: ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nВведите длину стороны квадрата: ");
            double C = Convert.ToDouble(Console.ReadLine());

            if (A < C || B < C)
            {
                Console.WriteLine("Поле невозможно заполнить квадратами");
                return;
            }

            double Num = 0;
            double Temp;
            while (A >= C) 
            {
                A -= C;
                Temp = B;
                
                while (Temp >= C)
                {
                    Temp -= C;
                    ++Num;
                }
            }

            Console.WriteLine("Поле можно заполнить квадратами в количестве равном {0:F2}", Num);
        }

        static void Main(string[] args)
        {
            Pow2();
            Console.WriteLine(new string('-', 100));
            EvenOdd();
            Console.WriteLine(new string('-', 100));
            FillWithCubes();

            Console.ReadKey();
        }
    }
}
