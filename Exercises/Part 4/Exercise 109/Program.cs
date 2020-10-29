using System;

namespace exercise_109
{
    /*
    Exercise_109
    Expand your previous answers, so that you can charge money on your card:

    public void AddMoney(double amount) {
        // write code here
    }
    The purpose of the method is to increase the card's balance by the amount 
    of money given as a parameter. However, the card's balance may not exceed 150 euros. 
    As such, if the amount to be topped up exceeds this limit, the balance should, 
    in any case, become exactly 150 euros.

    The following main program tests the class:

    public static void Main(string[] args)
    {
      PaymentCard card = new PaymentCard(100);
      Console.WriteLine(card);

      card.AddMoney(49.99);
      Console.WriteLine(card);

      card.AddMoney(10000.0);
      Console.WriteLine(card);

      card.AddMoney(-10);
      Console.WriteLine(card);
    }
    The card has a balance of 100 euros
    The card has a balance of 149.99 euros
    The card has a balance of 150 euros
    The card has a balance of 150 euros
    Notice! You cannot add negative money!
    */
    class Program
    {
        public static void Main(string[] args)
        {
            PaymentCard card = new PaymentCard(100);
            Console.WriteLine(card);

            card.AddMoney(49.99);
            Console.WriteLine(card);

            card.AddMoney(10000.0);
            Console.WriteLine(card);

            card.AddMoney(-10);
            Console.WriteLine(card);
        }
    }
}