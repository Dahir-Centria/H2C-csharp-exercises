using System;

namespace exercise_122
{
    /*
        Exercise_122
        The exercise template has a class Product, which represents a product
        in a shop. Every product has a name, location and weight.

        Add the following three constructors to the Product class:

        public Product(string name) creates a product with the given name. Its 
        location is set to "shelf" and its weight is set to 1.
        public Product(string name, string location) creates a product with the 
        given name and the given location. Its weight is set to 1.
        public Product(string name, int weight) creates a product with the given 
        name and the given weight. Its location is set to "warehouse". You can 
        test your program with the following code:
        Product tapeMeasure = new Product("Tape measure");
        Product plaster = new Product("Plaster", "home improvement section");
        Product tyre = new Product("Tyre", 5);

        Console.WriteLine(tapeMeasure);
        Console.WriteLine(plaster);
        Console.WriteLine(tyre);
        Tape measure (1 kg) can be found from the shelf. 
        Plaster (1 kg) can be found from the home improvement section. 
        Tyre (5 kg) can be found from the warehouse.
    */
    class Program
    {
        public static void Main(string[] args)
        {
            // You can test your code here.
            Product tapeMeasure = new Product("Tape measure");
            Product plaster = new Product("Plaster", "home improvement section");
            Product tyre = new Product("Tyre", 5);

            Console.WriteLine(tapeMeasure);
            Console.WriteLine(plaster);
            Console.WriteLine(tyre);
        }
    }
}