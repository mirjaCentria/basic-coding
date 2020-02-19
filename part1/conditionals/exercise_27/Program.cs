using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
        string sLine1 = "Give a number:";
        string sLine2 = "It is positive";
        string sLine3 = "It is not positive";

        int iNumber = 0;            
       
        Console.WriteLine(sLine1);
        iNumber = int.Parse(Console.ReadLine());

        if(iNumber > 0)  Console.WriteLine(sLine2);
          else Console.WriteLine(sLine3);

    }
  }
}
