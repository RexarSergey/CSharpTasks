using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание про банк\n");

            Console.WriteLine("Счет Integer");
            Bank<int> bankInt = new Bank<int>();
            bankInt.InputInfo();
            bankInt.WriteInfo();
            Console.WriteLine();

            Console.WriteLine("Счет Double");
            Bank<double> bankDouble = new Bank<double>();
            bankDouble.InputInfo();
            bankDouble.WriteInfo();
            Console.WriteLine();

            Console.WriteLine("Счет String");
            Bank<string> bankString = new Bank<string>();
            bankString.InputInfo();
            bankString.WriteInfo();
            Console.WriteLine();

            Console.ReadKey();
        }
    }

    internal class Bank<T>
    {
        public T Id { get; set; }
        public double Balance { get; set; }
        public string Owner { get; set; }


        public void InputInfo()
        {
            Console.Write("Номер счета: ");
            Id = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            Console.Write("Баланс счета: ");
            Balance = Convert.ToDouble(Console.ReadLine());

            Console.Write("ФИО владельца счета: ");
            Owner = Console.ReadLine();
        }

        public void WriteInfo()
        {
            Console.WriteLine($"Счет: {Id}\nБаланс счета: {Balance}\nВладелец счета: {Owner}");
        }
    }
}
