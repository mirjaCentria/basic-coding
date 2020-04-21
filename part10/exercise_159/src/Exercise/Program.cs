

namespace Exercise
{
  using System;
  using System.IO;
  using System.Collections.Generic;
  using System.Text.RegularExpressions;
  
  public class Program
  {
    public static void Main(string[] args)
    {
      Checker check = new Checker();
     // Console.WriteLine(check.DayOfWeek("mon"));
     // Console.WriteLine(check.DayOfWeek("blaa"));
      Console.WriteLine(check.DayOfWeek("tue"));
       Console.WriteLine(check.DayOfWeek("tues"));

    // Console.WriteLine("wowels");
      Console.WriteLine(check.AllVowels("aeiouaaeeioiouoiaoueaiaeiou"));
      Console.WriteLine(check.AllVowels("aeiouaaeeioiouoKiaoueaiaeiou"));
      
    //  Console.WriteLine("time of day");
      Console.WriteLine(check.TimeOfDay("23:23:59"));
      Console.WriteLine(check.TimeOfDay("00:00:60"));
    }
  }
}
