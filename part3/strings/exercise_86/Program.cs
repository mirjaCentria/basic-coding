using System;
using System.Collections.Generic;

namespace exercise_86
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
          Console.WriteLine(word);
        }
      }
    }
  }
}

