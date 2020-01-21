using System;

namespace exercise_23
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
        int iResult= 0;
        double dResult = 0;
       
        Console.WriteLine(sLine1);
        iFirst = int.Parse(Console.ReadLine());

        Console.WriteLine(sLine2);
        iSecond = int.Parse(Console.ReadLine());


        iResult = iFirst + iSecond; 
        sResult = $"{iFirst} + {iSecond} = {iResult}";
        Console.WriteLine(sResult); //just to be clever ;)
        //Console.WriteLine(iFirst + " + " + iSecond + " = " + iResult);

        iResult = iFirst - iSecond; 
        sResult = $"{iFirst} - {iSecond} = {iResult}";
        Console.WriteLine(sResult); //just to be clever ;)
        //Console.WriteLine(iFirst + " - " + iSecond + " = " + iResult);

        iResult = iFirst * iSecond; 
        sResult = $"{iFirst} * {iSecond} = {iResult}";
        Console.WriteLine(sResult); //just to be clever ;)
        //Console.WriteLine(iFirst + " * " + iSecond + " = " + iResult);


        dResult = (double)iFirst / iSecond ; 
        sResult = $"{iFirst} / {iSecond} = {dResult}";
        Console.WriteLine(sResult); //just to be clever ;)
        //Console.WriteLine(iFirst + " / " + iSecond + " = " + dResult);

    }
  }
}
