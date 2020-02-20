using System;

namespace exercise_121
{
    public class Fitbyte
    {
        int age;
        int restingHeartRate;

         public Fitbyte(int age, int restingHeartRate)
         {
            this.age = age;
            this.restingHeartRate = restingHeartRate;       
         }

        public double MaximumHeartRate(int age)
        {
            double max = 206.3 - 0.711*age;
            return max;
        }
         public double TargetHeartRate(double percentageOfMaximum)
         {            
            double tg = (this.MaximumHeartRate(this.age) - this.restingHeartRate)* percentageOfMaximum + this.restingHeartRate;
            return tg;
         }

    }

}