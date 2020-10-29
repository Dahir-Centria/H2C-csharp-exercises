using System;

namespace exercise_99
{
    /*
        Exercise_99
        This exercise consists of multiple sections. Each section corresponds to one exercise point.

        The exercise template comes with a partially executed class DecreasingCounter:

        using System;

        namespace exercise_99
        {
          public class DecreasingCounter
          {
            private int value;   // a variable that remembers the value of the counter

            public DecreasingCounter(int initialValue)
            {
              this.value = initialValue;
            }

            public void PrintValue()
            {
              Console.WriteLine("value: " + this.value);
            }

            public void decrement()
            {
              // write the method implementation here
              // the aim is to decrement the value of the counter by one
            }

            // and the other methods go here
          }
        }
        The following is an example of how the main program uses the decreasing counter:

        public static void Main(string[] args)
        {
          DecreasingCounter counter = new DecreasingCounter(10);
          counter.PrintValue();

          counter.Decrement();
          counter.PrintValue();

          counter.Decrement();
          counter.PrintValue();
        }
        value: 10
        value: 9
        value: 8
        Section 1 : Implementation of the Decrement() method
        Implement the Decrement() method in the class body in such a way that it decrements
        the value variable of the object it's being called on by one.
        Once you're done with the Decrement() method, the main program of the previous example
        should work to produce the example output.

        Section 2 : The counter's value cannot be negative
        Improve the Decrement() in such a way that the counter's value never becomes negative.
        This means that if the value of the counter is 0, it cannot be decremented.
        A conditional statement is useful here.

        public static void Main(string[] args)
        {

          DecreasingCounter counter = new DecreasingCounter(2);
          counter.PrintValue();

          counter.Decrement();
          counter.Decrement();
          counter.PrintValue();

          counter.Decrement();
          counter.PrintValue();
        }
        value: 2
        value: 0
        value: 0
        Section 3: Resetting the counter value
        create the method public void Reset() for the counter that resets the value of the counter to 0. For example:

        public static void Main(string[] args)
        {

          DecreasingCounter counter = new DecreasingCounter(20);
          counter.PrintValue();

          counter.Reset();
          counter.PrintValue();
        }
        value: 20
        value: 0
    */
    class Program
    {
        public static void Main(string[] args)
        {
            DecreasingCounter counter = new DecreasingCounter(20);
            counter.PrintValue();

            counter.Reset();
            counter.PrintValue();
        }
    }
}