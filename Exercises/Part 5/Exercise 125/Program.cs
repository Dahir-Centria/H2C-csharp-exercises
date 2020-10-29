using System;

namespace exercise_125
{
    /*
    Exercise_125
    In the exercise base there is the class Person, which we are already quite familiar with. 
    There is also an outline for the class HealthStation. Health station objects process people 
    in different ways, they e.g. weigh and feed people. In this exercise we will construct a health station.
    The code of the Person class should not be modified in this exercise!

    Section 1 - Weighing people
    The Weigh method receives a person as a parameter, and it is meant to return to its caller
    the weight of that person. The weight information can be found by calling a suitable property 
    of the Person person. So your task is to complete the code of the method!

    Section 2 - Feeding people
    It is possible to modify the state of the object that is received as a parameter. Fill in
    the method called public void Feed(Person person) for the health station. It should increase 
    the weight of the parameter person by one.

    Section 3 - Counting weighings
    Use the variable public int weighings { get; private set; } to count weighings - That is,
    when ever the method Weigh is called, the variable should increase by one.

    Here's a Main class to test all of the sections:

    public static void Main(string[] args)
    {
      // create new Station
      HealthStation childrensHospital = new HealthStation();

      // create two new persons
      Person ethan = new Person("Ethan", 1, 110, 7);
      Person peter = new Person("Peter", 33, 176, 85);

      // Try out the Persons and method Weigh
      Console.WriteLine(ethan.name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
      Console.WriteLine(peter.name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

      // Test feeding the persons
      childrensHospital.Feed(ethan);
      childrensHospital.Feed(peter);

      // See that the weights have changed
      Console.WriteLine(ethan.name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
      Console.WriteLine(peter.name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

      // Keep weighing to increase the 'int weighings'
      childrensHospital.Weigh(ethan);
      childrensHospital.Weigh(ethan);
      childrensHospital.Weigh(ethan);
      childrensHospital.Weigh(ethan);

      // See that the variable has increased to 8
      Console.WriteLine("weighings performed: " + childrensHospital.weighings);
    }
    Should print out

    Ethan weight: 110 kilos
    Peter weight: 176 kilos
    Ethan weight: 111 kilos
    Peter weight: 177 kilos
    weighings performed: 8
    */
    class Program
    {
        public static void Main(string[] args)
        {
            // create new Station
            HealthStation childrensHospital = new HealthStation();

            // create two new persons
            Person ethan = new Person("Ethan", 1, 110, 7);
            Person peter = new Person("Peter", 33, 176, 85);

            // Try out the Persons and method Weigh
            Console.WriteLine(ethan.name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
            Console.WriteLine(peter.name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

            // Test feeding the persons
            childrensHospital.Feed(ethan);
            childrensHospital.Feed(peter);

            // See that the weights have changed
            Console.WriteLine(ethan.name + " weight: " + childrensHospital.Weigh(ethan) + " kilos");
            Console.WriteLine(peter.name + " weight: " + childrensHospital.Weigh(peter) + " kilos");

            // Keep weighing to increase the 'int weighings'
            childrensHospital.Weigh(ethan);
            childrensHospital.Weigh(ethan);
            childrensHospital.Weigh(ethan);
            childrensHospital.Weigh(ethan);

            // See that the variable has increased to 8
            Console.WriteLine("weighings performed: " + childrensHospital.weighings);
        }
    }
}