using System;

namespace exercise_22
{
  class Program
  {
    public static void Main(string[] args)
    {
        string sLine1 = "Give the first number!";
        string sLine2 = "Give the second number!";
        string sLine3 = "Give the third number!";
        string sResult = "";

        int first = 0;
        int second = 0;
        int third = 0;
        double dResult = 0;
       
        Console.WriteLine(sLine1);
        first = int.Parse(Console.ReadLine());

        Console.WriteLine(sLine2);
        second = int.Parse(Console.ReadLine());

        Console.WriteLine(sLine3);
        third = int.Parse(Console.ReadLine());


        dResult = (double)(first + second + third)/3; 
        sResult = $"The average is {dResult}";

        Console.WriteLine(sResult); //just to be clever ;)
       // Console.WriteLine("The average is "  + dResult);

    }
  }
}
