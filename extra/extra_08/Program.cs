using System;

namespace extra_08
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give tree height:");
      int height = Convert.ToInt32(Console.ReadLine());
      ChristmasTree(height);


    }

    public static void ChristmasTree(int height) 
    {
        for(int i = 0; i < height; i++)
        {
          for(int j = height - i -1; j > 0 ; j--)
          {
            Console.Write(" ");
          }
          for(int k = 0; k < 2*i +1; k++)
          {
            Console.Write("*");
          }
          Console.WriteLine("");
        }

        for(int i = 0; i < 2; i++)
        {
          for(int j = 0; j < height - 2; j++) Console.Write(" ");
          for(int j = 0; j < 3; j++) Console.Write("*");
          Console.WriteLine("");
        }
    }
  }
}
