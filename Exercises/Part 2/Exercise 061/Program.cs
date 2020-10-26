using System;

namespace exercise_61
{
    /*
        Exercise_61
        Section 1
        Define a method called PrintSpaces(int number)
        that produces the number of spaces specified by number.
        The method does not print the line break.
        You will also have to either copy the PrintStars method
        from your previous answer or reimplement it in this exercise template.

        Section 2
        create a method called PrintRightTriangle(int size) that uses PrintSpaces and PrintStars to print the correct triangle. So the method call PrintRightTriangle(4) should print the following:
           *
          **
         ***
        ****
        Section 3
        Define a method called ChristmasTree(int height) that prints the correct Christmas tree. The Christmas tree consists of a triangle with the specified height and the base. The base is two stars high and three stars wide, and is placed at the center of the triangle's bottom. The tree is to be constructed by using the methods PrintSpaces and PrintStars.
        For example, the call ChristmasTree(4) should print the following:

           * 
          *** 
         *****
        ******* 
          *** 
          ***
        The call christmasTree(10) should print:

                 * 
                *** 
               ***** 
              ******* 
             ********* 
            *********** 
           ************* 
          *************** 
         ***************** 
        ******************* 
                *** 
                ***
        NOTICE! Heights shorter that 3 don't have work correctly!
    */
  class Program
  {
        public static void Main(String[] args)
        {
            Console.WriteLine("----- Right triangle below. -----");
            PrintRightTriangle(5);
            Console.WriteLine("----- Christmas tree below. -----");
            ChristmasTree(10);
        }
        public static void PrintStars(int number)
        {
            while(number > 0)
            {
                Console.Write("*");
                number--;
            }
        }
        public static void PrintSpaces(int number)
        {
            while(number > 0)
            {
                Console.Write(" ");
                number--;
            }
        }
        public static void PrintRightTriangle(int size)
        {
            for(int i = 1; i < size; i++)
            {
                PrintSpaces(size-i);
                PrintStars(i);
                Console.WriteLine();
            }
        }
        public static void ChristmasTree(int height)
        {
            for(int i = 1; i <= height; i++)
            {
                PrintSpaces(height-i);
                PrintStars(2*i-1);
                Console.WriteLine();
            }
            for(int i = 2; i > 0; i--)
            {
                PrintSpaces(height-2);
                PrintStars(2*2-1);
                Console.WriteLine();
            }
        }
  }
}
