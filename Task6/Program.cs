using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6
{
    internal class Program
    {

        static void SplitString()
        {
            Console.WriteLine("Задание на разделение строки\n");
            Console.WriteLine("Введите предложение:");

            string str = Console.ReadLine();
            string[] atrArr = str.Split();
            string maxLenStr = atrArr[0];
            foreach (string s in atrArr)
            {
                if (s.Length > maxLenStr.Length)
                {
                    maxLenStr = s;
                }
            }

            Console.WriteLine("\nСаммым длинным словом в предложении является: \"{0}\"", maxLenStr);
        }

        static void Palindrome()
        {
            Console.WriteLine("Задание на определение палиндрома\n");
            Console.WriteLine("Введите предложение:");

            string str = Console.ReadLine();
            string[] atrArr = str.Split();
            string oneStr = string.Join("", atrArr).ToLower();
            Console.WriteLine();

            int i = 0;
            int len = oneStr.Length;
            while (i < (len / 2))
            {
                if (oneStr[i] != oneStr[len - 1 - i])
                {
                    Console.WriteLine("Предложение не является палиндромом");
                    return;
                }
                ++i;
            }
            Console.WriteLine("Предложение является палиндромом");
        }

        static void Deleting()
        {
            Console.WriteLine("Задание на удаление подстроки\n");
            Console.WriteLine("Введите строку:");

            string str = Console.ReadLine();

            string strAns = Regex.Replace(str, @"(?<={)[\d\D]+(?=})", "");

            Console.WriteLine("\nПолученная строка:\n{0}", strAns);
        }

        static void Main(string[] args)
        {
            //SplitString();
            Console.WriteLine(new string('-', 100));
            //Palindrome();
            Console.WriteLine(new string('-', 100));
            Deleting();

            Console.ReadKey();
        }
    }
}
