using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
        string sLine1 = "Give a number:";
        string sLine2 = "Orwell";

        int iNumber = 0;
        int iOrwell = 1984;

       
        Console.WriteLine(sLine1);
        iNumber = int.Parse(Console.ReadLine());

        if(iNumber == iOrwell)  Console.WriteLine(sLine2);

    }
  }
}
