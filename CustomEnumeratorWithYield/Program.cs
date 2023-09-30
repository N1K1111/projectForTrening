using CustomEnumeratorWithYield;
using System.Collections;


Garage garage = new Garage();


foreach(Car c in garage)
{
    Console.WriteLine($"{c.PetName} is going {c.CurentSpeed} MPH");
}
Console.WriteLine();

foreach (Car c in garage.GetTheCars(true))
{
    Console.WriteLine($"{c.PetName} is going {c.CurentSpeed} MPH");
}
Console.ReadLine();