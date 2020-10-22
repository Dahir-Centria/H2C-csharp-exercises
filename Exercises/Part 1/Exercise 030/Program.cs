using System;

namespace exercise_30
{
    /*
        Exercise_30
        Here is the grading for this course:

        Percent	Grade
        < 0	Impossible
        0 - 49	Fail
        50 - 59	1
        60 - 69	2
        70 - 79	3
        80 - 89	4
        90 - 100	5
        > 100	Outstanding!
        create a program, which asks the user for their percent, and gives them their score. For example:
        Give your percent [0 - 100]:
        > -2
        Impossible
        Give your percent [0 - 100]:
        > 49
        Fail
        Give your percent [0 - 100]:
        > 75
        Grade: 3
        Give your percent [0 - 100]:
        > 99
        Grade: 5
        Give your percent [0 - 100]:
        > 9001
        Outstanding!
    */
  class Program
  {
    public static void Main(string[] args)
    {
            int grade;
            string userInput;
            string result;

            Console.WriteLine("Give your percent [0 - 100]:");
            userInput = Console.ReadLine();
            grade = System.Convert.ToInt32(userInput);

            if(grade < 0)
            {
                result = "Impossible";
            }
            else if(grade < 50)
            {
                result = "Fail";
            }
            else if(grade < 60)
            {
                result = "Grade: 1";
            }
            else if(grade < 70)
            {
                result = "Grade: 2";
            }
            else if(grade < 80)
            {
                result = "Grade: 3";
            }
            else if(grade < 90)
            {
                result = "Grade: 4";
            }
            else if(grade <= 100)
            {
                result = "Grade: 5";
            }
            else
            {
                result = "Outstanding!";
            }

            Console.WriteLine(result);
    }
  }
}
