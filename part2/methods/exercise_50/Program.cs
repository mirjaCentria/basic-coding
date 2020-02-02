using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("How many times?");
      int nmbr = Convert.ToInt32(Console.ReadLine());
      for(int i = 0; i < nmbr; i++)
      {
        PrintPhrase();
      }  
    }

    public static void PrintPhrase() {
      string testLine = "In a hole in the ground there lived a method";
      Console.WriteLine(testLine);
    }
  }
}
