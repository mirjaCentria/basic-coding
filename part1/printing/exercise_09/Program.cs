using System;

namespace exercise_09
{
    class Program
    {
        public static void Main(string[] args)
        {

            string s1 = "Hello, how are you?";
            string s2 = "That's interesting, tell me more";
            string s3 = "Thank you for sharing!";
            string sAnswer = ""; 

            Console.WriteLine(s1);
            sAnswer = Console.ReadLine();

            Console.WriteLine(s2);
            sAnswer = Console.ReadLine();

            Console.WriteLine(s3);
           

            /* Actually, reading the answer is not really needed but the program 
            would wait for it forever. Can of course be forced to continue. 
            Makes sense though that furhter versions would use the responses somehow */

        }
    }
}
