using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    internal class SavingAccount
    {
        public double currBalance;
        public static double currInterestRate;
        public SavingAccount(double balance)
        {
            
            currBalance = balance;
        }
        public SavingAccount()
        {
            Console.WriteLine("стандартный конструктор");
            currInterestRate = 0;
        }
        static SavingAccount()
        {
            Console.WriteLine("Статический конструктор");
            currInterestRate = 0.04;
        }

        public static double GetInterestRate() => currInterestRate;
        

        public static void SetInterestRate(double rate) =>
            currInterestRate = rate;
        
    }
}
