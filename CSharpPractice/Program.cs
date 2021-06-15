using System;
using CSharpPractice.Classes;

namespace CSharpPractice
{
    class Program
    {
        static BankAccount myAccount = new BankAccount();
        static void Main(string[] args)
        {
            string myAccountBalance = myAccount.CheckBalance();
            Console.WriteLine(myAccountBalance);
            string message = Console.ReadLine();
            Console.WriteLine("Echo:" + message);
            Console.ReadLine();
        }
    }
}
