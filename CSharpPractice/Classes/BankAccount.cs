using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Classes
{
    public class BankAccount
    {
        public BankAccount()
        {
            Balance = 100;
        }
        private double Balance;

        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }

        public double balance {
            get
            {
                if (Balance < 100000)
                    return 1000000;
                else
                    return Balance;
            }
            protected set
            {
                if (value > 0)
                    Balance = value;
                else
                    balance = 0;
            }
        }
        public virtual double Deposit(double depositAmount)
        {
            return balance += depositAmount;
        }
        public virtual double Withdraw(double amount)
        {
            if(amount > Balance)
            {
                Console.WriteLine("Transaction denied, insuficient funds.");
                return Balance;
            }
            else
            {
                return balance -= amount;
            }
        }
        public string CheckBalance()
        {
            return "You have " + Balance.ToString() + " in your account.";
        }
    }

    public class ChildBankAccount : BankAccount
    {
        public ChildBankAccount()
        {
            balance = 10;
        }
        public override double Deposit(double depositAmount)
        {
            if (depositAmount > 1000)
                depositAmount = 1000;
            return base.Deposit(depositAmount);
        }
        public override double Withdraw(double amount)
        {
            if (amount > 1000)
                amount = 1000;
            return base.Withdraw(amount);
        }
    }
}
