using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNongenericCollections
{
    internal class Person
    {
        public int Age { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Person(){}
        public Person(int age, string lName, string fName)
        {
            Age = age;
            LastName = lName;
            FirstName = fName;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, age: {Age}";
        }
    }
}
