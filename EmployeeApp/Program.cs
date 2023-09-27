using EmployeeApp;

Employee emp =  new Employee("Nikita",456,30000);
emp.GiveBonus(1000);
emp.DisplayStats();

Employee emp2 = new Employee("Nikita",4,1000,"ssn",EmployeePayTypeEnum.Salaried);
emp2.GiveBonus(100);
Console.WriteLine(emp2.Pay);