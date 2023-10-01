using CloneablePoint;



Point p1 = new Point(50,50);
Point p2 = p1;
p2.X = 0;
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.ReadLine();

Point p3 = new Point(100,100,"Jane");
Point p4 = (Point)p3.Clone();

Console.WriteLine("Перед модификацией:");
Console.WriteLine($"p3 {p3}");
Console.WriteLine($"p4 {p4}");
p4.desc.PetName = "My new point";
p4.X = 9;

Console.WriteLine("После модификации:");
Console.WriteLine($"p3 {p3}");
Console.WriteLine($"p4 {p4}");
Console.ReadLine();