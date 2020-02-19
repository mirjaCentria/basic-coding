using System;
using System.Collections.Generic;

namespace exercise_79
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT CHANGE THE FOLLOWING CODE!
      int[] array = new int[10];
      array[0] = 6;
      array[1] = 2;
      array[2] = 8;
      array[3] = 1;
      array[4] = 3;
      array[5] = 0;
      array[6] = 9;
      array[7] = 7;

      Console.WriteLine("Search for?");
      int searching = Convert.ToInt32(Console.ReadLine());
      int foundAt = array.Length + 1;
      // Implement the search functionality here
      for(int i = 0; i < array.Length; i++)
      {
        if(array[i] == searching) 
        {
          foundAt = i;
          Console.WriteLine("{0} is at index {1}.", searching, i);
        }        
      }
      if(foundAt > array.Length) Console.WriteLine("{0} was not found.", searching);

    }

  }
}


