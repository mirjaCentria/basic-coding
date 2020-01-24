using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      int number = 0; 

      // Write your code here:
      string sPrompt ="Give a number:";
      string sDone ="Total amount of numbers: ";

      while (true )     
      {
        Console.WriteLine(sPrompt);
        number = Convert.ToInt32(Console.ReadLine());  

        if(number == 0) break;
        sum = sum + 1;

      }  
      Console.WriteLine(sDone + sum);
    }
  }
}
