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

        int first = 0;   
        int second =18;         
       
        Console.WriteLine(sLine1);
        first = int.Parse(Console.ReadLine());

        Console.WriteLine(sLine2);
        second = int.Parse(Console.ReadLine());

        if(first < second)  Console.WriteLine(sLine3 + second + "!");
          else if( second < first) Console.WriteLine(sLine3 + first +"!");
            else Console.WriteLine(sLine4);

    }
  }
}
