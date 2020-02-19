using System;

namespace exercise_115
{
  class Program
  {
    public static void Main(string[] args)
    {
      string line;
      //int number = 0;

      while(true)
      {
          line = Console.ReadLine();
          if(line == "end") break;
          Console.WriteLine(Math.Pow(Convert.ToInt32(line),3)); 
      }
    }
  }
}
