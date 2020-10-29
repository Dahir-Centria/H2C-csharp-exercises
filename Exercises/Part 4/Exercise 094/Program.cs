using System;

namespace exercise_94
{
    /*
        Exercise_94
        The Account from the previous exercise class is also available in this exercise.

        Write a program that:

        CrEates an account named "Heikki's account" with the balance 1000.0
        CrEates an account named "Personal account" with the balance 0
        Withdraws 100.0 from Heikki's account
        Deposits 100.0 to its own personal account
        Prints account information (ToString) on both, first Heikki's, then Personal:
        Heikki's account balance: 900
        Personal account balance: 100
    */
    class Program
    {
        public static void Main(string[] args)
        {
            // DO NOT TOUCH THE OTHER FILE!
            // Do your code here!

            Account firstAccount = new Account("Heikki's account", 1000.0);
            Account secondAccount = new Account("Personal account", 0.0);

            firstAccount.Withdrawal(100);
            secondAccount.Deposit(100);

            Console.WriteLine(firstAccount.ToString());
            Console.WriteLine(secondAccount.ToString());
        }
    }
}