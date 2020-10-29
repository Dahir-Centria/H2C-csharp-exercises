using System;

namespace exercise_132
{
    public class SimpleDate
    {
        private int _day;
        private int _month;
        private int _year;

        private int day
        {
            get
            {
                return _day;
            }
            set
            {
                _day = value;
                if (_day >= 30)
                {
                    _day = 0;
                    month++;
                }
            }
        }
        private int month
        {
            get
            {
                return _month;
            }
            set
            {
                _month = value;
                if (_month >= 12)
                {
                    _month = 0;
                    year++;
                }
            }
        }
        private int year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }

        public SimpleDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void Advance()
        {
            day++;
        }

        public void Advance(int howManyDays)
        {
            for (int i = howManyDays; i > 0; i--)
            {
                Advance();
            }
        }

        public SimpleDate AfterNumberOfDays(int days)
        {
            SimpleDate newDate = new SimpleDate(day, month, year);
            newDate.Advance(days);

            return newDate;
        }


        public override string ToString()
        {
            return this.day + "." + this.month + "." + this.year;
        }

        // used to check if this date object (`this`) is before
        // the date object given as the parameter (`compared`)
        public bool Before(SimpleDate compared)
        {
            // first compare years
            if (this.year < compared.year)
            {
                return true;
            }

            // if the years are the same, compare months
            if (this.year == compared.year && this.month < compared.month)
            {
                return true;
            }

            // the years and the months are the same, compare days
            if (this.year == compared.year && this.month == compared.month &&
                this.day < compared.day)
            {
                return true;
            }

            return false;
        }
    }
}