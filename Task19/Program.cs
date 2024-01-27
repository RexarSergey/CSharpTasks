using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19
{
    class Computer
    {
        public int Code { get; set; }
        public string Mark { get; set; }
        public string Type { get; set; }
        public int Frequency { get; set; }
        public int RAM { get; set; }
        public int DriveMemory { get; set; }
        public int VideCardMemory { get; set; }
        public double Price { get; set; }
        public int Number { get; set; }
    }

    

    internal class Program
    {
        static void PrintList(List<Computer> c)
        {
            foreach (Computer comp in c) 
            {
                Console.WriteLine($"{comp.Code}\t{comp.Mark}\t\t{comp.Type}\t{comp.Frequency}\t{comp.RAM}\t{comp.DriveMemory}\t{comp.VideCardMemory}\t{comp.Price}\t\t{comp.Number}");
            }
        }

        static void PrintGroup(List<IGrouping<string, Computer>> g)
        {
            foreach (var group in g)
            {
                Console.WriteLine($"Группа \"{group.Key}\"");

                foreach (var comp in group)
                {
                    Console.WriteLine($"{comp.Code}\t{comp.Mark}\t{comp.Frequency}\t{comp.RAM}\t{comp.DriveMemory}\t{comp.VideCardMemory}\t{comp.Price}\t\t{comp.Number}");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>
            {
                new Computer(){ Code = 1, Mark = "HP", Type = "Intel Core i7", Frequency = 3000, RAM = 32, DriveMemory = 1024, VideCardMemory = 16, Price = 1134.68, Number = 37},
                new Computer(){ Code = 2, Mark = "Dell", Type = "AMD Ryzen 5", Frequency = 1200, RAM = 16, DriveMemory = 2048, VideCardMemory = 8, Price = 1083.4, Number = 8},
                new Computer(){ Code = 3, Mark = "Thunder", Type = "Intel Core i5", Frequency = 2000, RAM = 32, DriveMemory = 2048, VideCardMemory = 8, Price = 1196.09, Number = 19},
                new Computer(){ Code = 4, Mark = "Thunder", Type = "AMD Ryzen 7", Frequency = 1200, RAM = 16, DriveMemory = 1024, VideCardMemory = 16, Price = 981.83, Number = 36},
                new Computer(){ Code = 5, Mark = "Dell", Type = "Intel Core i7", Frequency = 1000, RAM = 8, DriveMemory = 3072, VideCardMemory = 4, Price = 1122.64, Number = 41},
                new Computer(){ Code = 6, Mark = "Dell", Type = "AMD Ryzen 9", Frequency = 2000, RAM = 8, DriveMemory = 1024, VideCardMemory = 4, Price = 1123.78, Number = 13},
                new Computer(){ Code = 7, Mark = "HP", Type = "AMD Ryzen 9", Frequency = 1200, RAM = 32, DriveMemory = 2048, VideCardMemory = 16, Price = 1091.1, Number = 59},
                new Computer(){ Code = 8, Mark = "Thunder", Type = "Intel Core i7", Frequency = 3000, RAM = 16, DriveMemory = 2048, VideCardMemory = 8, Price = 1025.18, Number = 18},
                new Computer(){ Code = 9, Mark = "HP", Type = "Intel Core i5", Frequency = 3000, RAM = 8, DriveMemory = 1024, VideCardMemory = 16, Price = 857.41, Number = 12},
                new Computer(){ Code = 10, Mark = "Dell", Type = "AMD Ryzen 9", Frequency = 1200, RAM = 16, DriveMemory = 3072, VideCardMemory = 8, Price = 1117.99, Number = 25}
            };
            List<Computer> selected;


            Console.WriteLine("Задание про БД\n");

            Console.Write("Введите имя процессора: ");
            string type = Console.ReadLine();
            selected = computers
                .Where(d => d.Type == type)
                .ToList();
            PrintList(selected);
            Console.WriteLine();

            Console.Write("Введите количество ОП: ");
            int ram = Convert.ToInt16(Console.ReadLine());
            selected = computers
                .Where(d => d.RAM >= ram)
                .ToList();
            PrintList(selected);
            Console.WriteLine();

            Console.WriteLine("Отсортированный лист по цене:");
            selected = computers
                .OrderBy(d => d.Price)
                .ToList();
            PrintList(selected);
            Console.WriteLine();

            Console.WriteLine("Отсортированный по группе процессоров:");
            var groups = computers.GroupBy(d => d.Type).ToList();
            PrintGroup(groups);
            Console.WriteLine();

            Console.WriteLine("Самый дорогой компьютер:");
            var s = computers
                .OrderBy(comp => comp.Price)
                .LastOrDefault();
            Console.WriteLine($"{s.Code}\t{s.Mark}\t\t{s.Type}\t{s.Frequency}\t{s.RAM}\t{s.DriveMemory}\t{s.VideCardMemory}\t{s.Price}\t\t{s.Number}");

            Console.WriteLine("Самый дешевый компьютер:");
            s = computers
                .OrderBy(comp => comp.Price)
                .FirstOrDefault();
            Console.WriteLine($"{s.Code}\t{s.Mark}\t\t{s.Type}\t{s.Frequency}\t{s.RAM}\t{s.DriveMemory}\t{s.VideCardMemory}\t{s.Price}\t\t{s.Number}");

            Console.WriteLine("Есть ли хотя-бы один компьютер в количестве не менее 30 штук?");
            bool answer = computers.Any(d => d.Number >= 30);
            Console.WriteLine("Ответ: {0}", (answer ? "Да" : "Нет"));

            Console.ReadKey();
        }
    }
}
