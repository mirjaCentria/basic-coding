using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
        string sLine1 = "Give your age:";
        string sLine2 = "You´re old";

        int iAge = 0;
        int iLimit = 1900;
       
        Console.WriteLine(sLine1);
        iAge = int.Parse(Console.ReadLine());

        if(iAge < iLimit)  Console.WriteLine(sLine2);

    }
  }
}
