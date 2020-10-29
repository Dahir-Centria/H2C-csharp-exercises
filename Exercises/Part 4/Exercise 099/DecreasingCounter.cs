using System;

namespace exercise_99
{
    public class DecreasingCounter
    {
        private int value;   // a variable that remembers the value of the counter

        public DecreasingCounter(int initialValue)
        {
            this.value = initialValue;
        }

        public void PrintValue()
        {
            Console.WriteLine("value: " + this.value);
        }

        public void Decrement()
        {
            if (value > 0)
            {
                value--;
            }
        }

        public void Reset()
        {
            value = 0;
        }
    }
}