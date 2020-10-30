using System;
using System.Collections.Generic;

namespace exercise_134
{
    /*
        Exercise_134
        The exercise base contains the GradeRegister from the material. In this 
        exercise you will further develop the program, so that it can calculate 
        the average of grades and exam results.

        Section 1 - Average grade
        create the method public double AverageOfGrades() for the class GradeRegister.
        It should return the average of the grades, rounded to 2 decimals. If the register 
        contains no grades, the method should return -1. Use the grades list to calculate 
        the average. Example:

        GradeRegister register = new GradeRegister();
        register.AddGradeBasedOnPoints(93);
        register.AddGradeBasedOnPoints(91);
        register.AddGradeBasedOnPoints(92);
        register.AddGradeBasedOnPoints(88);

        Console.WriteLine(register.AverageOfGrades());
        4.75
        Section 2 - Average points
        Give the class GradeRegister a new object variable: a list where you will store 
        the exam points every time that the method AddGradeBasedOnPoints is called. After
        this addition, create a method public double AverageOfPoints() that calculates
        and returns the average of the exam points, rounded to 2 decimals. If there are
        no points added to the register, the method should return the number -1. Example:

        GradeRegister register = new GradeRegister();
        register.AddGradeBasedOnPoints(93);
        register.AddGradeBasedOnPoints(91);
        register.AddGradeBasedOnPoints(92);

        Console.WriteLine(register.AverageOfPoints());
        92
        Section 3 - Prints in the user interface
        As a final step, add the methods implemented above as parts of the user interface.
        When the program prints the grade distribution, it should also print the averages
        of the points and the grades.

        Points:
        > 82 
        Points:
        > 83
        Points:
        > 96 
        Points: 
        > 51 
        Points:
        > 48 
        Points:
        > 56 
        Points:
        > 61 
        Points:
        >

        5: * 
        4: ** 
        3: 
        2: * 
        1: ** 
        0: * 
        The average of points: 68.14
        The average of grades: 2.43
    */
    class Program
    {
        public static void Main(string[] args)
        {
            GradeRegister register = new GradeRegister();

            UserInterface ui = new UserInterface(register);
            ui.Start();
        }
    }
}