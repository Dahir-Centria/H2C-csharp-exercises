using System;
using System.Collections.Generic;

namespace exercise_133
{
    /*
        Exercise_133
        This exercise is worth 2.

        In the Payment card exercise we used a double-type object 
        variable to store the amount of money. In real applications
        this is not the approach you want to take, since as we have 
        seen, calculating with doubles is not exact. A more reasonable 
        way to handle amounts of money is create an own class for that 
        purpose. Here is a layout for the class:

        namespace exercise_133
        {
          public class Money
          {

            private int euros;
            private int cents;

            public Money(int euros, int cents)
            {
              if (cents > 99)
              {
                euros = euros + cents / 100;
                cents = cents % 100;
              }

              this.euros = euros;
              this.cents = cents;
            }

            public Money Plus(Money addition)
            {
              Money newMoney = new Money( Do something here);
              // create a new Money object that has the correct worth

              // return the new Money object
              return newMoney;
            }

        public Money Minus(Money decreaser)
        {
            Money newMoney = new Money( Do something here);
            // create a new Money object that has the correct worth

            // return the new Money object
            return newMoney;
        }

        public bool LessThan(Money compared)
        {
            // Do something here
            return false;
        }

        public string toString()
        {
            string zero = "";
            if (cents <= 10)
            {
                zero = "0";
            }

            return euros + "." + zero + cents + "e";
        }
          }
        }
        Next we'll create a few operations for processing money.

        First create the method public Money Plus(Money addition) 
        that returns a new money object that is worth the total amount
        of the object whose mehtod was called and the object that is
        received as the parameter.
        The basis for the method is the following:

        public Money Plus(Money addition)
        {
            Money newMoney = new Money( Do something here);
            // create a new Money object that has the correct worth

            // return the new Money object
            return newMoney;
        }
        NOTICE! If the cents would go over 100, the euros should increase
        as well!

        create the method public bool LessThan(Money compared) that returns 
        true if the money object whose method is called has a grEater worth 
        than the money object that is received as the method parameter.

        Write the method public Money Minus(Money decreaser) that returns a 
        new money object worth the difference of the object whose method was
        called and the object received as the parameter. If the difference 
        would be negative, the worth of the created money object is set to 0.

        NOTICE! If the cents would go under 0, the euros should decrease as 
        well!

        Example of all the methods:

        Money money = new Money(100, 00);
        Money moreMoney = new Money(500, 50);

        Money combined = money.Plus(moreMoney);

        Console.WriteLine(money);
        Console.WriteLine(moreMoney);
        Console.WriteLine(combined);

        Money lessMoney = moreMoney.Minus(money);

        Console.WriteLine(money);
        Console.WriteLine(moreMoney);
        Console.WriteLine(lessMoney);

        lessMoney = lessMoney.Minus(money);

        Console.WriteLine(money);
        Console.WriteLine(moreMoney);
        Console.WriteLine(lessMoney);

        Console.WriteLine(lessMoney.LessThan(moreMoney));
        Console.WriteLine(lessMoney.LessThan(money));

        lessMoney = lessMoney.Minus(moreMoney);
        Console.WriteLine(lessMoney);
        Prints out

        100.00e
        500.50e
        600.50e
        100.00e
        500.50e
        400.50e
        100.00e
        500.50e
        300.50e
        True
        False
        0.00e
    */
    class Program
    {
        public static void Main(string[] args)
        {
            Money money = new Money(100, 00);
            Money moreMoney = new Money(500, 50);

            Money combined = money.Plus(moreMoney);

            Console.WriteLine(money);
            Console.WriteLine(moreMoney);
            Console.WriteLine(combined);

            Money lessMoney = moreMoney.Minus(money);

            Console.WriteLine(money);
            Console.WriteLine(moreMoney);
            Console.WriteLine(lessMoney);

            lessMoney = lessMoney.Minus(money);

            Console.WriteLine(money);
            Console.WriteLine(moreMoney);
            Console.WriteLine(lessMoney);

            Console.WriteLine(lessMoney.LessThan(moreMoney));
            Console.WriteLine(lessMoney.LessThan(money));

            lessMoney = lessMoney.Minus(moreMoney);
            Console.WriteLine(lessMoney);
        }
    }
}