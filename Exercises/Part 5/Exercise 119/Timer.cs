namespace exercise_119
{
    public class Timer
    {
        private int milliseconds;
        private int seconds;

        public Timer()
        {
            milliseconds = 0;
            seconds = 0;
        }

        public void Advance()
        {
            milliseconds++;
            if (milliseconds >= 100)
            {
                milliseconds = 0;
                seconds++;

                if (seconds >= 60)
                {
                    seconds = 0;
                }
            }
        }

        public override string ToString()
        {
            string result;
            string millivalue;
            string secondsvalue;

            if (milliseconds < 10)
            {
                millivalue = "0" + milliseconds;
            }
            else
            {
                millivalue = milliseconds.ToString();
            }
            if (seconds < 10)
            {
                secondsvalue = "0" + seconds;
            }
            else
            {
                secondsvalue = seconds.ToString();
            }

            result = secondsvalue + ":" + millivalue;

            return result;
        }
    }
}