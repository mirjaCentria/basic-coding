using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
       string sQuestion ="Give a number:";
      int iAnswer = 0;

      while (iAnswer != 42 )     
      {
        Console.WriteLine(sQuestion);
        iAnswer = Convert.ToInt32(Console.ReadLine());  
      }

    }
  }
}
