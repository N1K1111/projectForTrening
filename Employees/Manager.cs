using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Manager : Employee
    {
        public int StockOptions {  get; set; }
        public Manager()
        {
            
        }
        public Manager(string name, int age, int id, float pay, string ssn, int numbOfOpts) : base(name, age, id, pay, ssn, EmployeePayTypeEnum.Salaried)
        {
            StockOptions = numbOfOpts;
        }
    }
}
