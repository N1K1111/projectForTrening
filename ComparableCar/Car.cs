using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar;

internal class Car : IComparable
{
    public const int MaxSpeed = 100;
    public int CarID { get; set; }
    public int CurentSpeed { get; set; } = 0;
    public string PetName { get; set; } = "";
    public static IComparer SortByPetName => (IComparer) new PetNameComparer(); 

    private bool _carIsDead;
    private readonly Radio _theMusicBox = new Radio();

    public Car() { }
    public Car(string name, int speed, int id)
    {
        PetName = name;
        CurentSpeed = speed;
        CarID = id;
    }
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

    public int CompareTo(object? obj)
    {

        if (obj is Car temp)
        {
            return this.CarID.CompareTo(temp.CarID);
        }
        throw new Exception("Не является обхектом типа Car");
        //return this.CarID.CompareTo(other.CarID);

        //if (this.CarID > other.CarID)
        //{
        //    return 1;
        //}
        //if (this.CarID < other.CarID)
        //{
        //    return -1;
        //}
        //return 0;

    }
}
