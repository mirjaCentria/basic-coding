using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
        string sLine1 = "Give the first number!";
        string sLine2 = "Give the second number!";
        string sLine3 = "The larger number is ";
        string sLine4 = "They are equal!";

        int iFirst = 0;   
        int iSecond =18;         
       
        Console.WriteLine(sLine1);
        iFirst = int.Parse(Console.ReadLine());

        Console.WriteLine(sLine2);
        iSecond = int.Parse(Console.ReadLine());

        if(iFirst < iSecond)  Console.WriteLine(sLine3 + iSecond + "!");
          else if( iSecond < iFirst) Console.WriteLine(sLine3 + iFirst +"!");
            else Console.WriteLine(sLine4);

    }
  }
}
