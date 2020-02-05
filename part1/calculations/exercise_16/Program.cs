using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

              string sLine = "How many days?";
        int iDays = 0;
        int iSeconds = 0;
       
        Console.WriteLine(sLine);
        iDays = int.Parse(Console.ReadLine());

        iSeconds = iDays*86400; //24 h x 60 min x 60 s

        Console.WriteLine(iSeconds);
    }
  }
}
