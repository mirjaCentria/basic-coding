using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {
        int nmbr1 = Convert.ToInt32(Console.ReadLine());
        int nmbr2 = Convert.ToInt32(Console.ReadLine());
        double sqroot = Math.Sqrt(nmbr1 +nmbr2);
        Console.WriteLine(sqroot);     
    }
  }
}
