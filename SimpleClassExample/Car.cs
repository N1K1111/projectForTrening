﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    internal class Car
    {
        public string petName;
        public int currSpeed;

        public Car() 
        {
            petName = "Chuck";
            currSpeed = 10;
        }
        public Car(string pn) => 
            petName = pn;

        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }
        public Car(string pn, int cs, out bool inDanger)
        {
            petName = pn;
            currSpeed = cs;
            if (cs > 100) inDanger = true;
            else inDanger = false;
        }

        public void PrintState() =>
            Console.WriteLine($"{petName} is going {currSpeed} MPH");

        public void SpeedUp(int delta) =>
            currSpeed += delta;

    }
}
