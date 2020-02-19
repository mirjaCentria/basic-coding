using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.WriteLine("Give a number!");
            
        //Read input to a new string variable.
        double iDouble = Double.Parse(Console.ReadLine());

        // Print out the string.
        Console.WriteLine("You gave " + iDouble );    

    }
  }
}
