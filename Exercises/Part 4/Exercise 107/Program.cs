using System;

namespace exercise_107
{
    /*
        Exercise_107
        Expand your answer from the exercise 106 by adding two methods:

        Method public void EatLunch()
        Method public void DrinkCoffee()
        The method EatLunch should decrease the card's balance by 10.60 euros.
        The method DrinkCoffee should decrease the card's balance by 2.0 euros.

        The following main program tests the class:

        public static void Main(string[] args)
        {
          PaymentCard card = new PaymentCard(50);
          Console.WriteLine(card);

          card.EatLunch();
          Console.WriteLine(card);
  
          card.DrinkCoffee();
          Console.WriteLine(card);
        }
        The card has a balance of 50 euros
        The card has a balance of 39.4 euros
        The card has a balance of 37.4 euros
    */
    class Program
    {
        public static void Main(string[] args)
        {
            PaymentCard card = new PaymentCard(50);
            Console.WriteLine(card);

            card.EatLunch();
            Console.WriteLine(card);

            card.DrinkCoffee();
            Console.WriteLine(card);
        }
    }
}