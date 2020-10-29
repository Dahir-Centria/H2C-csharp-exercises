using System;

namespace exercise_128
{
    /*
    Exercise_128
    Fill in the method public bool LargerThan(Apartment compared) 
    that returns true if the apartment object whose method is called 
    has a larger total area than the apartment object that is being compared.

    An example of how the method should work:

    public static void Main(string[] args)
    {
      Apartment manhattanStudioApt = new Apartment(1, 16, 5500);
      Apartment atlantaTwoBedroomApt = new Apartment(2, 38, 4200);
      Apartment bangorThreeBedroomApt = new Apartment(3, 78, 2500);

      Console.WriteLine(manhattanStudioApt.LargerThan(atlantaTwoBedroomApt));
      Console.WriteLine(bangorThreeBedroomApt.LargerThan(manhattanStudioApt));
    }
    False
    True
    Fill in the method public int PriceDifference(Apartment compared) 
    that returns the price difference of the apartment object whose 
    method was called and the apartment object received as the parameter.
    The price difference is the absolute value of the difference of the prices
    (price can be calculated by multiplying the price per square by the number of squares).
    Use the method private int Price() to calculate the price for the apartments.

    An example of how the method should work:

    Apartment manhattanStudioApt = new Apartment(1, 16, 5500);
    Apartment atlantaTwoBedroomApt = new Apartment(2, 38, 4200);
    Apartment bangorThreeBedroomApt = new Apartment(3, 78, 2500);
    Console.WriteLine(manhattanStudioApt.PriceDifference(atlantaTwoBedroomApt));
    Console.WriteLine(bangorThreeBedroomApt.PriceDifference(manhattanStudioApt));
    71600
    107000
    Fill in the method public bool MoreExpensiveThan(Apartment compared)
    that returns true if the apartment object whose method is called is
    more expensive than the apartment object being compared.

    An example of how the method should work:

    Apartment manhattanStudioApt = new Apartment(1, 16, 5500);
    Apartment atlantaTwoBedroomApt = new Apartment(2, 38, 4200);
    Apartment bangorThreeBedroomApt = new Apartment(3, 78, 2500);
    Console.WriteLine(manhattanStudioApt.MoreExpensiveThan(atlantaTwoBedroomApt));
    Console.WriteLine(bangorThreeBedroomApt.MoreExpensiveThan(manhattanStudioApt));
    False
    True
    */
    class Program
    {
        public static void Main(string[] args)
        {
            // Try your code here, if you want
            Apartment manhattanStudioApt = new Apartment(1, 16, 5500);
            Apartment atlantaTwoBedroomApt = new Apartment(2, 38, 4200);
            Apartment bangorThreeBedroomApt = new Apartment(3, 78, 2500);

            Console.WriteLine(manhattanStudioApt.LargerThan(atlantaTwoBedroomApt));
            Console.WriteLine(bangorThreeBedroomApt.LargerThan(manhattanStudioApt));

            Console.WriteLine(manhattanStudioApt.PriceDifference(atlantaTwoBedroomApt));
            Console.WriteLine(bangorThreeBedroomApt.PriceDifference(manhattanStudioApt));

            Console.WriteLine(manhattanStudioApt.MoreExpensiveThan(atlantaTwoBedroomApt));
            Console.WriteLine(bangorThreeBedroomApt.MoreExpensiveThan(manhattanStudioApt));
        }

    }
}