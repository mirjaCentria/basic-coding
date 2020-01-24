using System;

namespace exercise_07
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give input!");
            // Write your code here:

            //Read input to a new string variable.
            string sInput = Console.ReadLine();


            // print 3 times (could be a variable)
            int i = 0;
            while (i < 3) 
            {
                // Print out the string.
                Console.WriteLine(sInput);
                // add to index
                 i = i + 1;
            }

            
        }
    }
}
