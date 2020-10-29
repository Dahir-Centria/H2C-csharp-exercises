﻿using System;

namespace exercise_121
{
    /*
    Exercise_121
    The Karvonen method allows you to calculate your target heart rate for physical exercise.
    The target heart rate is calculated with the formula
    (maximum heart rate - resting heart rate) * (target heart rate percentage) + resting heart rate,
    where the target heart rate is given as a percentage of the maximum heart rate.

    For example, if a person has a maximum heart rate of 200, a resting heart rate of 50,
    and a target heart rate of 75% of the maximum heart rate, the target heart rate should 
    be about ((200-50) * (0.75) + 50), i.e., 162.5 bEats per minute.

    create an "exercise assistant" class called Fitbyte. Its constructor takes both
    an age and a resting heart rate as its parameters. The exercise assistant should 
    provide a method TargetHeartRate, which is passed a number of type double as a parameter
    that represents a percentual portion of the maximum heart rate. The proportion is given 
    as a number between zero and one. The class should have:

    A constructor public Fitbyte(int age, int restingHeartRate)
    A method public double TargetHeartRate(double percentageOfMaximum) that calculates 
    and returns the target heart rate.
    Use the formula 206.3 - (0.711 * age) to calculate the maximum heart rate. Use the 
    formula (maxHeartRate - restingHeartRate) * percentageOfMaximum + restingHeartRate 
    to calculate the target heart rate.

    Use case:

    public static void Main(string[] args)
    {
      Fitbyte assistant = new Fitbyte(30, 60);
      double percentage = 0.5;

      while (percentage < 1.0)
      {
        double target = assistant.TargetHeartRate(percentage);
        Console.WriteLine("Target " + (percentage * 100) + "% of maximum: " + target);
        percentage = percentage + 0.1;
      }
    }
    Target 50% of maximum: 122.48500000000001
    Target 60% of maximum: 134.98200000000003
    Target 70% of maximum: 147.479
    Target 80% of maximum: 159.976
    Target 89.99999999999999% of maximum: 172.473
    Target 99.99999999999999% of maximum: 184.97000000000003
    */
    class Program
    {
        public static void Main(string[] args)
        {
            Fitbyte assistant = new Fitbyte(30, 60);
            double percentage = 0.5;

            while (percentage < 1.0)
            {
                double target = assistant.TargetHeartRate(percentage);
                Console.WriteLine("Target " + (percentage * 100) + "% of maximum: " + target);
                percentage = percentage + 0.1;
            }
        }
    }
}