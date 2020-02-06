using System;
using System.Collections.Generic;

namespace exercise_87
{
  class Program
  {
    public static void Main(string[] args)
    {
      string line;
    
      while(true)
      {
        line = Console.ReadLine();
        if(line == "") break;
        string[] words = line.Split(" ");

        foreach(string word in words)
        {
          if(word.Contains("av"))
            Console.WriteLine(word);
        }
      }
    }
  }
}

