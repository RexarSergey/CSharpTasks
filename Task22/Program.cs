using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание на параллельное программирование\n");

            Console.Write("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Func<object, int[]> func1 = new Func<object, int[]>(GetArray);
            Task<int[]> task1 = new Task<int[]>(func1, n);

            Func<Task<int[]>, int> func2 = new Func<Task<int[]>, int>(GetArraySum);
            Task<int> task2 = task1.ContinueWith(func2);

            Func<Task<int[]>, int> func3 = new Func<Task<int[]>, int>(GetArrayMax);
            Task<int> task3 = task1.ContinueWith(func3);

            Action<Task<int[]>> func4 = new Action<Task<int[]>>(PrintArray);
            Task task4 = task1.ContinueWith(func4);

            task1.Start();
            Console.ReadKey();
        }

        static int[] GetArray(object a)
        {
            Console.WriteLine("Начало работы функции генерации массива");
            int n = (int)a;
            int[] array = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++) 
            {
                array[i] = r.Next(0, 101);
            }

            Console.WriteLine("Окончание работы функции генерации массива\n");
            return array;
        }

        static int GetArraySum(Task<int[]> task)
        {
            Console.WriteLine("Начало работы функции по поиску суммы массива");
            int[] arr = task.Result;
            int sum = 0;
            for (int i = 0;i < arr.Count(); i++) 
            {
                sum += arr[i];
            }

            Console.WriteLine($"Окончание работы функции по поиску суммы массива. Сумма равна {sum}\n");
            return sum;
        }

        static int GetArrayMax(Task<int[]> task)
        {
            Console.WriteLine("Начало работы функции по поиску максимума в массиве");
            int[] arr = task.Result;
            int max = arr[0];
            for (int i = 1; i < arr.Count(); i++) 
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"Окончание работы функции по поиску максимума в массиве. Максимум равен {max}\n");
            return max;
        }

        static void PrintArray(Task<int[]> task)
        {
            Console.WriteLine("Начало работы функции по выводу массива");
            int[] arr = task.Result;
            for (int i = 0; i < arr.Count(); i++) 
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Окончание работы функции по выводу массива\n");
        }
    }
}
