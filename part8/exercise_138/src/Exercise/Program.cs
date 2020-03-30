   using System;
using System.Collections.Generic;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Dictionary<string, string> names = new Dictionary<string, string>();
      names.Add("matthew", "matt");
      names.Add("michael", "mix");
      names.Add("arthur", "artie");

      foreach( KeyValuePair<string, string> kvp in names )
      {
          System.Console.WriteLine("{0}'s nickname is {1}", 
              kvp.Key, kvp.Value);
      }
     
    }
  }
}