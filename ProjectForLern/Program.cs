using System.Drawing;
using System.Threading.Channels;

namespace ProjectForLern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Point point = new Point(5, 4);

            // var pointValue = point.Deconstruct();

            //Console.WriteLine(pointValue.yPos);

            //typeof(A).Attributes.ToString();
            Console.WriteLine(typeof(A).Attributes.ToString());
            Console.WriteLine(typeof(A).GetCustomAttributes(true));
        }
    }

    class A { }

    struct Point
    {
        private int x;
        private int y;
        public Point(int xPos, int yPos)
        {
            x = xPos;
            y = yPos;
        }
        public (int xPos, int yPos) Deconstruct()
        {
            return (x, y);
        }

        static string GetQuadrant(Point p)
        {
            return p.Deconstruct() switch
            {
                var (x,y) when x > 0 && y > 0 => "origin"
            };
        }
    }




}