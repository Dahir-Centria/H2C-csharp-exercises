using System;

namespace exercise_104
{
    /*
    Exercise_104
    create a class Multiplier that has a:

    Constructor public Multiplier(int number). Method public int Multiply(int number) which returns
    the value number passed to it multiplied by the number provided to the constructor.
    You also need to create an instance variable in this exercise. When you call the method Multiply, 
    store the changed value into the instance variable!

    An example of the class in use:

    public static void Main(string[] args)
    {
      Multiplier multiplyByThree = new Multiplier(3);

      Console.WriteLine("multiplyByThree.Multiply(2): " + multiplyByThree.Multiply(2));

      Multiplier multiplyByFour = new Multiplier(4);

      Console.WriteLine("multiplyByFour.Multiply(2): " + multiplyByFour.Multiply(2));
      Console.WriteLine("multiplyByThree.Multiply(1): " + multiplyByThree.Multiply(1));
      Console.WriteLine("multiplyByFour.Multiply(1): " + multiplyByFour.Multiply(1));
      Console.WriteLine("multiplyByFour.Multiply(3): " + multiplyByFour.Multiply(3));
    }
    multiplyByThree.Multiply(2): 6
    multiplyByFour.Multiply(2): 8
    multiplyByThree.Multiply(1): 6
    multiplyByFour.Multiply(1): 8
    multiplyByFour.Multiply(3): 24
    NOTICE! The value stored in the objects is changed during the first calls!
    The calculations are actually ( in order):
    3 * 2 = 6
    4 * 2 = 8
    6 * 1 = 6
    8 * 1 = 8
    8 * 3 = 24
    */
    class Program
    {
        public static void Main(string[] args)
        {
            Multiplier multiplyByThree = new Multiplier(3);

            Console.WriteLine("multiplyByThree.Multiply(2): " + multiplyByThree.Multiply(2));

            Multiplier multiplyByFour = new Multiplier(4);

            Console.WriteLine("multiplyByFour.Multiply(2): " + multiplyByFour.Multiply(2));
            Console.WriteLine("multiplyByThree.Multiply(1): " + multiplyByThree.Multiply(1));
            Console.WriteLine("multiplyByFour.Multiply(1): " + multiplyByFour.Multiply(1));
            Console.WriteLine("multiplyByFour.Multiply(3): " + multiplyByFour.Multiply(3));
        }
    }
}