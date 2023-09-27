using Employees;



SalesPerson fred = new SalesPerson()
{
    Age = 31, Name = "Fred", SalesNumber = 50, 
};

Console.WriteLine(fred is Employee);

Manager chucky = new Manager("Chucky",50,92,10000,"324-434-2322",9000);

Console.WriteLine(chucky.GetBenefitCost());

