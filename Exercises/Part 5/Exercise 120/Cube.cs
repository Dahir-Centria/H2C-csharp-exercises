namespace exercise_120
{
    public class Cube
    {
        int edgeLength;

        public override string ToString()
        {
            string result = "The length of the edge is " + edgeLength + " and the volume " + Volume();
            return result;
        }
        public int Volume()
        {
            return edgeLength * edgeLength * edgeLength;
        }
        public Cube(int edgeLength)
        {
            this.edgeLength = edgeLength;
        }
    }
}