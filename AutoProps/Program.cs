using AutoProps;

Car car = new Car();
car.PetName = "Frank";
car.Color = "Red";
car.Speed = 55;

Garage garage = new Garage();
garage.MyAuto = car;

Console.WriteLine(garage.NumberOfCars);
Console.WriteLine(garage.MyAuto.PetName);

Circle circle = new Circle("Circle");
Console.WriteLine(circle.PetName);
circle.Draw();

