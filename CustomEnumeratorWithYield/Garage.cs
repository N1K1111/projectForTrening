using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYield

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

        public IEnumerator GetEnumerator()
        {
            //throw new Exception("This will get called");

            return ActualImplementation();

            IEnumerator ActualImplementation()
            {
                foreach (Car car in carArray)
                {
                    yield return car;
                }
            }
        }

        //public IEnumerator GetEnumerator()
        //{
        //    throw new Exception("This won't get called");
        //    foreach (Car car in carArray)
        //    {
        //        yield return car;
        //    }
        //}


        public IEnumerable GetTheCars(bool returnReversed)
        {
            return ActualImplementation();

            IEnumerable ActualImplementation()
            {
                if (returnReversed)
                {
                    for (int i = carArray.Length; i != 0; i--)
                    {
                        yield return carArray[i - 1];
                    }
                }
                else
                    foreach(Car car in carArray) yield return car;
            }
        }
    }
}
