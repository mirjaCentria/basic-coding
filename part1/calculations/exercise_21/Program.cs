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

        int first = 0;
        int second = 0;
        double dResult = 0;
       
        Console.WriteLine(sLine1);
        first = int.Parse(Console.ReadLine());
        
        Console.WriteLine(sLine2);
        second = int.Parse(Console.ReadLine());

        dResult = (double)(first + second )/2; 
        sResult = $"The average is {dResult}";

        Console.WriteLine(sResult); //just to be clever ;)
      //  Console.WriteLine("The average is "  + dResult);

    }
  }
}
