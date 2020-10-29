using System;

namespace exercise_127
{
    /*
        Exercise_127
        Two classes, Person and Pet, are included in the exercise template. Each person has one pet.
        Modify the public override string ToString method of the Person class so that the string it 
        returns tells the pet's name and breed in addition to the person's own name.

        public static void Main(string[] args)
        {

          Pet lucy = new Pet("Lucy", "golden retriever");
          Person leo = new Person("Leo", lucy);
          Console.WriteLine(leo);

          Person mike = new Person("Mike");
          Console.WriteLine(mike);
  
          Person lilo = new Person();
          Console.WriteLine(lilo);
        }
        Leo, has a friend called Lucy (golden retriever)
        Lilo, has a friend called Stitch (blue alien)
        Mike, has a friend called Toothless (dragon)
    */
    class Program
    {
        public static void Main(string[] args)
        {
            // Try your code here, if you want

            Pet lucy = new Pet("Lucy", "golden retriever");
            Person leo = new Person("Leo", lucy);
            Console.WriteLine(leo);

            Person mike = new Person("Mike");
            Console.WriteLine(mike);

            Person lilo = new Person();
            Console.WriteLine(lilo);
        }

    }
}
