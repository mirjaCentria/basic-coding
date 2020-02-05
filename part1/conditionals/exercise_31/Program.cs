using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
        string sPrompt = "Give a number:";
        string sEven = "It is even.";
        string sOdd = "It is odd.";
      
        Console.WriteLine(sPrompt);
        int iNumber = int.Parse(Console.ReadLine());
        int iRem = iNumber%2;

       if(iRem == 0 )  Console.WriteLine(sEven);
           else Console.WriteLine(sOdd);
        

    }
  }
}
