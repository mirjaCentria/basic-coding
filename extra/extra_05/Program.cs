using System;
using System.Collections.Generic;

namespace extra_05
{
  class Program
  {
    public static void Main(string[] args)
    {
      string word = "";
      List<string> words = new List<string>();

      for(int i = 1; i < 6; i++) 
        Console.WriteLine(i);

      Console.WriteLine("Give words, 'end' quits:");
      while(true)
      {
         word = Console.ReadLine();
         if(word == "end") break;
         else words.Add(word);
      }

       foreach(string item in words)  
      {
        Console.WriteLine(item);
      }   

    }
  }
}
