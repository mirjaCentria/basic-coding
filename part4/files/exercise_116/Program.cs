using System;
using System.IO;

namespace exercise_116
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Read the file data.txt and print the text from it as it is
      // You can use either File.ReadAllText or File.ReadAllLines

      string path = @"data.txt";
      if (File.Exists(path))
      {
        using (StreamReader sr = File.OpenText(path))
        {
          string s;
          while ((s = sr.ReadLine()) != null)
          {
              Console.WriteLine(s);
          }
        }
      }
    }
  }
}
