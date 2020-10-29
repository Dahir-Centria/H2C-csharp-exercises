using System;

namespace exercise_100
{
    /*
    Exercise_100
    create the class Debt that has double-typed instance variables of balance and interestRate.
    The balance and the interest rate are passed to the constructor as parameters
    public Debt(double initialBalance, double initialInterestRate).

    In addition, create the methods public void PrintBalance() and public void WaitOneYear() for the class.
    The method PrintBalance prints the current balance, and the WaitOneYear method grows the debt amount.

    The debt is increased by multiplying the balance by the interest rate.

    The class should do the following:

    public static void Main(string[] args)
    {

      Debt mortgage = new Debt(120000.0, 1.01);
      mortgage.PrintBalance();

      mortgage.WaitOneYear();
      mortgage.PrintBalance();

      // Wait 20 years
      int years = 0;
      while (years < 20)
      {
        mortgage.WaitOneYear();
        years = years + 1;
      }

      mortgage.PrintBalance();
    }
    The example above illustrates the development of a mortgage with an interest rate of one percent.

    Prints:

    120000
    121200
    147887.0328416936
    */
    class Program
    {
        public static void Main(string[] args)
        {

            Debt mortgage = new Debt(120000.0, 1.01);
            mortgage.PrintBalance();

            mortgage.WaitOneYear();
            mortgage.PrintBalance();

            // Wait 20 years
            int years = 0;
            while (years < 20)
            {
                mortgage.WaitOneYear();
                years = years + 1;
            }

            mortgage.PrintBalance();
        }
    }
}