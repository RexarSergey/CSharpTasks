using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    internal sealed class MultiBuilding : Building
    {
        public int Floor {  get; set; }

        public MultiBuilding(string address, double length, double width, double height, int floor)
            : base (address, length, width, height)
        {
            Floor = Floor;
        }

        public new string Print()
        {
            return base.Print() + $" {Floor}";
        }
    }
}
