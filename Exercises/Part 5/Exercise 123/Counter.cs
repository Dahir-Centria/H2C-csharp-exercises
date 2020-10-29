using System;

namespace exercise_123
{
    class Counter
    {
        private int value { get; set; }

        public void Increase()
        {
            value++;
        }
        public void Decrease()
        {
            value--;
        }
        public void Increase(int increaseBy)
        {
            if (increaseBy > 0)
            {
                value += increaseBy;
            }
        }
        public void Decrease(int decreaseBy)
        {
            if (decreaseBy > 0)
            {
                value -= decreaseBy;
            }
        }

        public Counter(int startValue)
        {
            value = startValue;
        }
        public Counter()
        {
            value = 0;
        }
    }
}