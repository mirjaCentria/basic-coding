using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {

        string sLine1 = "Give the first number!";
        string sLine2 = "Give the second number!";
        string sLine3 = "Give the third number!";
        string sResult = "The sum is ";

        int iFirst = 0;
        int iSecond = 0;
        int iThird = 0;
        int iResult = 0;
       
        Console.WriteLine(sLine1);
        iFirst = int.Parse(Console.ReadLine());
        
        Console.WriteLine(sLine2);
        iSecond = int.Parse(Console.ReadLine());

        Console.WriteLine(sLine3);
        iThird = int.Parse(Console.ReadLine());

        iResult = iFirst + iSecond + iThird; 

        Console.WriteLine(sResult + iResult);

    }
  }
}
