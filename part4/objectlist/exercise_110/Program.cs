using System;
using System.Collections.Generic;

namespace exercise_110
{
  class Program
  {
    public static void Main(string[] args)
    {
      string answer;
      string sQuestion = "Name:";
      List<Item> itemList = new List<Item>();

      while (true )     
      {
        Console.WriteLine(sQuestion);
        answer = Console.ReadLine();  

        if(answer == "") break;

        Item newItem = new Item(answer);
        itemList.Add(newItem);
      }

      foreach(Item item in itemList)
      {
         Console.WriteLine(item);

      }
    }
  }
}




