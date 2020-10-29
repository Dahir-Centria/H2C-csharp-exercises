using System;

namespace exercise_93
{
    /*
    When creating own classes, make sure to include the correct namespace so you can reference it from your Program.cs file.
    We'll get to namespaces later. For now, whenever you create a new class, use the folder name as the namespace.

    You can test your own classes in the Main if you want to, but it is not necessary.
    It does, of course, help you understand your code, and the exercises might include some examples, how the classes should work.

    Exercise_93
    The exercise template comes with a ready-made class named Account.
    The Account object represents a bank account that has balance (i.e. one that has some amount of money in it).
    The accounts are used as follows:

    Account heikkisAccount = new Account("Heikki's account", 100.00);
    Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);

    Console.WriteLine("Intial state");
    Console.WriteLine(heikkisAccount);
    Console.WriteLine(heikkisSwissAccount);

    heikkisAccount.Withdrawal(20);
    Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.balance);
    heikkisSwissAccount.Deposit(200);
    Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.balance);

    Console.WriteLine("End state");
    Console.WriteLine(heikkisAccount);
    Console.WriteLine(heikkisSwissAccount);
    Write a program that

    creates an account with a balance of 100.0,
    deposits 20.0 in it,
    and finally prints the balance.
    120
    NOTICE! Perform all the operations in this exact order.
    */
    class Program
    {
        public static void Main(string[] args)
        {
            // DO NOT TOUCH THE OTHER FILE!
            // Do your code here!
            
            Account heikkisAccount = new Account("Heikki's account", 100.00);
            heikkisAccount.Deposit(20.0);
            Console.WriteLine(heikkisAccount.balance);
        }
    }
}