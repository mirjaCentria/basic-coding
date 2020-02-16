using System;
using System.Collections.Generic;

namespace exercise_90
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

      int oldest = 0;
      foreach (KeyValuePair<string, int> person in persons)
      {
         //Console.WriteLine("{0}, {1}", person.Key, person.Value);
         if(person.Value > oldest) oldest = person.Value;
      }
      
      Console.WriteLine("Age of the oldest: " + oldest); 
    }
  }
}



