using System;
using System.Collections.Generic;

namespace exercise_72
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == 9999)
        {
          break;
        }
        list.Add(input);
      }

      bool flag = false;
      int smallest = 9999;
      
      foreach(int item in list)
      {
        if(item < smallest) smallest = item;
      }

      for(int i = 0; i < list.Count; i++)
      {
        if(list[i] == smallest) 
        {
          if(!flag)
          {          
            Console.WriteLine("Smallest number: " + smallest);
            flag = true;
          }
          Console.WriteLine("Found at index: " + i);
        }      
      }        
    }
  }
}
