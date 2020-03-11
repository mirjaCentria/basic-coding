using System;
using System.Collections.Generic;

namespace extra_03
{
  class Program
  {
    public static void Main(string[] args)
    {
      
      List<int> nmbrs = new List<int>();
       // Add your code here:
      Console.WriteLine("How many numbers:");
      int many = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Give {0} numbers:", many);
      for(int i = 0; i < many; i++) 
        nmbrs.Add(Convert.ToInt32(Console.ReadLine())); 
      
      int sum = 0;
      foreach(int nmbr in nmbrs)  
      {
        sum += nmbr;
      }

      int total = 1;
      foreach(int nmbr in nmbrs)  
      {
        total *= nmbr;
      }

      Console.WriteLine("Their sum: {0}", sum);
      Console.WriteLine("Their total: {0}", total);
      Console.WriteLine("Their average: {0}", total/sum);
    }
  }
}
