using System;

namespace exercise_123
{
    /*
        Exercise_123
        Implement a class called Counter. The class contains a number, whichs value 
        can be increased and decreased. The class must have the following constructors:

        public Counter(int startValue) sets the start value of the counter to startValue.

        public Counter() sets the start value of the counter to 0.

        And the following methods and properties:

        public int value { get; set; }
        public void Increase() increases the value by 1
        public void Decrease() decreases the value by 1
        public void Increase(int increaseBy) increases the value of the counter by the value of increaseBy.
        If the value of increaseBy is negative, the value of the counter does not change.
        public void Decrease(int decreaseBy) decreases the value of the counter by the value of decreaseBy.
        If the value of decreaseBy is negative, the value of the counter does not change.
    */
    class Program
    {
        public static void Main(string[] args)
        {
            // You can test your code here.
            Counter counter = new Counter();

        }
    }
}