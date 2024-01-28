using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание на асинхронное программирование\n");

            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            FactorialAsync(n);

            Console.ReadKey();
        }

        static void Factorial(int n)
        {
            Int64 res = 1;
            for (int i = 1; i <= n; ++i)
            {
                res *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine($"Факториал числа {n} равен {res}");
        }

        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}
