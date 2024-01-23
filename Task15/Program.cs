using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание про интерфейсы\n");
            int firstVal = 3;
            int step = 2;


            Console.WriteLine("Арифметическая последовательность");
            Console.WriteLine($"Начальное значение {firstVal} с шагом {step}");
            
            ArithProgression ap = new ArithProgression();
            ap.SetStart(firstVal);
            ap.SetStep(step);
            Console.WriteLine($"{ap.GetNext()} {ap.GetNext()} {ap.GetNext()} {ap.GetNext()} {ap.GetNext()}");
            ap.Reset();
            Console.WriteLine($"{ap.GetNext()}\n");


            Console.WriteLine("Геометрическая последовательность");
            Console.WriteLine($"Начальное значение {firstVal} с шагом {step}");

            GeomProgression gp = new GeomProgression();
            gp.SetStart(firstVal);
            gp.SetStep(step);
            Console.WriteLine($"{gp.GetNext()} {gp.GetNext()} {gp.GetNext()} {gp.GetNext()} {gp.GetNext()}");
            gp.Reset();
            Console.WriteLine($"{gp.GetNext()}");

            Console.ReadKey();
        }
    }
}
