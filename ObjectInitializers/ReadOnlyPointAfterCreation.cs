using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    internal class ReadOnlyPointAfterCreation
    {
        public int X { get; init; }
        public int Y { get; init; }

        public ReadOnlyPointAfterCreation()
        {
            
        }
        public ReadOnlyPointAfterCreation(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void DisplayStats()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }

    }
}
