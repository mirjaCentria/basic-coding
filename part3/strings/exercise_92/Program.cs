using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
    string line;
      string[] words;
      Dictionary<string, int> persons = new Dictionary<string, int>();
     
      while(true)
      {
        line = Console.ReadLine();
        if(line == "") break;
        words = line.Split(",");   
        persons.Add(words[0], Convert.ToInt32(words[1]));                  
      }

      int oldest = 2020;
      string longest = "";
      foreach (KeyValuePair<string, int> person in persons)
      {
         //Console.WriteLine("{0}, {1}", person.Key, person.Value);
         if(person.Value < oldest) oldest = person.Value;
         if(person.Key.Length > longest.Length) longest = person.Key;
      }
      oldest = 2020 - oldest;
      Console.WriteLine("Longest name: " + longest); 
      Console.WriteLine("Highest age: " + oldest); 
    
    }
  }
}



