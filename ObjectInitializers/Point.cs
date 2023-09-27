using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    internal class Point
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public PointColorEnum Color { get; set; }

        public Point(PointColorEnum color) => Color = color;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
            Color = PointColorEnum.Gold;
        }
        public Point() : this(PointColorEnum.BloodRed) { }
        public void DisplayStats()
        {
            Console.WriteLine($"X = {X}");
            Console.WriteLine($"Y = {Y}");
            Console.WriteLine($"Point is {Color}");
        }


    }
}
