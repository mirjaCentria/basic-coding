using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
     int negsum = 0;
      int number = 0; 

      // Write your code here:
      string sPrompt ="Give a number:";
      string sDone ="Total amount of negative numbers: ";

      while (true )     
      {
        Console.WriteLine(sPrompt);
        number = Convert.ToInt32(Console.ReadLine());  

        if(number == 0) break;
        if(number < 0) negsum++;
      }  
      Console.WriteLine(sDone + negsum);
    }
  }
}
