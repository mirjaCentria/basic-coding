using System;

namespace exercise_60
{
  class Program
  {
        public static void Main(String[] args)
    {
        PrintStars(5);
        PrintStars(1);
        PrintStars(0);
        PrintSquare(4);
        PrintRectangle(17, 4);
        PrintTriangle(5);

    }


    public static void PrintStars(int number)
    {

      for(int i = 0; i < number; i++)
      {
        Console.Write("*");
      }
      Console.WriteLine("");
    }

    
    public static void PrintSpace(int number)
    {

      for(int i = 0; i < number; i++)
      {
        Console.Write(" ");
      }      
    }

    public static void PrintSquare(int size)
    {
      for(int i = 0; i < size; i++)
      {
        PrintStars(size);
      }  
    }

    public static void PrintRectangle(int width, int height)
    {
      for(int i = 0; i < height; i++)
      {
        PrintStars(width);
      } 
    }

    public static void PrintTriangle(int size)
    {
      for(int i = 0; i < size; i++)
      {
        PrintStars(i + 1);
      }
    }
  }
}
