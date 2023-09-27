using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    sealed class PtSalesPerson : SalesPerson
    {
        public PtSalesPerson()
        {
            
        }
        public PtSalesPerson(string name, int age, int id, float pay,string ssn, int numbOfSales) : base(name,age,id,pay,ssn,numbOfSales)
        {
            
        }
    }
}
