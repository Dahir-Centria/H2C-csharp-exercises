using System;

namespace exercise_97
{
    public class Whistle
    {
        private string sound;
        public void Sound()
        {
            Console.WriteLine(sound);
        }

        public Whistle(string whistleSound)
        {
            sound = whistleSound;
        }
    }
}