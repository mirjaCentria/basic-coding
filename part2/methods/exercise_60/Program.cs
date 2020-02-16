using System;

namespace exercise_60
{
  class Program
  {
        public static void Main(String[] args)
    {
<<<<<<< HEAD
        PrintStars(5);
        PrintStars(1);
        PrintStars(0);
        PrintSquare(4);
        PrintRectangle(17, 4);
        PrintTriangle(5);
=======
>>>>>>> d639698b175307c9b8a4dd44d945b896f41cb5e6

    }


    public static void PrintStars(int number)
    {
<<<<<<< HEAD

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
=======
      // you can print one star with the command
      // Console.Write("*");
      // call the print command n times
      // in the end print a line break with the comand
      // Console.WriteLine("");
>>>>>>> d639698b175307c9b8a4dd44d945b896f41cb5e6
    }

    public static void PrintSquare(int size)
    {
<<<<<<< HEAD
      for(int i = 0; i < size; i++)
      {
        PrintStars(size);
      }  
=======

>>>>>>> d639698b175307c9b8a4dd44d945b896f41cb5e6
    }

    public static void PrintRectangle(int width, int height)
    {
<<<<<<< HEAD
      for(int i = 0; i < height; i++)
      {
        PrintStars(width);
      } 
=======

>>>>>>> d639698b175307c9b8a4dd44d945b896f41cb5e6
    }

    public static void PrintTriangle(int size)
    {
<<<<<<< HEAD
      for(int i = 0; i < size; i++)
      {
        PrintStars(i + 1);
      }
=======

>>>>>>> d639698b175307c9b8a4dd44d945b896f41cb5e6
    }
  }
}
