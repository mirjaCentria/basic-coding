using System;

namespace exercise_21
{
  class Program
  {
    public static void Main(string[] args)
    {
        string sLine1 = "Give the first number!";
        string sLine2 = "Give the second number!";
        string sResult = "";

        int iFirst = 0;
        int iSecond = 0;
        double dResult = 0;
       
        Console.WriteLine(sLine1);
        iFirst = int.Parse(Console.ReadLine());
        
        Console.WriteLine(sLine2);
        iSecond = int.Parse(Console.ReadLine());

        dResult = (double)(iFirst + iSecond )/2; 
        sResult = $"The average is {dResult}";

        Console.WriteLine(sResult); //just to be clever ;)
        Console.WriteLine("The average is "  + dResult);

    }
  }
}
