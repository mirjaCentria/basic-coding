using System;
using System.Collections.Generic;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        {
            string line;
            int lines = 0;

            while(true)
            {
                line = Console.ReadLine();
                if(line == "end") break;
                lines++;
            }
            Console.WriteLine(lines);
        }
    }
}
