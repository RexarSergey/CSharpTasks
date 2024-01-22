using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание про здания\n");

            Building b = new Building("Popova", 123, 43, 33);
            Console.WriteLine(b.Print());

            MultiBuilding mb = new MultiBuilding("Kucherov", 123, 123, 32, 5);
            Console.WriteLine(mb.Print());

            Console.ReadKey();
        }
    }
}
