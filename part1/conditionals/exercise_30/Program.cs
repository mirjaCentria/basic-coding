using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
        string sPrompt = "Give your percent [0 - 100]:";    
        Console.WriteLine(sPrompt);
        int iPercent = int.Parse(Console.ReadLine());

        if(iPercent < 0) Console.WriteLine("Impossible");
        else if(iPercent < 49) Console.WriteLine("Fail");
        else if(iPercent < 59) Console.WriteLine("Grade: 1");
        else if(iPercent < 69) Console.WriteLine("Grade: 2");      
        else if(iPercent < 79) Console.WriteLine("Grade: 3");     
        else if(iPercent < 89) Console.WriteLine("Grade: 4");
        else if(iPercent < 100) Console.WriteLine("Grade: 5");
        else  Console.WriteLine("Outstanding!");
     
    }
  }
}
