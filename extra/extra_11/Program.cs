using System;

namespace extra_11
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      System.Console.WriteLine("Give a sentence:");
      string line = System.Console.ReadLine();

      string[] words = line.Split(" ");

      for(int i = 0; i < words.Length; i++)
      {
        if(words[i] != "") 
              System.Console.WriteLine(words[i]);
      }

    }
  }
}
