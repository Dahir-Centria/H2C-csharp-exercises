using System;

namespace exercise_108
{
    public class PaymentCard
    {
        private double balance;

        public void EatLunch()
        {
            if (balance >= 10.60)
            {
                balance -= 10.60;
            }
        }
        public void DrinkCoffee()
        {
            if (balance >= 2.0)
            {
                balance -= 2.0;
            }
        }
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