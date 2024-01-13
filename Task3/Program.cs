using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {

        static void Rectangle()
        {
            Console.WriteLine("Задание про прямоугольник\n");
            #region Ввод координат
            Console.WriteLine("Введите значение координат первой вершины: ");

            int X1 = Convert.ToInt16(Console.ReadLine());
            int Y1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nВведите значение координат второй вершины: ");

            int X2 = Convert.ToInt16(Console.ReadLine());
            int Y2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nВведите значение координат третьей вершины: ");

            int X3 = Convert.ToInt16(Console.ReadLine());
            int Y3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            #endregion

            int X4 = 0;
            bool FlagX = false;
            int Y4 = 0;
            bool FlagY = false;

            #region Определение X4
            if (X1 == X2)
            {
                X4 = X3;
                FlagX = true;
            }
            else if (X1 == X3)
            {
                X4 = X2;
                FlagX = true;
            }
            else if (X2 == X3)
            {
                X4 = X1;
                FlagX = true;
            }
            #endregion
            #region Определение Y4
            if (Y1 == Y2)
            {
                Y4 = Y3;
                FlagY = true;
            }
            else if (Y1 == Y3)
            {
                Y4 = Y2;
                FlagY = true;
            }
            else if (Y2 == Y3)
            {
                Y4 = Y1;
                FlagY = true;
            }
            #endregion

            if (FlagX && FlagY)
            {
                Console.WriteLine("Координаты четвертой точки : ({0}, {1})", X4, Y4);
            }
            else
            {
                Console.WriteLine("Четвертой точки нет");
            }
        }

        static void ThreePoints()
        {
            Console.WriteLine("Задание про три точки\n");
            #region Ввод координат
            Console.Write("Введите координату точки A: ");
            int A = Convert.ToInt16(Console.ReadLine());

            Console.Write("Введите координату точки B: ");
            int B = Convert.ToInt16(Console.ReadLine());

            Console.Write("Введите координату точки C: ");
            int C = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            #endregion

            int len1 = Math.Abs(A - B);
            int len2 = Math.Abs(A - C);

            if (len1 < len2)
            {
                Console.WriteLine("Точка B расположена ближе к точке A");
            }
            else if (len2 < len1)
            {
                Console.WriteLine("Точка B расположена ближе к точке C");
            }
            else
            {
                Console.WriteLine("Точки B и C равноудалены от точки A");
            }
        }

        static void Ages()
        {
            Console.WriteLine("Задание на года\n");
            Console.Write("Введите число из отрезка [20, 69]: ");
            int AgeInt = Convert.ToInt16(Console.ReadLine());

            if (AgeInt < 20 || AgeInt > 69)
            {
                Console.WriteLine("Число должно распологаться на отрезке [20, 69]");
                return;
            }

            string AgeStr = "";
            #region Определение десятков
            switch (AgeInt / 10)
            {
                case 2:
                    AgeStr += "двадцать ";
                    break;
                case 3:
                    AgeStr += "тридцать ";
                    break;
                case 4:
                    AgeStr += "сорок ";
                    break;
                case 5:
                    AgeStr += "пятьдесят ";
                    break;
                case 6:
                    AgeStr += "шестьдесят ";
                    break;
                default:
                    break;
            }
            #endregion
            #region Определение единиц
            switch (AgeInt % 10)
            {
                case 0:
                    AgeStr += "лет";
                    break;
                case 1:
                    AgeStr += "один год";
                    break;
                case 2:
                    AgeStr += "два года";
                    break;
                case 3:
                    AgeStr += "три года";
                    break;
                case 4:
                    AgeStr += "четыре года";
                    break;
                case 5:
                    AgeStr += "пять лет";
                    break;
                case 6:
                    AgeStr += "шесть лет";
                    break;
                case 7:
                    AgeStr += "семь лет";
                    break;
                case 8:
                    AgeStr += "восемь лет";
                    break;
                case 9:
                    AgeStr += "девять лет";
                    break;
                default:
                    break;
            }
            #endregion

            Console.WriteLine("Строковое представление числа: \"{0}\"", AgeStr);
        }

        static void Numbers()
        {
            Console.WriteLine("Задание про число\n");
            Console.Write("Введите число из отрезка [100, 999]: ");

            int Number = Convert.ToInt16(Console.ReadLine());

            if (Number < 100 || Number > 999)
            {
                Console.WriteLine("Число должно распологаться на отрезке [100, 999]");
                return;
            }

            string NumString = "";
            #region Определение сотен
            switch (Number / 100)
            {
                case 1:
                    NumString += "сто";
                    break;
                case 2:
                    NumString += "двести";
                    break;
                case 3:
                    NumString += "триста";
                    break;
                case 4:
                    NumString += "четыресиа";
                    break;
                case 5:
                    NumString += "пятьсот";
                    break;
                case 6:
                    NumString += "шестьсот";
                    break;
                case 7:
                    NumString += "семьсот";
                    break;
                case 8:
                    NumString += "восемьсот";
                    break;
                case 9:
                    NumString += "девятьсот";
                    break;
                default:
                    break;
            }
            #endregion

            if (Number % 100 > 9 && Number % 100 < 20)
            {
                #region Определение числа на отрезке [10, 19]
                switch (Number % 100)
                {
                    case 10:
                        NumString += " десять";
                        break;
                    case 11:
                        NumString += " одиннадцать";
                        break;
                    case 12:
                        NumString += " двенадцать";
                        break;
                    case 13:
                        NumString += " тринадцать";
                        break;
                    case 14:
                        NumString += " четырнадцать";
                        break;
                    case 15:
                        NumString += " пятнадцать";
                        break;
                    case 16:
                        NumString += " шестнадцать";
                        break;
                    case 17:
                        NumString += " семнадцать";
                        break;
                    case 18:
                        NumString += " восемнадцать";
                        break;
                    case 19:
                        NumString += " девятнадцать";
                        break;
                    default:
                        break;
                }
                #endregion
            }
            else
            {
                #region Определение десятков
                switch (Number % 100 / 10)
                {
                    case 2:
                        NumString += " двадцать";
                        break;
                    case 3:
                        NumString += " тридцать";
                        break;
                    case 4:
                        NumString += " сорок";
                        break;
                    case 5:
                        NumString += " пятьдесят";
                        break;
                    case 6:
                        NumString += " шестьдесят";
                        break;
                    case 7:
                        NumString += " семьдесят";
                        break;
                    case 8:
                        NumString += " восемьдесят";
                        break;
                    case 9:
                        NumString += " девяносто";
                        break;
                    default:
                        break;
                }
                #endregion
                #region Определение единиц
                switch (Number % 10)
                {
                    case 1:
                        NumString += " один";
                        break;
                    case 2:
                        NumString += " два";
                        break;
                    case 3:
                        NumString += " три";
                        break;
                    case 4:
                        NumString += " четыре";
                        break;
                    case 5:
                        NumString += " пять";
                        break;
                    case 6:
                        NumString += " шесть";
                        break;
                    case 7:
                        NumString += " семь";
                        break;
                    case 8:
                        NumString += " восемь";
                        break;
                    case 9:
                        NumString += " девять";
                        break;
                    default:
                        break;
                }
                #endregion
            }

            Console.WriteLine("\nПредставление числа в текстовом виде: \"{0}\"", NumString);
        }

        static void Main(string[] args)
        {
            Rectangle();
            Console.WriteLine(new string('-', 100));
            ThreePoints();
            Console.WriteLine(new string('-', 100));
            Ages();
            Console.WriteLine(new string('-', 100));
            Numbers();

            Console.ReadKey();
        }
    }
}
