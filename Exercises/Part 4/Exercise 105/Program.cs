using System;

namespace exercise_105
{
    /*
        Exercise_105
        The exercise template includes class Statistics

        namespace exercise_105
        {
          public class Statistics
          {
            public int count {get; set;}
            public int sum { get; set; }

            public NumberStatistics()
            {
              // initialize the variable count here
            }

            public void AddNumber(int number) {
                // write code here
            }
          }
        }
        The following program introduces the class' use:

        Statistics statistics = new Statistics();
        statistics.AddNumber(3);
        statistics.AddNumber(5);
        statistics.AddNumber(1);
        statistics.AddNumber(2);
        Console.WriteLine("Count: " + statistics.count);
        Console.WriteLine("Sum: " + statistics.sum);
        Count: 4
        Sum: 11
        Expand the program as follows:

        When a number is added, count is increased by one
        When a number is added, sum is increased by the number's value
    */
    class Program
    {
        public static void Main(string[] args)
        {
            Statistics statistics = new Statistics();
            statistics.AddNumber(3);
            statistics.AddNumber(5);
            statistics.AddNumber(1);
            statistics.AddNumber(2);
            Console.WriteLine("Count: " + statistics.count);
            Console.WriteLine("Sum: " + statistics.sum);
        }
    }
}