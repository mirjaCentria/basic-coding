using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {
        string sLine1 = "Give the first number!";
        string sLine2 = "Give the second number!";
        string sResult = "The sum is ";

        int first = 0;
        int second = 0;
        int result = 0;
       
        Console.WriteLine(sLine1);
        first = int.Parse(Console.ReadLine());
        
        Console.WriteLine(sLine2);
        second = int.Parse(Console.ReadLine());

        result = first + second; 

        Console.WriteLine(sResult + result);

    }
  }
}
