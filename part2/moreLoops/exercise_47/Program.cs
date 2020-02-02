using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      /*
      ##### Section 1
      * Write a program, which prints integers from 1 to a number given by the user.
      ```console Where to? */

        string prompt = "Where to?";
        Console.WriteLine(prompt);
        int nmbr = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < nmbr +1; i++)
        {
            Console.WriteLine(i);
        } 
    }
  }
}
