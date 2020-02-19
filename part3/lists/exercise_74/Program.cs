using System;
using System.Collections.Generic;

namespace exercise_74
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);       
      } 

      Console.WriteLine("Search for?");
      string sfor = Console.ReadLine();
      bool flag = false;

      foreach(string value in list)
      {
        if(value == sfor) 
        {
          Console.WriteLine(sfor + " was found!");
          flag = true;
        } 
      }
      if(!flag) Console.WriteLine(sfor + " was not found!");   

    }
  }
}

