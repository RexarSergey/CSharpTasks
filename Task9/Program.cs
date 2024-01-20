using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first, second, action;

            Console.WriteLine("Калькулятор на связи\n");

            try
            {
                Console.Write("Введите первое целове число: ");
                first = Convert.ToInt32(Console.ReadLine());


                Console.Write("Введите второе целове число: ");
                second = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("\nВведите код операции:");
                Console.WriteLine("\t1 - сложение");
                Console.WriteLine("\t2 - вычитание");
                Console.WriteLine("\t3 - произведение");
                Console.WriteLine("\t4 - частное");

                Console.Write("Код операции: ");
                action = Convert.ToInt32(Console.ReadLine());


                switch (action)
                {
                    case 1:
                        Console.WriteLine("{0} + {1} = {2}", first, second, (first + second));
                        break;
                    case 2:
                        Console.WriteLine("{0} - {1} = {2}", first, second, (first - second));
                        break;
                    case 3:
                        Console.WriteLine("{0} * {1} = {2}", first, second, (first * second));
                        break;
                    case 4:
                        Console.WriteLine("{0} / {1} = {2}", first, second, (first / second));
                        break;
                    default:
                        Console.WriteLine("Такой операции нет");
                        break;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Невернный формат вводных данных");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка! Попытка деления числа на 0");
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
