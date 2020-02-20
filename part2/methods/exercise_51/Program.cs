using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      PrintUntilNumber(5);

    }

    public static void PrintUntilNumber(int number)
    {
      for(int i = 1; i < number + 1; i++)
      { 
        Console.WriteLine(i);
      }
    }

  }
}

