using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;


namespace Task16_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание про товары. Часть сериализации\n");

            const int n = 3;
            Product[] products = new Product[n];

            Console.WriteLine($"Опишите {n} товаров");
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine($"Товар #{i + 1}");
                Console.Write("Код товара: ");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.Write("Название товара: ");
                string name = Console.ReadLine();
                Console.Write("Цена товара: ");
                double price = Convert.ToDouble(Console.ReadLine());

                products[i] = new Product(code, name, price);
                Console.WriteLine();
            }

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(products, options);

            using (StreamWriter sw = new StreamWriter("../../../Products.json", false))
            {
                sw.WriteLine(jsonString);
            }
        }
    }
}
