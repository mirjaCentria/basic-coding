using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
        string sLine1 = "How old are you?";
        string sLine2 = "You're under age!";
        string sLine3 = "You're an adult!";

        int iAge = 0;   
        int iLimit =18;         
       
        Console.WriteLine(sLine1);
        iAge = int.Parse(Console.ReadLine());

        if(iAge < iLimit)  Console.WriteLine(sLine2);
          else Console.WriteLine(sLine3);

    }
  }
}
