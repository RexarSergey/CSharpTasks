using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;


namespace Task16_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание про товары. Часть десериализации\n");

            string jsonString;
            using (StreamReader sr = new StreamReader("../../../Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }

            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            double max_price = -1;
            string name = "";
            Console.WriteLine("Прочитанные продукты");
            foreach (Product p in products)
            {
                Console.WriteLine($"Код: {p.Code}\nНазвание: {p.Name}\nЦена: {p.Price:F2}");
                Console.WriteLine();
                
                if (p.Price > max_price)
                {
                    max_price = p.Price;
                    name = p.Name;
                }
            }

            Console.WriteLine($"Название самого дорогого товара: {name}");
            Console.ReadKey();
        }
    }
}
