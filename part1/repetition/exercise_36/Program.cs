using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      string sQuestion ="Give a number:";
      string sNegative ="That is negative";
      int answer = 0;


      while (true )     
      {
        Console.WriteLine(sQuestion);
        answer = Convert.ToInt32(Console.ReadLine());  

        if(answer == 0) break;

        if(answer < 0)  Console.WriteLine(sNegative);
        else Console.WriteLine(answer*answer);

      }



      /*Give a number:
> 5
25
Give a number:
> -2
That is negative
Give a number:
> 4
16
Give a number:
0*/

    }
  }
}
