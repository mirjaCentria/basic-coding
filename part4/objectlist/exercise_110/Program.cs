using System;
using System.Collections.Generic;

namespace exercise_110
{
  class Program
  {
    public static void Main(string[] args)
    {
      string answer;
      string sQuestion = "Name: ";
      List<Item> items = new List<Item>();

      while (true )     
      {
        Console.Write(sQuestion);
        answer = Console.ReadLine();  

        if(answer == "") break;

        Item newItem = new Item(answer);
        items.Add(newItem);
      }
      Console.WriteLine("");

      foreach(Item item in items)
      {
         Console.WriteLine(item);

      }
    }
  }
}


