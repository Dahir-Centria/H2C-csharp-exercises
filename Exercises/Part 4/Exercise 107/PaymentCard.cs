using System;

namespace exercise_107
{
    public class PaymentCard
    {
        private double balance;

        public void EatLunch()
        {
            balance -= 10.60;
        }
        public void DrinkCoffee()
        {
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