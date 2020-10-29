using System;

namespace exercise_102
{
    /*
    Exercise_102
    create the class Gauge. The gauge has the instance public int value, a constructor without parameters
    (sets the initial value of the meter variable to 0), and also the following three methods:

    Method public void Increase() grows the value instance variable's value by one. It does not grow the value beyond five.
    Method public void Decrease() decreases the value instance variable's value by one. It does not decrease the value to negative values.
    Method public bool Full() returns True if the instance variable value has the value five. Otherwise, it returns False.
    Also, give the value ability for get and set: Make the value public rather than private, and add { get; set; } on the declaring lines!

    An example of the class in use.

    public static void Main(string[] args)
    {
      Gauge g = new Gauge();

      while (!g.Full())
      {
        Console.WriteLine("Not full! Value: " + g.value);
        g.Increase();
      }

      Console.WriteLine("Full! Value: " + g.value);
      g.Decrease();
      Console.WriteLine("Not full! Value: " + g.value);
    }
    Not full! Value: 0
    Not full! Value: 1
    Not full! Value: 2
    Not full! Value: 3
    Not full! Value: 4
    Full! Value: 5
    Not full! Value: 4
    */
    class Program
    {
        public static void Main(string[] args)
        {
            Gauge g = new Gauge();

            while (!g.Full())
            {
                Console.WriteLine("Not full! Value: " + g.value);
                g.Increase();
            }

            Console.WriteLine("Full! Value: " + g.value);
            g.Decrease();
            Console.WriteLine("Not full! Value: " + g.value);
        }
    }
}