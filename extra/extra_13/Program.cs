using System;
using System.Collections.Generic;

namespace extra_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<Person> kindergarten = new List<Person>();
      kindergarten.Add(new Person("Matti", 3));
      kindergarten.Add(new Person("Minna", 4));
      kindergarten.Add(new Person("Liisa", 2));
      kindergarten.Add(new Person("Lassi", 2));

      foreach (Person child in kindergarten) 
      {
        Console.WriteLine(child);
      }
    }
  }
}
