using System;

namespace exercise_120
{
    /*
        Exercise_120
        create a Cube class that represents a cube (i.e., a standard hexahedron).
        create a public Cube (int edgeLength) constructor for the class, that takes the length of the cube's edge as its parameter.

        Make a public int Volume() method for the cube, which calculates and returns the cube's volume. 
        The volume of the cube is calculated with the formula edgeLength * edgeLength * edgeLength.
        Moreover, make a public override string ToString() method for the cube, which returns a string representation of it.
        The string representation should take the form "The length of the edge
        is l and the volume v", where l is the length and v the volume - both the length and volume must be represented as integers.
    */
    class Program
    {
        public static void Main(string[] args)
        {
            Cube cube = new Cube(3);
            Console.WriteLine(cube);
        }
    }
}