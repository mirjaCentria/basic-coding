using System;

namespace exercise_14
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give me the truth!");
      bool bVal = bool.Parse(Console.ReadLine());
      Console.WriteLine(bVal.ToString());
    }
  }
}
