using FunWithGenericollections;


//UseGenericList();
//UseGenericStack();
//UseGenericQueue();
//UseGenericSortedSet();
UseDictionary();


static void UseGenericList()
{
    List<Person> people = new List<Person>() 
    {
    new Person{FirstName = "Homer", LastName = "Simpson", Age = 47},
    new Person{FirstName = "Marge", LastName = "Simpson", Age = 45},
    new Person{FirstName = "Lisa", LastName = "Simpson", Age = 9},
    new Person{FirstName = "Bart", LastName = "Simpson", Age = 8}
    };

    Console.WriteLine($"Колличество элементов в списке: {people.Count}");
    
    foreach( Person person in people )
        Console.WriteLine(person);
    Console.WriteLine($"\n->Вставить новый объект Person");
    people.Insert(2, new Person { FirstName = "Magee", LastName = "Simpson", Age = 2 });
    Console.WriteLine($"Колличество элементов в списке: {people.Count}");

    Person[] arrayOfPeople = people.ToArray();
    foreach( Person person in arrayOfPeople )
        Console.WriteLine($"FirstNames: {person.FirstName}");



}

static void UseGenericStack()
{
    Stack<Person> stackOfPeople = new Stack<Person>();
    stackOfPeople.Push( new Person { FirstName = "Homer",LastName = "Simpson",Age = 47 });
    stackOfPeople.Push( new Person { FirstName = "Marge",LastName = "Simpson",Age = 45 });
    stackOfPeople.Push( new Person { FirstName = "Lisa",LastName = "Simpson",Age = 9 });

    Console.WriteLine(stackOfPeople.Count);
    Console.WriteLine("First Person: {0}",stackOfPeople.Peek());
    Console.WriteLine($"Poped off {stackOfPeople.Pop()}");
    Console.WriteLine("First Person: {0}", stackOfPeople.Peek());
    Console.WriteLine($"Poped off {stackOfPeople.Pop()}");
    Console.WriteLine("First Person: {0}", stackOfPeople.Peek());
    Console.WriteLine($"Poped off {stackOfPeople.Pop()}");

    try
    {
        Console.WriteLine("First Person: {0}", stackOfPeople.Peek());
        Console.WriteLine($"Poped off {stackOfPeople.Pop()}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}

static void UseGenericQueue()
{
    Queue<Person> queue = new Queue<Person>();
    queue.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
    queue.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
    queue.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });


    Console.WriteLine($"{queue.Peek()} in first in line");
    queue.Dequeue();
    Console.WriteLine($"{queue.Peek()} in first in line");
}

static void UseGenericSortedSet()
{
    SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
    {
         new Person{FirstName = "Homer", LastName = "Simpson", Age = 47},
         new Person{FirstName = "Marge", LastName = "Simpson", Age = 45},
         new Person{FirstName = "Lisa", LastName = "Simpson", Age = 9},
         new Person{FirstName = "Bart", LastName = "Simpson", Age = 8 }
    };

    foreach ( Person person in setOfPeople )
        Console.WriteLine(person);
}


static void UseDictionary()
{
    Dictionary<string, Person> peopleA = new Dictionary<string, Person>();

    peopleA.Add("Homer", new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
    peopleA.Add("Marge", new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
    peopleA.Add("Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

    Console.WriteLine(peopleA["Homer"]);

    Dictionary<string, Person> peopleB = new Dictionary<string, Person>()
    {
        { "Homer", new Person { FirstName = "Homer",LastName = "Simpson", Age = 47} },
        { "Marge", new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 }},
        { "Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 }}
    };

    Person lisa = peopleB["Lisa"];
    Console.WriteLine(lisa);
}

