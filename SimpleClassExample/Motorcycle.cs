using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    internal class Motorcycle
    {
        public int driverIntensity;
        public string driverName;
        public Motorcycle()
        {
            Console.WriteLine("В стандартном конструкторе");
        }
        public Motorcycle(int intensity): this(intensity, "") 
        {
            Console.WriteLine("Внутри конструктора принимающего значение int");
        }
        public Motorcycle(string name): this (0,name) 
        {
            Console.WriteLine("В конструкторе принимающего значение string");
        }
        public Motorcycle(int intensity, string name)
        {
            Console.WriteLine("Внутри главного конструктора");
            if (intensity > 10) intensity = 10;
            driverIntensity = intensity;
            driverName = name;

        }

        
        public void PopAWheely()
        {
            for (int i = 0; i < driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeeee Haaaaaaaawwww!");
            }
        }
        public void SetDriverName(string name) => driverName = name;


    }
}
