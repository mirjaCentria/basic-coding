using System;

namespace extra_04
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("Give your percent [0 - 100]:");
      int result = Convert.ToInt32(Console.ReadLine());

      if(result < 0)  Console.WriteLine("Impossible");
      else if(result < 50)  Console.WriteLine("Fail");
       else if(result < 60)  Console.WriteLine("Grade: 1");
        else if(result < 70)  Console.WriteLine("Grade: 2");
         else if(result < 80)  Console.WriteLine("Grade: 3");
          else if(result < 90)  Console.WriteLine("Grade: 4");
           else if(result < 100)  Console.WriteLine("Grade: 5");
            else Console.WriteLine("Grade: Outstanding!");
    }
  }
}
