using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
          string sPrompt1 = "Give the first string:";
          string sPrompt2 = "Give the second string:";
          string sSame = "Echo!";
          string sDiffer = "Nope!";
          string sFirst = "";
          string sSecond = "";
    
          Console.WriteLine(sPrompt1);
          sFirst = Console.ReadLine();
          Console.WriteLine(sPrompt2);
          sSecond = Console.ReadLine();

          if(sFirst == sSecond) Console.WriteLine(sSame);
            else Console.WriteLine(sDiffer);

    }
  }
}
