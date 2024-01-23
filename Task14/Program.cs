using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание про животных\n");

            Cat cat = new Cat("Рыжик");
            Dog dog = new Dog("Тузик");

            cat.ShowInfo();
            Console.WriteLine();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}
