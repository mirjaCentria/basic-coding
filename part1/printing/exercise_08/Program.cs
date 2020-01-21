using System;

namespace exercise_08
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            Console.WriteLine("What is your name?");
            
            //Read input to a new string variable.
            string sName = Console.ReadLine();

            // Print out the string.
            Console.WriteLine("Hello " + sName + "!");
        }
    }
}
