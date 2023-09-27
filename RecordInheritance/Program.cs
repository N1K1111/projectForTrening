using RecordInheritance;

Car c = new Car("Honda","Pilot","black");
MiniVan mini = new MiniVan(c.Make,c.Model,c.Color,10);

Console.WriteLine(mini.Color);
Console.WriteLine("------------");
Console.WriteLine(mini is Car);
Console.WriteLine(mini is MiniVan);
Console.WriteLine("---------------");
Console.WriteLine(c is Car);
Console.WriteLine(c is MiniVan);

PositionalCar pc = new PositionalCar("Honda","Pilot","Blue");
PosotionalMiniVan pm = new PosotionalMiniVan("Honda", "Pilot", "Blue");
