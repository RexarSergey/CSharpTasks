using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task8
{
    internal class Program
    {
        static string path = @"D:\Work\VisualStudio2022\CSharpTasks\Task8\temp";

        static void ReadFiles()
        {
            Console.WriteLine("Задача про чтение файлов\n");

            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }

        static void ReadDigits()
        {
            Console.WriteLine("Задача про цифры в файле\n");

            string file_path = path + @"\nums.txt";
            Random rand = new Random();

            using (StreamWriter sw = new StreamWriter(file_path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(rand.Next(-5, 11));
                }
            }

            int sum = 0;
            using (StreamReader sr = new StreamReader(file_path))
            {
                for (int i = 0; i < 10; i++)
                {
                    sum += Convert.ToInt16(sr.ReadLine());
                }
            }
            Console.WriteLine("Сумма цифр равна: {0}", sum);
        }

        static void ReadText()
        {
            Console.WriteLine("Задача про текст в файле\n");

            string file_path = path + @"\text.txt";

            int symbol_num = 0;
            int row_num = 0;
            int word_num = 0;
            using (StreamReader sr = new StreamReader(file_path))
            {
                while (true)
                {
                    string row = sr.ReadLine();
                    if (row == null)
                        break;

                    row_num++;
                    symbol_num += row.Length;
                    word_num += row.Trim().Split().GetLength(0);
                }
            }

            Console.WriteLine("Количество символов в тексте: {0}", symbol_num);
            Console.WriteLine("Количество строк в тексте: {0}", row_num);
            Console.WriteLine("Количество слов в тексте: {0}", word_num);
        }

        static void Main(string[] args)
        {
            ReadFiles();
            Console.WriteLine(new string('-', 100));
            ReadDigits();
            Console.WriteLine(new string('-', 100));
            ReadText();


            Console.ReadKey();
        }
    }
}
