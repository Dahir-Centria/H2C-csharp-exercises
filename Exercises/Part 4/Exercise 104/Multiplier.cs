using System;

namespace exercise_104
{
    class Multiplier
    {
        private int multiplier;
        public int Multiply(int number)
        {
            multiplier *= number;
            return multiplier;
        }
        public Multiplier(int number)
        {
            multiplier = number;
        }
    }
}