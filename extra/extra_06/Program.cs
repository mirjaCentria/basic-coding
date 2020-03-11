using System;

namespace extra_06
{
  class Program
  {
    public static void Main(string[] args)
    {

      int one = Convert.ToInt32(Console.ReadLine());
      int two = Convert.ToInt32(Console.ReadLine());

      if(one + two < 0) Console.WriteLine("0");
      else Console.WriteLine(Math.Sqrt(one + two));       

    }
  }
}
