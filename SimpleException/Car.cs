using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    internal class Car
    {
        public const int MaxSpeed = 100;

        public int CurentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        private bool _carIsDead;
        private readonly Radio _theMusicBox = new Radio();

        public Car() { }
        public Car(string name, int speed)
        {
            PetName = name;
            CurentSpeed = speed;
        }

        public void CurrentTunes(bool state)
        {
            _theMusicBox.TurnOn(state);
        }

        public void Accelerate(int delta)
        {
            if (_carIsDead) Console.WriteLine($"{PetName} is out of order ...");
            else
            {
                CurentSpeed += delta;
                if(CurentSpeed >= MaxSpeed)
                {
                    CurentSpeed = 0;
                    _carIsDead = true;
                    throw new Exception($"{PetName} has overheated !");
                }
                Console.WriteLine($"=> CurentSpeed => {CurentSpeed}");
            }

        }

    }
}
