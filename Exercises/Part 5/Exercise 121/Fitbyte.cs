using System;

namespace exercise_121
{
    class Fitbyte
    {
        private int age;
        private double restingHeartRate;
        private double maxHeartRate
        {
            get
            {
                return 206.3 - (0.711 * age);
            }
        }
        public double TargetHeartRate(double percentageOfMaximum)
        {
            return (maxHeartRate - restingHeartRate) * percentageOfMaximum + restingHeartRate;
        }
        public Fitbyte(int age, double restingHeartRate)
        {
            this.age = age;
            this.restingHeartRate = restingHeartRate;
        }
    }
}