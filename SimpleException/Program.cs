using SimpleException;


Car car = new Car("Zippy",20);
car.CurrentTunes(true);
for (int i = 0; i < 10; i++)
{
    car.Accelerate(10);
}
Console.ReadLine();