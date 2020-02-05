using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      sum =sum + 1;
      int number = 0; 

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
