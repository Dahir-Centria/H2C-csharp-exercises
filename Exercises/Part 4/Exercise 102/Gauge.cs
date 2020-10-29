using System;

namespace exercise_102
{
    class Gauge
    {
        public int value { get; set; }

        public void Increase()
        {
            if (value < 5)
            {
                value++;
            }
        }
        public void Decrease()
        {
            if (value > 0)
            {
                value--;
            }
        }
        public bool Full()
        {
            if (value >= 5)
            {
                return true;
            }
            return false;
        }

        public Gauge()
        {
            value = 0;
        }
    }
}