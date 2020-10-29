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
            money = 1000;
        }

        public double DrinkCoffee(double payment)
        {
            // an coffee now costs 2.50 euros
            // increase the amount of cash by the price of an coffee mean and return the change
            // if the payment parameter is not large enough, no coffee is sold and the method should return the whole payment
            if (payment >= 2.5)
            {
                money += 2.5;
                coffeeAmount++;
                return payment - 2.5;
            }
            return payment;
        }

        public double EatLunch(double payment)
        {
            // a lunch now costs 10.30 euros
            // increase the amount of cash by the price of a lunch and return the change
            // if the payment parameter is not large enough, no lunch is sold and the method should return the whole payment
            if (payment >= 10.30)
            {
                money += 10.30;
                lunchAmount++;
                return payment - 10.30;
            }
            return payment;
        }
        public bool DrinkCoffee(PaymentCard card)
        {
            // a coffee costs 2.50 euros
            // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
            // otherwise false is returned
            bool result = card.takeMoney(2.50);
            if (result == true)
            {
                coffeeAmount++;
            }
            return result;
        }
        public bool EatLunch(PaymentCard card)
        {
            // a lunch costs 10.30 euros
            // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
            // otherwise false is returned
            bool result = card.takeMoney(10.30);
            if (result == true)
            {
                lunchAmount++;
            }
            return result;
        }
        public void AddMoneyToCard(PaymentCard card, double sum)
        {
            if (money - sum >= 0)
            {
                money -= sum;
                card.AddMoney(sum);
            }
        }
        public override string ToString()
        {
            return "money: " + money + ", number of sold coffees: " + coffeeAmount + ", number of sold lunches: " + lunchAmount;
        }
    }
}