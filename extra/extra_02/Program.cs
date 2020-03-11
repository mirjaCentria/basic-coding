using System;
using System.Collections.Generic;

namespace extra_02
{
  class Program
  {
    public static void Main(string[] args)
    {
      int largest;
      List<int> nmbrs = new List<int>();
       // Add your code here:
      Console.WriteLine("Give three numbers:");
      for(int i = 0; i < 3; i++) 
        nmbrs.Add(Convert.ToInt32(Console.ReadLine()));

      largest = nmbrs[0];
      foreach(int nmbr in nmbrs)  
      {
        if(nmbr > largest) largest = nmbr;
      }
      Console.WriteLine("Largest: {0}", largest);
      

    

    }
  }
}
