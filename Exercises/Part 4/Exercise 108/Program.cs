using System;

namespace exercise_108
{
    /*
        Exercise_108
        Expand your previous answers, so that when an item is bought the balance is checked.
        If there is not enough money to buy, the balance does not change.

        public static void Main(string[] args)
        {
          PaymentCard card = new PaymentCard(10);
          Console.WriteLine(card);

          card.EatLunch();
          Console.WriteLine(card);
  
          card.DrinkCoffee();
          Console.WriteLine(card);
        }
        The card has a balance of 10 euros
        The card has a balance of 10 euros
        The card has a balance of 8 euros
        Notice how EatLunch did not change the balance, as there was not enough money. DrinkCoffee still worked, as it should.
    */
    class Program
    {
        public static void Main(string[] args)
        {
            PaymentCard card = new PaymentCard(10);
            Console.WriteLine(card);

            card.EatLunch();
            Console.WriteLine(card);

            card.DrinkCoffee();
            Console.WriteLine(card);
        }
    }
}