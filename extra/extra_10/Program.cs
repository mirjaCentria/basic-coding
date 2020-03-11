using System;

namespace extra_10
{
  class Program     
  {
    public static void Main(string[] args)
    {
      int[] array = {5, 1, 3, 4, 2};
      PrintArrayInStars(array);

    }

    public static void PrintArrayInStars(int[] array) 
    {
      for(int i = 0; i < array.Length; i++)
      {
        for(int j = 0; j <  array[i]; j++)
        {
          Console.Write("*");
        }
        Console.WriteLine("");
      }
    }
  }
}
