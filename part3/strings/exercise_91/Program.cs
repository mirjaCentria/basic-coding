using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
    public static void Main(string[] args)
    {
      string line;
      string[] words;
      Dictionary<string, int> persons = new Dictionary<string, int>();
      KeyValuePair<string, int> oldest = new KeyValuePair<string, int>("",0);
     
      while(true)
      {
        line = Console.ReadLine();
        if(line == "") break;
        words = line.Split(",");   
        persons.Add(words[0], Convert.ToInt32(words[1]));                  
      }

      
      foreach (KeyValuePair<string, int> person in persons)
      {         
         if(person.Value > oldest.Value) oldest = person; 
      }
      
      Console.WriteLine("Name of the oldest: " + oldest.Key); 
    
    }
  }
}



