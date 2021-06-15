using System;
using CSharpPractice.Classes;
using CSharpPractice.Interfaces;

namespace CSharpPractice
{
    class Program
    {
        static BankAccount myAccount = new BankAccount(1000);
        static void Main(string[] args)
        {
            string myAccountBalance = myAccount.GetInformation();
            Console.WriteLine(myAccountBalance);
            string message = Console.ReadLine();
            Console.WriteLine("Echo:" + message);

            Console.WriteLine(Information(myAccount));

            Console.ReadLine();
        }

        private static string Information(ILearn infomration)
        {
            return infomration.GetInformation();
        }
    }
}
