using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

        string sLine1 = "Your speed:";
        string sLine2 = "Speeding!";

        int iSpeed = 0;
        int iLimit = 120;

       
        Console.WriteLine(sLine1);
        iSpeed = int.Parse(Console.ReadLine());

        if(iSpeed > iLimit)  Console.WriteLine(sLine2);
            
    }
  }
}
