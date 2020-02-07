using System;
using System.Collections.Generic;

namespace exercise_88
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

        Console.WriteLine(words[0]);
        
      }
    }
  }
}



