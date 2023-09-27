using ObjectOverrides;


Person p1 = new Person("Nik","Nik",10);
Person p2 = new Person("Nik","Nik",10);


Console.WriteLine(p2.Equals(p1));
Console.WriteLine(object.Equals(p2,p1));
Console.WriteLine(object.ReferenceEquals(p2,p1));
