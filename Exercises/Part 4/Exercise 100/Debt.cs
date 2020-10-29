using System;

namespace exercise_100
{
    class Debt
    {
        private double balance;
        private double interestRate;
        public void WaitOneYear()
        {
            balance *= interestRate;
        }
        public void PrintBalance()
        {
            Console.WriteLine(balance);
        }
        public Debt(double initialBalance, double initialInterestRate)
        {
            balance = initialBalance;
            interestRate = initialInterestRate;
        }
    }
}