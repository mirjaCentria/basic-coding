using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0; 
      int number = 0; 
      int amount = 0;

      string sPrompt ="Give a number:";
      string sSum ="Total sum of numbers: ";
      string sAmount ="Total amount of numbers: ";

      while (true )     
      {
        Console.WriteLine(sPrompt);
        number = Convert.ToInt32(Console.ReadLine());  

        if(number == 0) break;
        sum = sum + number;
        amount++;

      }  
      Console.WriteLine(sSum + sum);
      Console.WriteLine(sAmount + amount);
    }
  }
}
