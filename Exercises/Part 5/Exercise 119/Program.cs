using System;
using System.IO;

namespace exercise_119
{
    /*
    Exercise_119
    The exercise template comes with the "ClockHand" class described in the
    course material. Implement a Timer class based on the material's Clock class.

    The timer has two hands, one for hundredths of a second and one for 
    seconds. As it progresses, the number of hundredths of a second grows by one.
    When the hand corresponding to hundredths of a second reaches a value of 100,
    its value is set to zero, and the number of seconds grows by one. In the same 
    way, when the value of the hand corresponding to seconds reaches the value of 
    sixty, its value is set to zero.

    public Timer() creates a new timer.
    public override string ToString() returns a string representation of the 
    timer. The string representation should be in the form "seconds: hundredths 
    of a second", where both the seconds and the hundredths of a second are represented
    by two numbers. For example, "19:83" would represent the time 19 seconds, 
    83 hundredths of a second.
    public void Advance() moves the timer forward by a hundredth of a second.
    You can test out the timer's functionality in the main program whenever 
    you like. The example code below provides you with a program where the timer 
    is printed and it advances once every hundredth of a second.

    static void Main(string[] args)
    {
      // create new timer
      Timer timer = new Timer();
      // Loop until you cancel the loop.
      // You can cancel with the CTRL + C
      while (true)
      {
        Console.WriteLine(timer);
        timer.Advance();
        // Some error proving, we'll talk about this later.
        // Known as try-catch.
        try
        {
          // Wait 100th of a second. 
          // Sleep(1000) waits one second, if you want to test at slower pace.
          System.Threading.Thread.Sleep(10);
        }
        // Other half of try-catch pair. 
        catch (Exception e)
        {
          Console.WriteLine("Error happened: +" + e);
        }
      }
    }
    */
    class Program
    {
        static void Main(string[] args)
        {
            // create new timer
            Timer timer = new Timer();
            // Loop until you cancel the loop.
            // You can cancel with the CTRL + C
            while (true)
            {
                Console.WriteLine(timer);
                timer.Advance();
                // Some error proving, we'll talk about this later.
                // Known as try-catch.
                try
                {
                    // Wait 100th of a second. 
                    // Sleep(1000) waits one second, if you want to test at slower pace.
                    System.Threading.Thread.Sleep(10);
                }
                // Other half of try-catch pair. 
                catch (Exception e)
                {
                    Console.WriteLine("Error happened: +" + e);
                }
            }
        }
    }
}