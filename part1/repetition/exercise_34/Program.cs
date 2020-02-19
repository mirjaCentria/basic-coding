using System;

namespace exercise_34
{
  class Program
  {
    public static void Main(string[] args)
    {
      string sQuestion ="Do you want to continue?";
      string sAnswer = "";

      while (sAnswer != "no" )     
      {
        Console.WriteLine(sQuestion);
        sAnswer = Console.ReadLine();    
      }
    }
  }
}
