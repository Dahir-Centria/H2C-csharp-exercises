namespace exercise_125
{
    public class HealthStation
    {
        public int weighings { get; private set; }

        public int Weigh(Person person)
        {
            weighings++;
            return person.weight;
        }

        public void Feed(Person person)
        {
            person.weight++;
        }

        public HealthStation()
        {

        }
    }
}