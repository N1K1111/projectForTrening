using SimpleGC;

Console.WriteLine($"Вывести колличество байтов,выделенных в куче: {GC.GetTotalMemory(false)}");
Console.WriteLine($"Максимальное колличество поколений: {GC.MaxGeneration + 1}");

Car myCar = new Car("Zippy",100);
Console.WriteLine(myCar.ToString());
Console.WriteLine($"Вывести поколение объекта: {GC.GetGeneration(myCar)}");
object[] tonsOfObject = new object[50000];
for (int i = 0;i < tonsOfObject.Length; i++)
{
    tonsOfObject[i] = new object();
}
GC.Collect(0,GCCollectionMode.Forced);
GC.WaitForPendingFinalizers();

Console.WriteLine($"Вывести поколение объекта: {GC.GetGeneration(myCar)}");

if (tonsOfObject[30000] != null)
{
    Console.WriteLine($"tonsOfObject[9000]: {GC.GetGeneration(tonsOfObject[30000])}");
}
else
{
    Console.WriteLine("tonsOfObject[9000] больше не существует");
}
Console.WriteLine($"Количество сборок мысора для поколения 0: {GC.CollectionCount(0)}");
Console.WriteLine($"Количество сборок мысора для поколения 1: {GC.CollectionCount(1)}");
Console.WriteLine($"Количество сборок мысора для поколения 2: {GC.CollectionCount(2)}");




