using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Employees
{
    abstract partial class Employee
    {
        #region Cвойства
        public string Name 
        {
            get { return _empName; } 
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Eror, input data is very long");
                else
                    _empName = value;
            }
        }
        public BenefitPackage Benefits { get => EmpBenefits; set => EmpBenefits = value; }
        public int Age { get => _age; set => _age = value; }
        public int Id 
        { 
            get => _empId; 
            set => _empId = value; 
        }
        public float Pay { get => _currPay; set => _currPay = value; }
        public string SocialSecurityNumber => _ssn;
        public EmployeePayTypeEnum PayType { get=>_payType; set => _payType = value; }
        #endregion

        public double GetBenefitCost() => EmpBenefits.ComputePayDeduction();

        public void GiveBonus(float amount) 
        {
            Pay = this switch
            {
                { PayType: EmployeePayTypeEnum.Commision } => Pay += .10F * amount,
                { PayType: EmployeePayTypeEnum.Hourly } => Pay += 40F * amount / 2080F,
                { PayType: EmployeePayTypeEnum.Salaried } => Pay += amount,
                _ => Pay +=0
            };
        }

        public void DisplayStats()
        {
            Console.WriteLine($"Name: {_empName}");
            Console.WriteLine($"ID: {_empId}");
            Console.WriteLine($"Pay: {_currPay}");
        }


        /*
        public string GetName() => _empName;
        public void SetName(string name)
        {
            if (name.Length < 15) 
                _empName = name;
            else
                Console.WriteLine("Error, Long Lenght!");
        }
        */



    }
}
