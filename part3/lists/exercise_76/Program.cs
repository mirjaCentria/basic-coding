using System;
using System.Collections.Generic;

namespace exercise_76
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> numbers = new List<int>();
      numbers.Add(3);
      numbers.Add(2);
      numbers.Add(6);
      numbers.Add(-1);
      Console.WriteLine(Sum(numbers));
    }

    public static int Sum(List<int> numbers) 
    {
      int result = 0;

      foreach (int item in numbers)
      {
          result = result + item;
      }
      return result;
    }

  }
}


