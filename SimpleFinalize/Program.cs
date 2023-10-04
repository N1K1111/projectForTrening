


using SimpleFinalize;

Console.WriteLine("Нажмите клавишу Enter чтобы создать объукты");
Console.WriteLine("и затем заставить сборщик мусора вызвать метод Finalize()");

CreateObject(100_000_000);

GC.AddMemoryPressure(2147483647);
GC.Collect(0,GCCollectionMode.Forced);
GC.WaitForPendingFinalizers();
Console.ReadLine();

static void CreateObject(int count)
{
    MyResourseWrapper[] tonsOfObjects = new MyResourseWrapper[count];
    for (int i = 0; i < tonsOfObjects.Length; i++)
    {
        tonsOfObjects[i] = new MyResourseWrapper();
    }
    tonsOfObjects = null;
}