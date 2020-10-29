using System;

namespace exercise_97
{
    /*
        Exercise_97
        create a class named Whistle. Add the variable private string sound to the class.
        After that, create the constructor public Whistle(string whistleSound), which is used to create a new whistle that's given a sound.
        After that, create a method public void Sound() which prints out the sound (using Console.WriteLine).

        Whistle duckWhistle = new Whistle("Kvaak");
        Whistle roosterWhistle = new Whistle("Peef");

        duckWhistle.Sound();
        roosterWhistle.Sound();
        duckWhistle.Sound();
        Kvaak 
        Peef 
        Kvaak
    */
    class Program
    {
        public static void Main(string[] args)
        {
            // Create Whistle.cs and follow the instructions.
            // You can test your Whistle class with these.
            Whistle duckWhistle = new Whistle("Kvaak");
            Whistle roosterWhistle = new Whistle("Peef");

            duckWhistle.Sound();
            roosterWhistle.Sound();
            duckWhistle.Sound();

        }
    }
}