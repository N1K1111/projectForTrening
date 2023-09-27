using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        private string _empName;
        private int _empId;
        private float _currPay;
        private string _ssn;
        private EmployeePayTypeEnum _payType;

        #region Конструкторы
        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, id, pay, "", EmployeePayTypeEnum.Salaried) { }
        public Employee(string name, int id, float pay, string ssn, EmployeePayTypeEnum payType)
        {
            Name = name;
            Id = id;
            Pay = pay;
            _ssn = ssn;
            PayType = payType;

        }
        #endregion
    }
}
