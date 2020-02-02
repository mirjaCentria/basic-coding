using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
      Division(2, 3);
    }

    public static void Division(int numerator, int denominator)
    {
      double result = (double)numerator/denominator;
      Console.WriteLine(result);
    }
  }
}
