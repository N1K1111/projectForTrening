using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    abstract partial class Employee
    {
        private string _empName;
        private int _empId;
        private int _age;
        private float _currPay;
        private string _ssn;
        private EmployeePayTypeEnum _payType;
        BenefitPackage EmpBenefits = new BenefitPackage();

        #region Конструкторы
        public Employee() { }
        public Employee(string name,int age, int id, float pay) : this(name,age, id, pay, "", EmployeePayTypeEnum.Salaried) { }
        public Employee(string name,int age, int id, float pay, string ssn, EmployeePayTypeEnum payType)
        {
            Name = name;
            Id = id;
            Pay = pay;
            _ssn = ssn;
            PayType = payType;
            Age = age;

        }
        #endregion
    }
}
