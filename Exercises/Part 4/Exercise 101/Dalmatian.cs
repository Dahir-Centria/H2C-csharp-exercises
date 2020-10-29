using System;

namespace exercise_101
{
    class Dalmatian
    {
        public string name { get; set; }
        public int spots { get; set; }

        public Dalmatian(string name, int spots)
        {
            this.name = name;
            this.spots = spots;
        }
    }
}