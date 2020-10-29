using System;

namespace exercise_98
{
    /*
        Exercise_98
        create a class Product that represents a store product.
        The product should have a price (double), a quantity (int) and a name (string).

        The class should have:

        the constructor public Product(string name, double price, int quantity)
        a method public void PrintProduct() that prints product information in the following format:
        Banana: price 1.1: 13 pcs
        The output above is based on the product being assigned the name banana, with a price of 1.1, and a quantity of 13.
    */
    class Program
    {
        public static void Main(string[] args)
        {
            // Create Product.cs and follow the instructions.
            // You can test your class with this.
            Product banana = new Product("Banana", 1.1, 13);
            banana.PrintProduct();

        }
    }
}