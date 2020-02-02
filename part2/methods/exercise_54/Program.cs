using System;

namespace exercise_54
{
  class Program
  {
    public static void Main(String[] args)
    {
        DivisibleByThreeInRange(-5, 20);
    }

   /** Write a method that prints all the numbers divisible by three in the given range. 
   The numbers are to be printed in order from the smallest to the greatest.*/
    public static void DivisibleByThreeInRange(int beginning, int end)
    {
      double dbl = (double)beginning;
      for(int i = beginning; i < end + 1; i++)
      {        
        if(dbl % 3 == 0) Console.WriteLine(dbl);
        dbl = dbl + 1;
      }
    }  
  }
}
