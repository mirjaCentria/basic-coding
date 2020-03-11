using System;
using System.Collections.Generic;

namespace extra_09
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>() { "This is a string", "This is magic", "THIS IS PATRICK!" };

      for(int i = 0; i < list.Count; i++ )
      {
        Console.WriteLine(list[i]);
      }

      int j = 0;
      do
      {
        Console.WriteLine(list[j++]);
      } while(j < list.Count);

      foreach(string line in list)
      {
        Console.WriteLine(line);
      }

    }
  }
}
