using System;
using System.IO;

namespace exercise_116
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Read the file data.txt and print the text from it as it is
      // You can use either File.Re::adAllText or File.Re::adAllLines

      string path = @"data.txt";
      if (File.Exists(path))
      {
          string s = File.ReadAllText(path); 
          if (s != null)
          {
              Console.WriteLine(s);
          }
      }
    }
  }
}
