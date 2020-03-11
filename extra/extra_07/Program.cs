using System;

namespace extra_07
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      string word = "";

      Console.WriteLine("Give integers, 'end' quits:");
      while(true)
      {
         word = Console.ReadLine();
         if(word == "end") break;
         else sum += Convert.ToInt32(word);
      }

      Console.WriteLine("Sum: {0}", sum);     

    }
  }
}
