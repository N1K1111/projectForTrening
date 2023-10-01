using ComparableCar;



Car[] myAutos = new Car[5];
myAutos[0] = new Car("Rusti",80,1);
myAutos[1] = new Car("Mary",40,234);
myAutos[2] = new Car("Viper",40,34);
myAutos[3] = new Car("Mel",40,4);
myAutos[4] = new Car("Chucky",40,5);

Array.Sort(myAutos, Car.SortByPetName);

foreach (Car c in myAutos)
{
    Console.WriteLine(c.CarID);
}


Console.ReadLine();




