
using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {
        string sLine = "";
        int iNumber = 0;
        double dDouble = 0;
        bool bVal = true;


        Console.WriteLine("Give a string:");
        sLine = Console.ReadLine();

        Console.WriteLine("Give an integer:");
        iNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Give a double:");
        dDouble = Double.Parse(Console.ReadLine());

        Console.WriteLine("Give a boolean:");
        bVal = bool.Parse(Console.ReadLine());

        // Print out the string.
        Console.WriteLine("Your string: " + sLine );  
        Console.WriteLine("Your integer: " + iNumber );
        Console.WriteLine("Your double: " + dDouble );
        Console.WriteLine("Your boolean: " + bVal );  

    }
  }
}
