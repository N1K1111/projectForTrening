using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    internal class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];

        public Garage()
        {
            carArray[0] = new Car("Rusty",30);
            carArray[1] = new Car("Clinker",55);
            carArray[2] = new Car("Zippy",30);
            carArray[3] = new Car("Fred",30);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return carArray.GetEnumerator();
        }
    }
}
