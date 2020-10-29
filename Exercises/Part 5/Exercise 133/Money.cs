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
            int eur = euros + addition.euros;
            int cen = cents + addition.cents;

            Money newMoney = new Money(eur, cen);
            // create a new Money object that has the correct worth

            // return the new Money object
            return newMoney;
        }

        public Money Minus(Money decreaser)
        {
            int eur = euros - decreaser.euros;
            int cen = cents - decreaser.cents;

            if (eur < 0)
            {
                eur = 0;
            }
            if (cen < 0)
            {
                cen = 0;
            }

            Money newMoney = new Money(eur, cen);
            // create a new Money object that has the correct worth

            // return the new Money object
            return newMoney;
        }

        public bool LessThan(Money compared)
        {
            if (euros > compared.euros)
            {
                return false;
            }
            else if (euros < compared.euros)
            {
                return true;
            }
            else
            {
                if (cents > compared.cents)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public override string ToString()
        {
            string zero = "";
            if (cents < 10)
            {
                zero = "0";
            }

            return euros + "." + zero + cents + "e";
        }
    }
}