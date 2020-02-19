using System;

namespace exercise_60
{
  class Program
  {
        public static void Main(String[] args)
    {
<<<<<<< HEAD
=======
        PrintStars(5);
        PrintStars(1);
        PrintStars(0);
        PrintSquare(4);
        PrintRectangle(17, 4);
        PrintTriangle(5);
>>>>>>> b0e4e5eb6530598e59326b1a0dffa71e0e93d10b

    }


    public static void PrintStars(int number)
    {
<<<<<<< HEAD
      // you can print one star with the command
      // Console.Write("*");
      // call the print command n times
      // in the end print a line break with the comand
      // Console.WriteLine("");
    }

    public static void PrintSquare(int size)
    {

    }

    public static void PrintRectangle(int width, int height)
    {

=======

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
>>>>>>> b0e4e5eb6530598e59326b1a0dffa71e0e93d10b
    }

    public static void PrintTriangle(int size)
    {
<<<<<<< HEAD

=======
      for(int i = 0; i < size; i++)
      {
        PrintStars(i + 1);
      }
>>>>>>> b0e4e5eb6530598e59326b1a0dffa71e0e93d10b
    }
  }
}
