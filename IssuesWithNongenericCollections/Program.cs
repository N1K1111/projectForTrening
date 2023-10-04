using IssuesWithNongenericCollections;
using System;
using System.Collections;
using System.Threading.Channels;


static void UsePersonCollection()
{
    PersonCollection myPeople = new PersonCollection();
    myPeople.AddPerson(new Person(40, "Hommer", "Simpson"));
    myPeople.AddPerson(new Person(38, "Marge", "Simpson"));
    myPeople.AddPerson(new Person(9, "Lisa", "Simpson"));

    foreach (Person person in myPeople)
        Console.WriteLine(person);
}

static void UseGenericList()
{
    List<Person> morePeople = new List<Person>();
    morePeople.Add(new Person(50,"Frank","Black"));
    Console.WriteLine(morePeople[0]);
}

