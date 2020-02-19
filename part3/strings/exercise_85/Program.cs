using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
      string[,] unpw = { { "alex", "sunshine" }, { "emma", "haskell" } };
    
      Console.WriteLine("Enter username:");
      string un = Console.ReadLine();
      Console.WriteLine("Enter password:");
      string pw = Console.ReadLine();

      int index = 0;
      for(index = 0; index < unpw.Length/2; index++)
      {
         if(unpw[index,0] == un && unpw[index , 1] == pw) 
         {
           Console.WriteLine("You have successfully logged in!");
           break;
         }
      }
      if(index == unpw.Length/2) 
          Console.WriteLine("Incorrect username or password!");
    }
  }
}

