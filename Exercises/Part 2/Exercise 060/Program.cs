using System;

namespace exercise_60
{
    /*
        Exercise_60
        Section 1
        Define a method called PrintStars that prints
        the given number of stars and a line break.
        Write the method in the following template:

        public static void PrintStars(int number)
        {
          // you can print one star with the command
          // Console.Write("*");
          // call the print command n times
          // in the end print a line break with the comand
          // Console.WriteLine("");
        }

        public static void Main(string[] args) 
        {
          PrintStars(5);
          PrintStars(3);
          PrintStars(9);
        }
        The output of the program:

        ***** 
        *** 
        *********
        Section 2
        Define a method called PrintSquare(int size) that prints a suitable
        square with the help of the printStars method. So the method call PrintSquare(4)
        results in the following output:
        ****
        ****
        ****
        ****
        Section 3
        Write a method called PrintRectangle(int width, int height)
        that prints the correct rectangle by using the PrintStars method.
        So the method call PrintRectangle(17, 3) should produce the following output:
        ***************** 
        ***************** 
        *****************
        Section 4
        create a method called PrintTriangle(int size) that prints a triangle
        by using the PrintStars method. So the call PrintTriangle(4) should
        print the following:
        *
        **
        ***
        ****
    */
  class Program
  {
        public static void Main(String[] args)
        {
            Console.WriteLine("----- Stars below. -----");
            PrintStars(5);
            PrintStars(3);
            PrintStars(9);
            Console.WriteLine("----- Square below. -----");
            PrintSquare(4);
            Console.WriteLine("----- Rectangle below. -----");
            PrintRectangle(17,3);
            Console.WriteLine("----- Triangle below. -----");
            PrintTriangle(4);
        }
        public static void PrintStars(int number)
        {
                while(number > 0)
                {
                    Console.Write("*");
                    number--;
                }
                Console.WriteLine();
        }
        public static void PrintSquare(int size)
        {
            for(int i = size; i > 0; i--)
            {
                PrintStars(size);
            }
        }
        public static void PrintRectangle(int width, int height)
        {
            while(height > 0)
            {
                PrintStars(width);
                height--;
            }
        }
        public static void PrintTriangle(int size)
        {
            for(int i = 1; i <= size; i++)
            {
                PrintStars(i);
            }
        }
  }
}
