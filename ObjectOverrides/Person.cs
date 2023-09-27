using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    internal class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }

        public Person() { }
        public Person(string fName, string lName, int age)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
        }
        public override string ToString()
        {
            return $"[FirstName: {FirstName}; LastName: {LastName}; Age {Age};]";
        }

        //public override bool Equals(object? obj)
        //{
        //    //return base.Equals(obj);

        //    if(!(obj is Person temp))
        //    {
        //        return false;
        //    }
        //    if(temp.LastName == this.LastName
        //        &&  temp.Age == this.Age
        //        && temp.FirstName == this.FirstName)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
