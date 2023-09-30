using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGC
{
    internal class Car
    {
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }
        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        
        public override string ToString()
        {
            return $"{PetName} is going {CurrentSpeed} MPH";
        }

    }
}
