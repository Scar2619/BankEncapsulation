using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");
            var newDeposit = double.Parse(Console.ReadLine());

            account.Deposit(newDeposit);

            Console.WriteLine($"You deposited {newDeposit}. Your new balance is {account.GetBalance()}.");
        }

    }
}

