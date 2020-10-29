using System;

namespace exercise_98
{
    public class Product
    {
        private double price;
        private int quantity;
        private string name;

        public void PrintProduct()
        {
            string result = name + ": price " + price + ": " + quantity + " pcs";
            Console.WriteLine(result);
        }

        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
    }
}