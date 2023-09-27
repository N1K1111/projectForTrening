using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    internal class Circle : Shape
    {
        public int Radius {  get; set; }

        public Circle() { }
        public Circle(string name) : base(name) { }
        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine("Логика переопределенного метода Draw...");


        }
    }
}
