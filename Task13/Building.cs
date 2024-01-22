using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    internal class Building
    {
        public string Address { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Building(string address, double length, double width, double height) 
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }

        public string Print()
        {
            return $"{Address} {Length} {Width} {Height}";
        }
    }
}
