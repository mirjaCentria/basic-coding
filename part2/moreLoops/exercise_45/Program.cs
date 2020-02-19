using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      /* Write a program that reads an integer from the user. 
      Then the program prints numbers from 0 to the number 
      given by the user. You can assume that the user 
      always gives a positive number.      
      You can use either a while-loop with a condition, or a for-loop.**/

        int nmbr = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < nmbr +1; i++)
        {
            Console.WriteLine(i);
        }        
    }
  }
}
