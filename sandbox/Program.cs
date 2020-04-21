namespace sandbox
{
  using System;
  using System.Text.RegularExpressions;

  class Program
  {
    static void Main(string[] args)
    {
      //Regex regex = new Regex("^01[0-9]{7}$");
     // Regex regex = new Regex("^mon|tue|wed|thu|fri|sat|sun$");
        Regex rgx = new Regex("^[aeiou]$");

      Console.Write("Provide a student number: ");
      string number = Console.ReadLine();

      if (rgx.IsMatch("akkkkkkka"))
      {
        Console.WriteLine("consonants");
      }
      else
      {        
        Console.WriteLine("wowels only");
      }
    }
  }
}
