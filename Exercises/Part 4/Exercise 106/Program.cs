﻿using System;

namespace exercise_106
{
    /*
    Exercise_106
    In this exercise series, a class called PaymentCard is 
    createdwhich aims to mimic a cafeteria's payment process.

    The template includes the Program.cs file. You have to create the PaymentCard.cs yourself.

    Add a new class to the project called PaymentCard (by creating the file mentioned above).
    create the PaymentCard object's constructor, which is passed the opening balance of the
    card, and which then stores that balance in the object's internal variable.
    Write the ToString method, which will return the card's balance in the form
    "The card has a balance of X euros".
    Here is the template for the PaymentCard:

    namespace exercise_106
    {
      public class PaymentCard
      {
        private double balance;

        public PaymentCard(double openingBalance)
        {
          // write code here
        }

        public override string ToString()
        {
          // write code here
        }
      }
    }
    The following main program tests the class:

    public static void Main(string[] args)
    {
      PaymentCard card = new PaymentCard(50);
      Console.WriteLine(card);
    }
    The card has a balance of 50 euros
    */
    class Program
    {
        public static void Main(string[] args)
        {
            PaymentCard card = new PaymentCard(50);
            Console.WriteLine(card);
        }
    }
}