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

        string promptTo = "Where to?";
        string promptFrom = "Where from?";

        Console.WriteLine(promptTo);
        int nmbrTo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(promptFrom);
        int nmbrFrom = Convert.ToInt32(Console.ReadLine());

        if(!(nmbrFrom > nmbrTo)) 
        {
          for (int i = nmbrFrom; i < nmbrTo +1; i++)
          {
              Console.WriteLine(i);
          } 
        } 
    }
  }
}
