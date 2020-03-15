using System;
using System.IO;

namespace extra_14
{
  class Program
  {
    public static void Main(string[] args)
    {
      string text = File.ReadAllText("text.txt");
      Console.WriteLine(text);

      string[] lines = File.ReadAllLines("text.txt");
      foreach (string line in lines)
      {
        Console.WriteLine(line);
      }
      // ei mitään eroa. jos olis taulukko ilman ln niin olis
    }
  }
}
