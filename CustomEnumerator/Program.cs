using CustomEnumerator;
using System.Collections;

Garage carLot =  new Garage();

foreach (Car item in carLot)
{
    Console.WriteLine($"{item.PetName} is going {item.CurentSpeed} MPH");
}

