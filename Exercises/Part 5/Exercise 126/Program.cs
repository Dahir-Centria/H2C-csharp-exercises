using System;

namespace exercise_126
{
    /*
        Exercise_126
        In a previous exercises part we created a class called PaymentCard. 
        The card had methods for Eating a lunch and drinking coffee, and also for adding money to the card.

        However, there was a problem with the PaymentCard class that is implemented 
        in this fashion. The card knew the prices of the different payments, 
        and therefore was able to decrease the balance by the proper amount.
        What about if the prices are raised? Or new items are added to the list 
        of offered products? A change in the pricing would mean that all the
        existing cards would have to be replaced with new cards that are aware of the new prices.

        An improved solution is to make the cards "dumb"; unaware of the prices
        and products that are sold, and only keeping track of their balance. 
        All the intelligence is better placed in separate objects, payment terminals.

        Section 1
        Let's first implement the "dumb" version of the PaymentCard. 
        The card only has ability for asking for the balance, adding money,
        and taking money. Complete the method public bool TakeMoney(double amount)
        in the class below (and found in the exercise template), using the following as a guide:

        namespace exercise_126
        {
          public class PaymentCard
          {
            public double balance { get; private set; }

            public PaymentCard(double balance)
            {
              this.balance = balance;
            }

            public void AddMoney(double increase)
            {
              this.balance = this.balance + increase;
            }

            public bool TakeMoney(double amount)
            {
              // implement the method so that it only takes money from the card if
              // the balance is at least the amount parameter.
              // returns true if successful and false otherwise

              return false;
            }
          }
        }
        static void Main(string[] args)
        {
          PaymentCard petesCard = new PaymentCard(10);

          Console.WriteLine("money " + petesCard.balance);
          bool wasSuccessful = petesCard.takeMoney(8);
          Console.WriteLine("successfully withdrew: " + wasSuccessful);
          Console.WriteLine("money " + petesCard.balance);

          wasSuccessful = petesCard.takeMoney(4);
          Console.WriteLine("successfully withdrew: " + wasSuccessful);
          Console.WriteLine("money " + petesCard.balance);

        }
        Should print like this:

        money 10
        successfully withdrew: True
        money 2
        successfully withdrew: False
        money 2
        Section 2
        When visiting a student cafeteria, the customer pays either with cash 
        or with a payment card. The cashier uses a payment terminal to charge 
        the card or to process the cash payment. First, let's create a terminal that's suitable for cash payments.

        The outline of the payment terminal. The comments inside the methods tell the wanted functionality:

        namespace exercise_126
        {
          public class PaymentTerminal
          {
            private double money;  // amount of cash
            private int coffeeAmount; // number of sold coffees
            private int lunchAmount;  // number of sold lunches

            public PaymentTerminal()
            {
              // register initially has 1000 euros of money
            }

            public double DrinkCoffee(double payment)
            {
              // an coffee now costs 2.50 euros
              // increase the amount of cash by the price of an coffee mean and return the change
              // if the payment parameter is not large enough, no coffee is sold and the method should return the whole payment
            }

            public double EatLunch(double payment)
            {
              // a lunch now costs 10.30 euros
              // increase the amount of cash by the price of a lunch and return the change
              // if the payment parameter is not large enough, no lunch is sold and the method should return the whole payment
            }

            public override string ToString()
            {
              return "money: " + money + ", number of sold coffees: " + coffeeAmount + ", number of sold lunches: " + lunchAmount;
            }
          }
        }
        The terminal starts with 1000 euros in it. Implement the methods so they work 
        correctly, using the basis above and the example prints of the main program below.

       PaymentTerminal lunchCafeteria = new PaymentTerminal();

        double change = lunchCafeteria.DrinkCoffee(10);
        Console.WriteLine("remaining change " + change);

        change = lunchCafeteria.DrinkCoffee(5);
        Console.WriteLine("remaining change " + change);

        change = lunchCafeteria.EatLunch(20);
        Console.WriteLine("remaining change " + change);

        Console.WriteLine(lunchCafeteria);
        remaining change 7.5
        remaining change 2.5
        remaining change 13
        money: 1015.3, number of sold coffees: 2, number of sold lunches: 1
        Section 3
        Let's extend our payment terminal to also support card payments. 
        We are going to create new methods for the terminal. It receives a payment card as a parameter,
        and decreases its balance by the price of the meal that was purchased. Here are the outlines for 
        the methods, and instructions for completing them.

        public bool DrinkCoffee(PaymentCard card)
        {
          // a coffee costs 2.50 euros
          // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
          // otherwise false is returned
        }

        public bool EatLunch(PaymentCard card)
        {
          // a lunch costs 10.30 euros
          // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
          // otherwise false is returned
        }
        Notice! Card payments do not increase the cash in the register.

        PaymentTerminal lunchCafeteria = new PaymentTerminal();

        double change = lunchCafeteria.DrinkCoffee(10);
        Console.WriteLine("remaining change: " + change);

        PaymentCard annesCard = new PaymentCard(15);

        bool wasSuccessful = lunchCafeteria.EatLunch(annesCard);
        Console.WriteLine("there was enough money: " + wasSuccessful);
        wasSuccessful = lunchCafeteria.EatLunch(annesCard);
        Console.WriteLine("there was enough money: " + wasSuccessful);
        wasSuccessful = lunchCafeteria.DrinkCoffee(annesCard);
        Console.WriteLine("there was enough money: " + wasSuccessful);

        Console.WriteLine(lunchCafeteria);
        remaining change: 7.5
        there was enough money: True
        there was enough money: False
        there was enough money: True
        money: 1002.5, number of sold coffees: 2, number of sold lunches: 1
        Section 4
        Let's create a method for the terminal that can be used to add money to a payment card. 
        Recall that the payment that is received when adding money to the card is stored in the 
        register (adding cash). The basis for the method:

        public void AddMoneyToCard(PaymentCard card, double sum)
        {
          // ...
        }
        A main program to illustrate:

        public static void Main(string[] args)
        {
          // Try your code here, if you want

          PaymentTerminal lunchCafeteria = new PaymentTerminal();
          Console.WriteLine(lunchCafeteria);

          PaymentCard annesCard = new PaymentCard(2);

          Console.WriteLine("amount of money on the card is " + annesCard.balance + " euros");

          bool wasSuccessful = lunchCafeteria.EatLunch(annesCard);
          Console.WriteLine("there was enough money: " + wasSuccessful);

          lunchCafeteria.AddMoneyToCard(annesCard, 100);

          wasSuccessful = lunchCafeteria.EatLunch(annesCard);
          Console.WriteLine("there was enough money: " + wasSuccessful);

          Console.WriteLine("amount of money on the card is " + annesCard.balance + " euros");

          Console.WriteLine(lunchCafeteria);
        }
        money: 1000, number of sold coffees: 0, number of sold lunches: 0
        amount of money on the card is 2 euros
        there was enough money: False
        there was enough money: True
        amount of money on the card is 91.7 euros
        money: 1100, number of sold coffees: 0, number of sold lunches: 1
    */
    class Program
    {
        static void Main(string[] args)
        {
            // Try your code here, if you want

            PaymentTerminal lunchCafeteria = new PaymentTerminal();
            Console.WriteLine(lunchCafeteria);

            PaymentCard annesCard = new PaymentCard(2);

            Console.WriteLine("amount of money on the card is " + annesCard.balance + " euros");

            bool wasSuccessful = lunchCafeteria.EatLunch(annesCard);
            Console.WriteLine("there was enough money: " + wasSuccessful);

            lunchCafeteria.AddMoneyToCard(annesCard, 100);

            wasSuccessful = lunchCafeteria.EatLunch(annesCard);
            Console.WriteLine("there was enough money: " + wasSuccessful);

            Console.WriteLine("amount of money on the card is " + annesCard.balance + " euros");

            Console.WriteLine(lunchCafeteria);
        }
    }
}