using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание про угол\n");

            Console.WriteLine("Введите значение угла");
            
            Console.Write("Градусы: ");
            double gradus = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Минут: ");
            double min = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Секунды: ");
            double sec = Convert.ToDouble(Console.ReadLine());

            Angle angle = new Angle(gradus, min, sec);

            Console.WriteLine("\nГрадусы в радианы: {0:F2}", angle.ToRadans());
            Console.ReadKey();
        }
    }
}
