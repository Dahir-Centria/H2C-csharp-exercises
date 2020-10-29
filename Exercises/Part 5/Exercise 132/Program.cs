using System;
using System.Collections.Generic;

namespace exercise_132
{
    /*
        Exercise_132
        This exercise is worth 2.

        With the exercise base the class SimpleDate is supplied. The date is 
        stored with the help of the object variables year, month, and day. 
        There are some methods that need fulfilling:

        public void Advance() advances the date by one day. In this exercise
        we assume that each month has 30 day. Remember! In certain situations
        you need to change the values of month and year.
        public void Advance(int howManyDays) advances the date by the amount
        of days. Use the method Advance() that you implemented to help you in 
        this.
        public SimpleDate AfterNumberOfDays(int days) It creates a new SimpleDate
        object whose date is the specified number of days grEater than the object
        that the method was called on. You may still assume that each month has
        30 days. Notice that the old date object must remain unchanged!
        Since the last method must create a new object, the structure of the 
        code should be somewhat similar to this:

        SimpleDate newDate = new SimpleDate( ... );

        // Do something here

        return newDate;
        The whole class template looks like this:

        namespace exercise_132
        {
          public class SimpleDate
          {
            private int day;
            private int month;
            private int year;

            public SimpleDate(int day, int month, int year)
            {
              this.day = day;
              this.month = month;
              this.year = year;
            }

            public void Advance() {
              // Do something here
            }

            public void Advance(int howManyDays) {
              // Do something here
            }

            public SimpleDate AfterNumberOfDays(int days) {
              SimpleDate newDate = new SimpleDate( ... );

              // Do something here

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
        Here's example use:

        public static void Main(string[] args)
        {
          SimpleDate date = new SimpleDate(13, 2, 2015);
          Console.WriteLine("Friday of the examined week is " + date);

          SimpleDate newDate = date.AfterNumberOfDays(7);
          int week = 1;
          while (week <= 7)
          {
            Console.WriteLine("Friday after " + week + " weeks is " + newDate);
            newDate = newDate.AfterNumberOfDays(7);

            week = week + 1;
          }

          Console.WriteLine("The date after 790 days from the examined Friday is ... try it out yourself!");
          // Console.WriteLine("Try " + date.AfterNumberOfDays(790));

        }
        Friday of the examined week is 13.2.2015
        Friday after 1 weeks is 20.2.2015
        Friday after 2 weeks is 27.2.2015
        Friday after 3 weeks is 4.3.2015
        Friday after 4 weeks is 11.3.2015
        Friday after 5 weeks is 18.3.2015
        Friday after 6 weeks is 25.3.2015
        Friday after 7 weeks is 2.4.2015
        The date after 790 days from the examined Friday is ... try it out yourself!
        NOTICE! Instead of modifying the state of the old object we return a new one 
        with AfterNumberOfDays. Imagine that the SimpleDate class has a method Advance 
        that works similarly to the method we programmed, but it modifies the state of 
        the old object. In that case the next block of code would cause problems.

        SimpleDate now = new SimpleDate(13, 2, 2015);
        SimpleDate afterOneWeek = now;
        afterOneWeek.Advance(7);

        Console.WriteLine("Now: " + now);
        Console.WriteLine("After one week: " + afterOneWeek);
        Now: 20.2.2015 
        After one week: 20.2.2015
        This is because a normal assignment only copies the reference to the object. 
        So the objects now and afterOneWeek in the program now refer to the one and same SimpleDate object.
    */
    class Program
    {
        public static void Main(string[] args)
        {
            SimpleDate date = new SimpleDate(13, 2, 2015);
            Console.WriteLine("Friday of the examined week is " + date);

            SimpleDate newDate = date.AfterNumberOfDays(7);
            int week = 1;
            while (week <= 7)
            {
                Console.WriteLine("Friday after " + week + " weeks is " + newDate);
                newDate = newDate.AfterNumberOfDays(7);

                week = week + 1;
            }

            Console.WriteLine("The date after 790 days from the examined Friday is ... try it out yourself!");
            //Console.WriteLine("Try " + date.AfterNumberOfDays(790));
        }
    }
}