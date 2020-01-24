using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0; 
      int number = 0; 

      string sPrompt ="Give a number:";
      string sDone ="Total sum of numbers: ";

      while (true )     
      {
        Console.WriteLine(sPrompt);
        number = Convert.ToInt32(Console.ReadLine());  

        if(number == 0) break;
        sum = sum + number;

      }  
      Console.WriteLine(sDone + sum);
    }
  }
}
