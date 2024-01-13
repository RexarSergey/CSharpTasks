using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Average()
        {
            Console.WriteLine("Задание на заполнение массива и нахождения среднего\n");
            Console.WriteLine("Заполните массив из 7 элементов");

            double[] arr = new double[7];
            double Sum = 0;
            for (int i = 0; i < arr.Length; ++i) 
            {
                Console.Write("Введите число: ");
                arr[i] = Convert.ToDouble(Console.ReadLine());
                Sum += arr[i];
            }
            Console.WriteLine("Среднее арифметическое значение элементов равно {0:F2}", (Sum / arr.Length));
        }

        static void MinMax()
        {
            Console.WriteLine("Задание на нахождение мин. и макс. чисел\n");
            int[] arr = new int[15];
            Random rand = new Random();

            Console.Write("Массив [");
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rand.Next(0, 51);
                Console.Write(" {0} ", arr[i]);
            }
            Console.WriteLine(']');

            int min = arr[0];
            int max = arr[0];

            for (int i = 1; i < arr.Length; ++i)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max) 
                {
                    max = arr[i];
                }
            }

            Console.WriteLine("Сумма минимального и максимального чисел равна: {0} + {1} = {2}", min, max, (min + max));
        }

        static void Sort()
        {
            Console.WriteLine("Задание на сортировку\n");
            int[] arr = new int[10];
            Random rand = new Random();

            Console.Write("Массив до сортировки [");
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rand.Next(-50, 51);
                Console.Write(" {0} ", arr[i]);
            }
            Console.WriteLine(']');

            #region Сортировка первых 5ти эл-ов
            for (int i = 0; i < 4; ++i)
            {
                for (int j = i + 1; j < 5; ++j)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            #endregion
            #region Сортировка последних 5ти эл-ов
            for (int i = 5; i < 9; ++i)
            {
                for (int j = i + 1; j < 10; ++j)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            #endregion

            Console.Write("Массив после сортировки [");
            foreach (int num in arr)
            {
                Console.Write(" {0} ", num);
            }
            Console.WriteLine(']');
        }

        static void OddCount()
        {
            Console.WriteLine("Задание на подсчет\n");
            int[] arr = new int[20];
            Random rand = new Random();

            int count = 0;

            Console.Write("Массив [");
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rand.Next(-50, 51);
                Console.Write(" {0} ", arr[i]);

                if ((i + 1) % 2 == 0
                    && arr[i] > 0
                    && arr[i] % 2 != 0)
                {
                    ++count;
                }
            }
            Console.WriteLine(']');

            Console.WriteLine("Количество нечетных положительных элементов, стоящих на четных местах равно {0}", count);
        }

        static void Matrix()
        {
            Console.WriteLine("Задание на построение двумерного массива\n");
            
            Console.Write("Введите размер матрицы: ");
            int N = Convert.ToInt16(Console.ReadLine());
            byte[,] arr = new byte[N, N];

            Console.WriteLine("Полученная матрица");
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    if ((i + j) % 2 == 0)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }
                    Console.Write(" {0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void MagicSquare()
        {
            Console.WriteLine("Задание на магический квадрат\n");
            Console.Write("Введите размер матрицы: ");
            int N = Convert.ToInt16(Console.ReadLine());
            int[,] arr = new int[N, N];
            int[] sums = new int[2*N + 2];
            for (int i = 0; i < sums.Length; i++)
            {
                sums[i] = 0;
            }

            Console.WriteLine("Заполните матрицу размером {0}x{0}", N);
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    arr[i,j] = Convert.ToInt16(Console.ReadLine());
                    sums[i] += arr[i, j];
                    sums[j + N] += arr[i, j];

                    if (i == j)
                    {
                        sums[2 * N] += arr[i, j];
                    }
                    if ((i + j) == (N - 1))
                    {
                        sums[2 * N + 1] += arr[i, j];
                    }
                }
            }

            Console.WriteLine("Полученная матрица");
            for (int i = 0; i < N; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    Console.Write(" {0} ", arr[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 1; i < sums.Length; ++i) 
            { 
                if (sums[i - 1] != sums[i])
                {
                    Console.WriteLine("Данный квадрат не является магическим");
                    return;
                }
            }
            Console.WriteLine("Данный квадрат является магическим");
        }

        static void Main(string[] args)
        {
            Average();
            Console.WriteLine(new string('-', 100));
            MinMax();
            Console.WriteLine(new string('-', 100));
            Sort();
            Console.WriteLine(new string('-', 100));
            OddCount();
            Console.WriteLine(new string('-', 100));
            Matrix();
            Console.WriteLine(new string('-', 100));
            MagicSquare();

            Console.ReadKey();
        }
    }
}
