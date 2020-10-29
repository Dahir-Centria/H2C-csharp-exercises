using System;

namespace exercise_106
{
    public class PaymentCard
    {
        private double balance;

        public override string ToString()
        {
            return "The card has a balance of " + balance + " euros";
        }
        public PaymentCard(double openingBalance)
        {
            balance = openingBalance;
        }
    }
}