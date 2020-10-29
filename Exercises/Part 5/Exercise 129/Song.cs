using System;

namespace exercise_129
{
    public class Song
    {
        private string artist;
        private string name;
        private int durationInSeconds;

        public Song(string artist, string name, int durationInSeconds)
        {
            this.artist = artist;
            this.name = name;
            this.durationInSeconds = durationInSeconds;
        }

        public override string ToString()
        {
            return this.artist + ": " + this.name + " (" + this.durationInSeconds + " s)";
        }

        // BEGIN SOLUTION
        public override bool Equals(object compared)
        {
            if (compared.GetType() == this.GetType())
            {
                Song s = (Song)compared;
                if (artist == s.artist && name == s.name && durationInSeconds == s.durationInSeconds)
                {
                    return true;
                }
            }
            return false;
        }
        // END SOLUTION
    }
}