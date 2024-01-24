using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание про скобки\n");

            Console.WriteLine("Введите строку состоящую из скобок \'()[]{}\'");
            string str = Console.ReadLine();


            if (CheckStr(str))
            {
                Console.WriteLine("Скобки расставлены верно");
            }
            else
            {
                Console.WriteLine("Скобки расставлены не верно");
            }
            Console.ReadKey();
        }

        static bool CheckStr(string str)
        {
            Stack<char> s = new Stack<char>();
            Dictionary<char, char> d = new Dictionary<char, char>
            {
                {'(', ')'},
                {'[', ']'},
                {'{', '}'}
            };

            foreach (char c in str)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    s.Push(d[c]);
                }
                else if (s.Count() == 0 || s.Pop() != c)
                {
                    return false;
                }
                else
                {
                    s.Pop();
                }
            }

            if (s.Count() == 0)
            {
                return true;
            }
            return false;
        }
    }
}
