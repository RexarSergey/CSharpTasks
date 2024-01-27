using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task21
{
    internal class Program
    {
        const int n = 10;
        const int m = 10;
        static int[,] garden = new int[n, m];


        static void Gardener1()
        {
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (garden[i, j] == 0)
                        garden[i, j] = 1;
                    Thread.Sleep(1);
                }
            }
        }

        static void Gardener2()
        {
            for (int i = m - 1; i >= 0; --i)
            {
                for (int j = n - 1; j >= 0; --j)
                {
                    if (garden[j, i] == 0)
                        garden[j, i] = 2;
                    Thread.Sleep(1);
                }
            }
        }

        static void PrintGarden()
        {
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.Write($"{garden[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задание на потоки\n");

            Thread thread1 = new Thread(Gardener1);
            Thread thread2 = new Thread(Gardener2);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            PrintGarden();
            Console.ReadLine();
        }
    }
}
