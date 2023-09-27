using static StaticDataAndMembers.TimeUtilClass;

namespace StaticDataAndMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingAccount s3 = new SavingAccount();
            Console.WriteLine("s3");

            SavingAccount s1 = new SavingAccount(50);
            Console.WriteLine("s1");

            //SavingAccount.SetInterestRate(0.08);
            //Console.WriteLine(SavingAccount.GetInterestRate());
              SavingAccount s2 = new SavingAccount(100);
            Console.WriteLine("s2");

            PrintTime();

            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();

        }
    }
}